'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 08/03/2024

Esercizio: Multipli di un intero
Si abbiano in input due numeri interi A e N. Stampare tutti i multipli di A minori di N.

Esempio:

Input A=2 N=13 Output: 4 (2*2) 6 (2*3) 8 (2*4) 10 (2*5) 12(2*6)

'''

# Sezione di input Dati

fattore = int(input("\nInserisci il numero da moltiplicare: "))
massimo = int(input("\nInserisci il numero massimo: "))

# Inizializzazioni variabili

contatore = 0
stampare = 0

# Elaborazione
if fattore > 0 and massimo > 0:
    while stampare <= massimo:
        print(stampare, end=" | ")
        contatore += 1
        stampare = fattore * contatore
else:
    print("\nI numeri devono essere posaitivi.\n")

# Eventuali sotto processi di Elaborazione

# Sezione di output