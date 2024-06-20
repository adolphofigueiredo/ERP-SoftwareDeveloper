'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 15/03/2024

Esercizio: Coppie di opposti
Date N coppie di numeri contare e stampare quelle che hanno i valori l'uno
l'opposto dell'altro.

'''

# Sezione di input Dati

n = int(input("\nInserisci il numero di coppie da inserire: "))
while n <= 0:
    n = int(input("\nIl numero deve essere positivo!\n\nInserisci il numero di coppie da inserire: "))
        
# Inizializzazioni variabili
    
contatore = 0
opposto = 0

# Elaborazione

while contatore < n:
    contatore += 1
    coppia1 = int(input("\nInserisci il primo numero della coppia {}: ".format(contatore)))
    while coppia1 == 0:
        coppia1 = int(input("\nIl numero deve essere diverso di 0!\n\nInserisci il primo numero della coppia {}: ".format(contatore)))
    coppia2 = int(input("\nInserisci il secondo numero della coppia {}: ".format(contatore)))
    while coppia2 == 0:
        coppia2 = int(input("\nIl numero deve essere diverso di 0!\n\nInserisci il secondo numero della coppia {}: ".format(contatore)))
    if (coppia1 * -1) == coppia2:
        opposto += 1
        print("\nQuesta coppia ha i valori opposti.\n")
    else:
        print("\nQuesta coppia non ha i valori opposti.\n")

# Eventuali sotto processi di Elaborazione



# Sezione di output

if opposto == 1:
    print("\n{} coppia ha i valori opposti.\n".format(opposto))
else:
    print("\n{} coppie hanno i valori opposti.\n".format(opposto))
