FROM python:3.11-slim
LABEL authors="ICTS23-25.504"

# Imposta la directory di lavoro
WORKDIR /etl_data_erp

# Copia i file del progetto
COPY . .

# Installa le dipendenze
RUN pip install --no-cache-dir -r requirements.txt

# Esporta PYTHONPATH per riconoscere il modulo principale
ENV PYTHONPATH=/etl_data_erp

# Esponi le variabili necessarie per Flask
ENV FLASK_ENV=development

ENV PYTHONUNBUFFERED=1

# Esponi la porta 5000 per Flask
EXPOSE 5000

# Avvia il server Flask
CMD ["flask", "run", "--host=0.0.0.0", "--port=5000"]