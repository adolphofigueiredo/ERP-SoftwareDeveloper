'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 15/03/2024

Esercizio: Ricalcolo assicurazione
Date N assicurazioni di automobili definite come la coppia (importo, incidente), dove
incidente vale 0 se non vi è stato un incidente oppure 1 se vi è stato almeno un incidente.
Ogni importo viene aumentato del 10% se vi è stato un incidente, altrimenti viene scontato
del 6%. Calcolare la somma degli importi e stampa il risultato.

'''

# Sezione di input Dati

n = int(input("Inserisci il numero di assicurazioni: "))
while n <= 0:
    n = int(input("\nIl numero deve essere positivo!\n\nInserisci il numero di assicurazioni: "))

# Inizializzazioni variabili

somma = 0
contatore = 0

# Elaborazione

while contatore < n:
    contatore += 1
    ciclo = True
    importo = int(input("\nInserisci l'importo {}: ".format(contatore)))
    while importo <= 0:
        importo = int(input("\nIl numero deve essere positivo!\n\nInserisci l'importo {}: ".format(contatore)))                
    while ciclo == True:
        incidente = input("\nScegli un'opzione:\n0 - Nessun incidente\n1 - Almeno un incidente\n")
        match incidente:
            case "0":
                importofinale = importo * 0.94
                somma = somma + importofinale
                ciclo = False
            case "1":
                importofinale = importo * 1.1
                somma = somma + importofinale
                ciclo = False
            case _:
                print("\nSelezioni un'opzione valida!\n")

# Eventuali sotto processi di Elaborazione

# Sezione di output

print("\nLa somma degli importi è {}.\n".format(somma))