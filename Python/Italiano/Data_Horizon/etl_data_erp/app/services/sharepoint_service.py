import os
from office365.runtime.auth.authentication_context import AuthenticationContext
from office365.sharepoint.client_context import ClientContext

from app.services.etl_service import process_csv_file


def list_sharepoint_folders(base_url, relative_url, username, password):
    """
    Connette a SharePoint e stampa le sottocartelle nella console.
    """
    try:
        # Autenticazione
        ctx_auth = AuthenticationContext(base_url)
        if not ctx_auth.acquire_token_for_user(username, password):
            raise Exception("Autenticazione fallita. Controlla le credenziali.")

        # Connessione al sito SharePoint
        ctx = ClientContext(base_url, ctx_auth)
        folder = ctx.web.get_folder_by_server_relative_url(relative_url)
        ctx.load(folder)
        ctx.execute_query()
        print(f"Cartella trovata: {folder.serverRelativeUrl}")

        # Recupera file e sottocartelle
        files = folder.files
        subfolders = folder.folders
        ctx.load(files)
        ctx.load(subfolders)
        ctx.execute_query()

        # Elenca file
        if len(files) > 0:
            print("File trovati nella cartella:")
            for file in files:
                print(f"- {file.name}")
                if file.name.endswith(".csv"):
                    print(f"Scaricando file: {file.name}")
                    file_path = os.path.join("./app/tmp", file.name)
                    with open(file_path, "wb") as local_file:
                        file.download(local_file).execute_query()

                    # Passa il file al processo ETL
                    process_csv_file(file_path)

                    # Rimuovi il file dopo l'elaborazione
                    os.remove(file_path)
                    print(f"File elaborato e rimosso: {file.name}")

        else:
            print("Nessun file trovato nella cartella specificata.")

        #Trova le sottocartelle del percorso in cui siamo su Sharepoint
        """
        # Elenca sottocartelle
        if len(subfolders) > 0:
            print("Sottocartelle trovate:")
            for subfolder in subfolders:
                print(f"- {subfolder.serverRelativeUrl}")
        else:
            print("Nessuna sottocartella trovata.")
        """

    except Exception as e:
        print(f"Errore durante l'accesso a SharePoint: {e}")
