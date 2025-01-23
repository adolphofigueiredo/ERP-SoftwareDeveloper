import pandas as pd
import tempfile
import os
from app.conn_db.db import get_db, close_db

def process_codice_pezzo(file_path):
    df_cleaned = clean_csv(file_path)

    insert_into_db(df_cleaned)

def clean_csv(csv_file):

    df = pd.read_csv(csv_file)

    df = df.drop_duplicates(subset="ID")


    df = df.dropna()

    columns_to_validate = {
        "ID": 50,
        "ID_Pezzo": 50,
        "Descrizione_Pezzo": 255,
        "ID_Stampo": 50
    }

    for column, max_length in columns_to_validate.items():

        df[column] = df[column].fillna("").astype(str)

        df = df[df[column].str.len() <= max_length]

    # Convalida i valori numerici per le colonne FLOAT
    numeric_columns = ["Temp_Max_Pezzo", "Temp_Min_Pezzo", "Peso_Max_Pezzo", "Peso_Min_Pezzo"]
    for column in numeric_columns:
        df[column] = pd.to_numeric(df[column], errors='coerce')
        df = df.dropna(subset=[column])

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
            copy_query = "COPY public.codice_pezzo FROM STDIN WITH CSV"
            conn.run(copy_query, stream=f)

        # Conferma la transazione
        conn.run("COMMIT")
        print("Dati caricati con successo.")

    except Exception as e:
        print(f"Errore durante l'inserimento dei dati nel database: {e}")
        if conn:
            conn.run("ROLLBACK")
        raise
    finally:
        # Rimuovi il file temporaneo
        if temp_file_name and os.path.exists(temp_file_name):
            os.remove(temp_file_name)
            print(f"File temporaneo {temp_file_name} eliminato.")

        if conn:
            close_db()
