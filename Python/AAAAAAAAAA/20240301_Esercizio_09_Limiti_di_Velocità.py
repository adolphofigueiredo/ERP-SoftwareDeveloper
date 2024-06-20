'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: Limiti di velocità

Dato l’articolo 142 del Codice della strada:

➔ Chiunque non osserva i limiti minimi di velocità ovvero supera i limiti massimi
di velocità di non oltre 10 km/h, è soggetto alla sanzione amministrativa del
pagamento di una somma da euro 36.

➔ Chiunque supera di oltre 10 km/h e di non oltre 40 km/h i limiti massimi di velocità è
soggetto alla sanzione amministrativa del pagamento di una somma di euro 148.

➔ Chiunque supera di oltre 40 km/h ma non di oltre 60 km/h i limiti massimi di velocità
è soggetto alla sanzione amministrativa del pagamento di una somma di euro
370.

➔ Chiunque supera di oltre 60 km/h i limiti massimi di velocità è soggetto alla sanzione
amministrativa del pagamento di una somma da euro 500.

Si progetti un algoritmo che legga in input la velocità massima consentita e la velocità
rilevata e stampi un messaggio del tipo:
"Limite rispettato" oppure "Limite violato e la multa da pagare è ...".

'''

limite = int(input("Inserisci il limite massimo di velocità (Km/h): "))
velocita = int(input("Inserisci il limite di velocità rilevata (Km/h): "))

if velocita > limite + 60:
    print("Limite violato e la multa da pagare è €500.")
elif velocita > limite + 40:
    print("Limite violato e la multa da pagare è €370.")
elif velocita > limite + 10:
    print("Limite violato e la multa da pagare è €148.")
elif velocita > limite:
    print("Limite violato e la multa da pagare è €36.")
else:
    print("Limite rispettato!")