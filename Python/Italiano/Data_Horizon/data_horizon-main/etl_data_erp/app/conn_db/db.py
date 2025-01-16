from flask import current_app, g
import pg8000.native
import re

def get_db():
    """
    Restituisce una connessione al database dal contesto dell'app.
    Se non esiste già, crea una nuova connessione.
    """
    if 'db_conn' not in g:
        try:
            # Recupera l'URI del database
            database_uri = current_app.config['DATABASE_URI']
            print(f"Tentando di connettersi al database: {database_uri.split('@')[-1]}")  # Logging sicuro

            # Parsing della stringa URI
            parsed = re.match(r'postgres(?:ql)?://(.+?):(.+?)@(.+?):(\d+)/(.+)', database_uri)
            if not parsed:
                raise ValueError("Formato DATABASE_URI non valido!")

            user, password, host, port, database = parsed.groups()

            # Tenta di creare la connessione
            g.db_conn = pg8000.native.Connection(
                user=user,
                password=password,
                host=host,
                port=int(port),
                database=database
            )
            print(f"Connesso al database con successo.")
        except Exception as e:
            print(f"Errore durante la connessione al database: {e}")
            raise  # Rilancia l'errore per una gestione superiore
    return g.db_conn

def close_db(e=None):
    """
    Chiude la connessione al database presente nel contesto dell'app.
    """
    db_conn = g.pop('db_conn', None)
    if db_conn is not None:
        db_conn.close()
        print("Connessione al database chiusa.")

