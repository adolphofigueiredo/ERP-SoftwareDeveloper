'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 08/03/2024

Esercizio: Numeri pari
Chiedere in input un numero N. Stampare i numeri pari tra 0 e N.

Esempio:

Input N=4 Output: 0 2 4

'''

# Sezione di input Dati

n = int(input("Inserisci il numero: "))

# Inizializzazioni variabili

stampare = 0
counter = 0

# Elaborazione

if n > 0:
    while stampare <= n:
        print(stampare, end=" | ")
        counter += 1
        stampare = counter * 2                        # O sinal % retorna somente o resto da divisao.
else:
    print("Il numero deve essere positivo.")

# Eventuali sotto processi di Elaborazione

# Sezione di output