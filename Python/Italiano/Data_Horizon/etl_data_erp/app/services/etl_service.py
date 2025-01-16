from app.services.etl_cnc import process_produzione_cnc
from app.services.etl_forgia import process_produzione_forgia
from app.services.etl_cod_macchinario import process_codice_macchinario
from app.services.etl_cod_operatore import process_codice_operatore
from app.services.etl_cod_pezzo import process_codice_pezzo
from app.services.etl_cod_stampo import process_codice_stampo
from app.services.etl_costo_produzione import process_costo_produzione
from app.services.etl_incidente_operatore import process_incidente_operatore
from app.services.etl_prezzo_acciaio import process_prezzo_acciaio
from app.services.etl_incidente_macchina import process_incidente_macchina
def process_csv_file(file_path):
    try:
        # Determina il tipo di file dal nome
        match file_path:
            case _ if "Codice_Macchinario" in file_path:
                process_codice_macchinario(file_path)
            case _ if "Codice_Operatore" in file_path:
                process_codice_operatore(file_path)
            case _ if "Produzione_CNC" in file_path:
                process_produzione_cnc(file_path)
            case _ if "Produzione_FORGIA" in file_path:
                process_produzione_forgia(file_path)
            case _ if "Codice_Pezzo" in file_path:
                process_codice_pezzo(file_path)
            case _ if "Codice_Stampo" in file_path:
                process_codice_stampo(file_path)
            case _ if "Costo_Produzione" in file_path:
                process_costo_produzione(file_path)
            case _ if "Incidente_Operatore" in file_path:
                process_incidente_operatore(file_path)
            case _ if "Prezzo_Acciaio" in file_path:
                process_prezzo_acciaio(file_path)
            case _ if "Incidente_Macchina" in file_path:
                process_incidente_macchina(file_path)
            case _:
                print(f"Tipo di file sconosciuto: {file_path}")

    except Exception as e:
        print(f"Errore durante l'elaborazione del file {file_path}: {e}")