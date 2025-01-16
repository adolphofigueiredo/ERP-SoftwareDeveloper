import pandas as pd
import tempfile
import os
from app.conn_db.db import get_db, close_db
from datetime import datetime

# colonna TIMESTAMP
def validate_date_format(date_str):
    try:
        datetime.fromisoformat(date_str.replace("Z", "+00:00"))
        return True
    except ValueError:
        return False

# colonne boolean
def validate_boolean(value):
    return str(value).lower() in ["true", "false"]

def process_costo_produzione(file_path):
    df_cleaned = clean_csv(file_path)

    # Connessione al database e inserimento dei dati
    insert_into_db(df_cleaned)

def clean_csv(csv_file):
    # Carica il file CSV
    df = pd.read_csv(csv_file)


    df = df.drop_duplicates(subset="ID")


    df = df.dropna()

    # Convalida la lunghezza massima delle colonne VARCHAR
    columns_to_validate = {
        "ID": 50,
        "ID_Costo_Produzione": 50,
        "Tipo_Costo": 255,
    }

    for column, max_length in columns_to_validate.items():
        # Assicurati che la colonna sia di tipo stringa e gestisci i NaN
        df[column] = df[column].fillna("").astype(str)
        # Filtra le righe con lunghezza del valore inferiore o uguale al limite massimo
        df = df[df[column].str.len() <= max_length]

    # Convalida il formato della data
    df = df[df["Mesi_di_Riferimento"].apply(validate_date_format)]

    # Convalida i valori booleani
    df = df[df["Costo_Forgia"].apply(validate_boolean)]
    df = df[df["Costo_CNC"].apply(validate_boolean)]

    # Converti le colonne boolean in valori booleani reali
    df["Costo_Forgia"] = df["Costo_Forgia"].astype(bool)
    df["Costo_CNC"] = df["Costo_CNC"].astype(bool)

    return df

def insert_into_db(df):
    conn = None
    temp_file_name = None
    try:
        conn = get_db()
        conn.run("BEGIN")

        # Utilizzo di un file temporaneo
        with tempfile.NamedTemporaryFile(delete=False, suffix=".csv") as temp_file:
            temp_file_name = temp_file.name
            # Salva il DataFrame come CSV senza l'header
            df.to_csv(temp_file_name, index=False, header=False)

        with open(temp_file_name, 'r') as f:
            copy_query = f"COPY public.costo_produzione FROM STDIN WITH CSV"
            conn.run(copy_query, stream=f)

        # Conferma la transazione
        conn.run("COMMIT")
        print("Dati caricati con successo.")

    except Exception as e:
        print(f"Errore durante l'inserimento dei dati nel database: {e}")
        conn.run("ROLLBACK")
        raise
    finally:
        # Rimuovi il file temporaneo
        if os.path.exists(temp_file_name):
            os.remove(temp_file_name)
            print(f"File temporaneo {temp_file_name} eliminato.")
        else:
            print(f"File temporaneo {temp_file_name} non trovato.")

        if conn:
            close_db()