def init_db(app):
    """
    Inizializza il database, creando le tabelle necessarie per il progetto.
    """
    with app.app_context():
        try:
            conn = get_db()
            # Inizia una transazione
            conn.run("BEGIN")
            print("Transazione iniziata.")

            # Tabella codice_macchinario
            conn.run(
                """
                DROP TABLE IF EXISTS public.codice_macchinario
                """
            )

            conn.run(
                """
                CREATE TABLE IF NOT EXISTS public.codice_macchinario (
                    id VARCHAR(50) NOT NULL,
                    id_macchinario VARCHAR(50) NOT NULL,
                    nome_macchinario VARCHAR(255) NULL,
                    tipo_macchinario VARCHAR(50) NULL,
                    CONSTRAINT codice_macchinario_pkey PRIMARY KEY (id)
                );
                """
            )

            # Tabella codice_operatore
            conn.run(
                """
                DROP TABLE IF EXISTS public.codice_operatore 
                """
            )

            conn.run(
                """
                CREATE TABLE IF NOT EXISTS public.codice_operatore (
                    id VARCHAR(50) NOT NULL,
                    id_operatore VARCHAR(50) NOT NULL,
                    nome_operatore VARCHAR(255) NOT NULL,
                    data_nascita TIMESTAMP NOT NULL,
                    CONSTRAINT codice_operatore_pkey PRIMARY KEY (id)
                );
                """
            )

            # Tabella codice_pezzo
            conn.run(
                """
                DROP TABLE IF EXISTS public.codice_pezzo 
                """
            )

            conn.run(
                """
                CREATE TABLE IF NOT EXISTS public.codice_pezzo (
                    id VARCHAR(50) NOT NULL,
                    id_pezzo VARCHAR(50) NOT NULL,
                    descrizione_pezzo VARCHAR(255) NOT NULL,
                    temp_max_pezzo FLOAT NOT NULL,
                    temp_min_pezzo FLOAT NOT NULL,
                    peso_max_pezzo FLOAT NOT NULL,
                    peso_min_pezzo FLOAT NOT NULL,
                    id_stampo VARCHAR(50) NOT NULL,
                    CONSTRAINT codice_pezzo_pkey PRIMARY KEY (id)
                );
                """
            )

            # Tabella codice_stampo
            conn.run(
                """
                DROP TABLE IF EXISTS public.codice_stampo 
                """
            )

            conn.run(
                """
                CREATE TABLE IF NOT EXISTS public.codice_stampo (
                    id VARCHAR(50) NOT NULL,
                    id_stampo VARCHAR(50) NOT NULL,
                    descrizione_stampo VARCHAR(255) NOT NULL,
                    CONSTRAINT codice_stampo_pkey PRIMARY KEY (id)
);

                """
            )

            # Tabella costo_produzione
            conn.run(
                """
                DROP TABLE IF EXISTS public.costo_produzione 
                """
            )

            conn.run(
                """
                    CREATE TABLE IF NOT EXISTS public.costo_produzione (
                        id VARCHAR(50) NOT NULL,
                        id_costo_produzione VARCHAR(50) NOT NULL,
                         mesi_di_riferimento TIMESTAMP NOT NULL,
                        costo_totale FLOAT NOT NULL,
                        tipo_costo VARCHAR(255) NOT NULL,
                        costo_forgia BOOLEAN NOT NULL,
                        costo_cnc BOOLEAN NOT NULL,
                        CONSTRAINT costi_produzione_pkey PRIMARY KEY (id)
);


                """
            )

            # Tabella incidente_operatore
            conn.run(
                """
                DROP TABLE IF EXISTS public.incidente_operatore
                """
            )

            conn.run(
                """
                CREATE TABLE IF NOT EXISTS public.incidente_operatore (
                    id VARCHAR(50) NOT NULL,
                    id_incidente_operatore VARCHAR(50) NOT NULL,
                    incidente_operatore_descrizione VARCHAR(255) NOT NULL,
                    CONSTRAINT incidente_operatore_pkey PRIMARY KEY (id)
);



                """
            )

            # Tabella prezzo_acciaio
            conn.run(
                """
                DROP TABLE IF EXISTS public.prezzo_acciaio
                """
            )

            conn.run(
                """
                CREATE TABLE IF NOT EXISTS public.prezzo_acciaio (
                    id VARCHAR(50) NOT NULL,
                    id_tipo_acciaio VARCHAR(50) NOT NULL,
                    tipo_acciaio VARCHAR(255) NOT NULL,
                    prezzo_kg FLOAT NOT NULL,
                    CONSTRAINT prezzo_acciaio_pkey PRIMARY KEY (id)
);


                """
            )

            # Tabella incidente_macchina
            conn.run(
                """
                DROP TABLE IF EXISTS public.incidente_macchina
                """
            )

            conn.run(
                """
                CREATE TABLE IF NOT EXISTS public.incidente_macchina (
                id VARCHAR(50) NOT NULL,
                id_incidente_macchina VARCHAR(50) NOT NULL,
                incidente_macchina_descrizione VARCHAR(255) NOT NULL,
                CONSTRAINT incidente_macchina_pkey PRIMARY KEY (id)

);


                """
            )

            # Tabella produzione_cnc
            conn.run(
                """
                DROP TABLE IF EXISTS public.produzione_cnc
                """
            )

            # Creazione tabella produzione_cnc se non esiste
            conn.run(
                """
                CREATE TABLE IF NOT EXISTS public.produzione_cnc (
                    id VARCHAR(50) PRIMARY KEY,
                    id_produzione_cnc VARCHAR(50),
                    data_ora_produzione_cnc TIMESTAMP,
                    id_pezzo_produzione_forgia_a_cnc VARCHAR(50),
                    numero_pezzi_ora INTEGER,
                    id_incidente_macchina_produzione_cnc VARCHAR(50),
                    id_incidente_operatore_produzione_cnc VARCHAR(50),
                    id_macchinario_produzione_cnc VARCHAR(50),
                    id_operatore_produzione_cnc VARCHAR(50)
                );
                """
            )
            print("Tabella 'produzione_cnc' creata (se non esisteva già).")

            # Tabella produzione_forgia

            conn.run(
                """
                DROP TABLE IF EXISTS public.produzione_forgia;
                """
            )
            # Creazione tabella produzione_forgia se non esiste
            conn.run(
                """
                CREATE TABLE IF NOT EXISTS public.produzione_forgia (
                    id varchar(50) NOT NULL,
                    id_produzione_forgia varchar(50) NULL,
                    peso_pezzo float8 NULL,
                    temperatura float8 NULL,
                    data_ora_produzione timestamp NULL,
                    id_incidente_macchina_produzione_forgia varchar(50) NULL,
                    id_incidente_operatore_produzione_forgia varchar(50) NULL,
                    id_macchinario_produzione_forgia varchar(50) NULL,
                    id_operatore_produzione_forgia varchar(50) NULL,
                    id_pezzo_produzione_forgia varchar(50) NULL,
                    id_tipo_acciaio_produzione_forgia varchar(50) NULL,
                    CONSTRAINT produzione_forgia_pkey PRIMARY KEY (id)
                );
                """
            )
            print("Tabella 'produzione_forgia' creata (se non esisteva già).")

            # Conferma la transazione
            conn.run("COMMIT")
            print("Transazione completata con successo.")
        except Exception as e:
            conn.run("ROLLBACK")
            print(f"Errore durante la creazione della tabella: {e}")
            raise
        finally:
            # Chiudi la connessione
            close_db()
