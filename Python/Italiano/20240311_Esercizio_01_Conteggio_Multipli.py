'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 11/03/2024

Esercizio: Conteggio multipli
Si abbiano in input due numeri interi A e N e dati N numeri contare quanti sono i multipli di
A.

'''

# Sezione di input Dati

n = int(input("Inserisci il numero di dati da inserire: "))
while n <= 0:
    n = int(input("l valore di N deve essere maggiore di zero: "))

a = int(input("Inserisci il fattore da verificare: "))
while a <= 0:
    a = int(input("l valore di A deve essere maggiore di zero: "))

# Inizializzazioni variabili
    
multiplo = 0

# Elaborazione

for x in range (1, n+1):
    test = int(input("Inserisci il valore {}: ".format(x)))
    if test % a == 0 and test > 0:
        multiplo += 1

# Eventuali sotto processi di Elaborazione

# Sezione di output

print(multiplo,"numeri sono i multipli di",a,".")