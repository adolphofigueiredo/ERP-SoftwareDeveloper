import os

class Config:
    SECRET_KEY = os.getenv("SECRET_KEY", "your_secret_key")
    SHAREPOINT_URL = "https://itsictpiemonte.sharepoint.com/sites/datahorizon"
    RELATIVE_FOLDER_URL = "/sites/datahorizon/Documenti condivisi/BI_Update_CSV"

config = Config()
