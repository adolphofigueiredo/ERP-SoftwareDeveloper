'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: Tripletta di numeri
Inseriti tre numeri A, B e C dire se B è compreso in senso stretto tra A e C.

'''

A = int(input("Inserisci il primo numero (A): "))
B = int(input("Inserisci il secondo numero (B): "))
C = int(input("Inserisci il terzo numero (C): "))

if (A<B and B<C) or (A>B and B>C):
    print("B é compresso in senso stretto tra A e C.")
else:
    print("B non é compresso in senso stretto tra A e C.")