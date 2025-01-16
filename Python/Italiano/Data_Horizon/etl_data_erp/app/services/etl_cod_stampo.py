import pandas as pd
import tempfile
import os
from app.conn_db.db import get_db, close_db

# Funzione per processare il file CSV "codice_stampo.csv"
def process_codice_stampo(file_path):
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
        "ID_Stampo": 50,
        "Descrizione_Stampo": 255,
    }

    for column, max_length in columns_to_validate.items():

        df[column] = df[column].fillna("").astype(str)
        df = df[df[column].str.len() <= max_length]

    return df

def insert_into_db(df):
    conn = None
    temp_file_name = None
    try:
        conn = get_db()
        conn.run("BEGIN")

        with tempfile.NamedTemporaryFile(delete=False, suffix=".csv") as temp_file:
            temp_file_name = temp_file.name

            df.to_csv(temp_file_name, index=False, header=False)

        with open(temp_file_name, 'r') as f:
            copy_query = "COPY public.codice_stampo FROM STDIN WITH CSV"
            conn.run(copy_query, stream=f)

        conn.run("COMMIT")
        print("Dati caricati con successo.")

    except Exception as e:
        print(f"Errore durante l'inserimento dei dati nel database: {e}")
        if conn:
            conn.run("ROLLBACK")
        raise
    finally:
        if temp_file_name and os.path.exists(temp_file_name):
            os.remove(temp_file_name)
            print(f"File temporaneo {temp_file_name} eliminato.")

        if conn:
            close_db()
