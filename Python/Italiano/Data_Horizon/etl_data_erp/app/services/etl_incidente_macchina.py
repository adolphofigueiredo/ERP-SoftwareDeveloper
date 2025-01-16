import pandas as pd
import tempfile
import os
from app.conn_db.db import get_db, close_db

def process_incidente_macchina(file_path):
    """
    Elabora e carica i dati del CSV 'incidente_macchina' nel database.
    """
    # Pulizia dei dati
    df_cleaned = clean_csv(file_path)

    # Inserimento nel database
    insert_into_db(df_cleaned)

def clean_csv(csv_file):
    """
    Pulisce il CSV rimuovendo duplicati, valori nulli e dati non validi.
    """
    # Carica il file CSV
    df = pd.read_csv(csv_file)

    # Rimuove duplicati basandosi sulla colonna 'ID'
    df = df.drop_duplicates(subset="ID")

    # Rimuove righe con valori nulli
    df = df.dropna()

    # Convalida le lunghezze massime delle colonne
    columns_to_validate = {
        "ID": 50,
        "ID_Incidente_Macchina": 50,
        "Incidente_Macchina_Descrizione": 255,
    }

    for column, max_length in columns_to_validate.items():
        # Assicurati che la colonna sia di tipo stringa e gestisci i NaN
        df[column] = df[column].fillna("").astype(str)
        df = df[df[column].str.len() <= max_length]

    return df

def insert_into_db(df):
    """
    Inserisce i dati puliti nel database usando la query COPY.
    """
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
            copy_query = f"COPY public.incidente_macchina FROM STDIN WITH CSV"
            conn.run(copy_query, stream=f)

        # Conferma la transazione
        conn.run("COMMIT")
        print("Dati caricati con successo.")

    except Exception as e:
        print(f"Errore durante l'inserimento dei dati nel database: {e}")
        conn.run("ROLLBACK")
        raise
    finally:
        # Rimuove il file temporaneo
        if os.path.exists(temp_file_name):
            os.remove(temp_file_name)
            print(f"File temporaneo {temp_file_name} eliminato.")
        else:
            print(f"File temporaneo {temp_file_name} non trovato.")

        if conn:
            close_db()
