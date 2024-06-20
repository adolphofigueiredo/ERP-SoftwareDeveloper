'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 11/03/2024

Esercizio: Media pari e dispari
Dati N numeri calcolare la media aritmetica dei valori pari e quella dei valori dispari.

'''
# Sezione di input Dati

n = int(input("Inserisci il numero di dati da inserire: "))
while n <= 0:
    n = int(input("\nIl numero deve essere positivo!\n\nInserisci il numero di dati da inserire: "))

# Inizializzazioni variabili

pari = 0
mediapari = 0
accumulatorepari = 0
dispari = 0
mediadispari = 0
accumulatoredispari = 0
contatore = 1

# Elaborazione

while contatore <= n:
    test = int(input("\nInserisci il dato {}: ".format(contatore)))
    if test % 2 == 0:
        pari+=1
        accumulatorepari = accumulatorepari + test
    elif test % 2 != 0:
        dispari+=1
        accumulatoredispari = accumulatoredispari + test
    contatore +=1
if pari == 0:
    mediapari = 0
elif pari != 0:
    mediapari = accumulatorepari / pari
if dispari == 0:
    mediadispari = 0
elif dispari != 0:
    mediadispari = accumulatoredispari / dispari

# Eventuali sotto processi di Elaborazione

# Sezione di output

print("\n",pari," numeri pari e la media è ",mediapari)
print("\n",dispari," numeri dispari e la media è ",mediadispari,"\n")