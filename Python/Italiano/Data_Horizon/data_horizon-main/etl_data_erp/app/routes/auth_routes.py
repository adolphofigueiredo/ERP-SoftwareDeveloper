from flask import Blueprint, request, redirect, render_template

from app.config import Config
from app.services.sharepoint_service import list_sharepoint_folders
import logging

logging.basicConfig(level=logging.DEBUG)
logger = logging.getLogger(__name__)

auth_bp = Blueprint("auth", __name__, template_folder="templates")

@auth_bp.route('/login', methods=['POST'])
def login():
    username = request.form.get('username')
    password = request.form.get('password')

    s_credenziali_ricevuti = "Username e password ricevuti" if (len(password) > 0 and len(username) > 0) else "Mancanza credenziali"

    print(f": {s_credenziali_ricevuti}")

    # Connetti a SharePoint usando le credenziali del form
    try:
        list_sharepoint_folders(
            base_url=Config.SHAREPOINT_URL,
            relative_url=Config.RELATIVE_FOLDER_URL,
            username=username,
            password=password
        )
        print("Operazione completata.")

        # Dopo l'operazione completata, fai un redirect a http://localhost:3000/
        #return redirect("http://localhost:3000/")
        return render_template('dashboard/home.html')
    except Exception as e:
        print(f"Errore durante l'esecuzione: {e}")

    return "Credenziali ricevute! Controlla il terminale per i dettagli."
