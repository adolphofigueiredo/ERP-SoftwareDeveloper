'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 08/03/2024

Esercizio: Numeri pari (2)
Si abbia in input un numero N. Stampare i dieci numeri pari successivi al numero N.

'''

# Sezione di input Dati

num = int(input("\nInserisci il numero: "))
accumulatore = num

# Inizializzazioni variabili
# Elaborazione

print("\nI dieci numeri pari successivi al numero {} sono: \n".format(num))

if num % 2 == 0:                               #numeri pari
    for contatore in range (1,11):
        accumulatore = accumulatore + 2
        print(accumulatore, end=" | ")
else:                                          #numeri dispari
    accumulatore = accumulatore + 1
    for contatore in range (1,11):
        print(accumulatore, end=" | ")
        accumulatore = accumulatore + 2


# Eventuali sotto processi di Elaborazione
# Sezione di output