from dotenv import load_dotenv
from flask import Flask
from app.config import Config
from app.conn_db.db import init_db
from app.routes.auth_routes import auth_bp
from app.routes.main_routes import main_bp


def create_app():
    # Carica il file .env
    load_dotenv()

    app = Flask(__name__)

    # Carica tutte le variabili che iniziano con "FLASK_" dal file .env
    app.config.from_prefixed_env()  # Flask legge automaticamente l'ambiente

    # Inizializza il database
    init_db(app)

    # Registra blueprint
    app.register_blueprint(auth_bp, url_prefix='/auth')
    app.register_blueprint(main_bp)

    return app
