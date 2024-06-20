'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 11/03/2024

Esercizio: Conteggio maggiore
Dati N numeri determinare il valore maggiore e quante volte esso ricorre.

Esempio

Input N = 5 N numeri: { 10,12, 2, 12, 2 }
Output: 12 2

'''
# Sezione di input Dati

n = int(input("Inserisci il numero di dati da inserire: "))
while n <= 0:
    n = int(input("\nIl numero deve essere positivo!\n\nInserisci il numero di dati da inserire: "))

contatore = 1
maxvolte = 0

test = int(input("\nInserisci il numero {}: ".format(contatore)))

# Inizializzazioni variabili

maxvolte += 1
max = test

# Elaborazione

for x in range (1, n):
    contatore += 1
    test = int(input("\nInserisci il numero {}: ".format(contatore)))
    if test == max:
        maxvolte += 1
    elif test > max:
        maxvolte = 1
        max = test

# Eventuali sotto processi di Elaborazione

# Sezione di output
        
if maxvolte == 1:
    print("\nIl valore magiore è {} ed è stato inserito {} volta.\n".format(max,maxvolte))
else:
    print("\nIl valore magiore è {} ed è stato inserito {} volte.\n".format(max,maxvolte))