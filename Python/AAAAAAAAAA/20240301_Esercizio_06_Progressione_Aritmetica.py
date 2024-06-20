'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: Progressione aritmetica
Il programma letti tre numeri, determini se possono essere considerati in progressione
aritmetica; una progressione aritmetica è una serie di numeri in cui la differenza tra due
numeri successivi è costante.

Esempio:

3 5 7 output: progressione aritmetica
3 4 8 output: Non in progressione aritmetica

'''

A = int(input("Inserisci il primo numero: "))
B = int(input("Inserisci il secondo numero: "))
C = int(input("Inserisci il terzo numero: "))

if (B-A) == (C-B):
    print("Progressione aritmetica!")
else:
    print("Non in progressione aritmetica!")