import pandas as pd
import tempfile
import os
from app.conn_db.db import get_db, close_db
from datetime import datetime

def validate_timestamp(value):
    try:
        #datetime.strptime(value, "%Y-%m-%dT%H:%M:%SZ")
        datetime.fromisoformat(value.replace("Z", "+00:00"))
        return True
    except ValueError:
        return False

def process_produzione_forgia(file_path):
    df_cleaned = clean_csv(file_path)

    # Connessione al database e inserimento dei dati
    insert_into_db(df_cleaned)

""" Pulizia CSV """
def clean_csv(csv_file):
    # Carica il file CSV
    df = pd.read_csv(csv_file)

    # Rimuove duplicati basati sull'ID (che è PRIMARY KEY nella struttura)
    df = df.drop_duplicates(subset="ID")

    # Rimuove righe con valori nulli
    df = df.dropna()

    # Convalida la lunghezza massima delle colonne VARCHAR
    columns_to_validate = {
        "ID": 50,
        "ID_Produzione_FORGIA": 50,
        "ID_Incidente_Macchina_Produzione_Forgia": 50,
        "ID_Incidente_Operatore_Produzione_Forgia": 50,
        "ID_Macchinario_Produzione_Forgia": 50,
        "ID_Operatore_Produzione_Forgia": 50,
        "ID_Pezzo_Produzione_Forgia": 50,
        "ID_Tipo_Acciaio_Produzione_Forgia": 50,
    }

    for column, max_length in columns_to_validate.items():
        # Assicurati che la colonna sia di tipo stringa e gestisci i NaN
        df[column] = df[column].fillna("").astype(str)
        # Filtra le righe con lunghezza del valore inferiore o uguale al limite massimo
        df = df[df[column].str.len() <= max_length]

    # Convalida il formato della colonna TIMESTAMP
    df = df[df["Data_Ora_Produzione"].apply(validate_timestamp)]

    # Convalida che 'Peso_Pezzo' sia un numero positivo
    df = df[df["Peso_Pezzo"] > 0]
    df = df[df["Temperatura"] > 0]

    return df


""" Inserisce i dati puliti nel database """
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

        with open(temp_file.name, 'r') as f:
            copy_query = f"COPY public.produzione_forgia FROM STDIN WITH CSV"
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