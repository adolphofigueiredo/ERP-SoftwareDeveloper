'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: I tre pozzi
Si chieda in input le profondità di tre pozzi differenti. Si stampi in output se si hanno
almeno due pozzi con stessa profondità.

'''
A = int(input("Inserisci la profondità del primo pozzo: "))
B = int(input("Inserisci la profondità del secondo pozzo: "))
C = int(input("Inserisci la profondità del terzo pozzo: "))
count = 0

if A == B:
    count = count + 1
if B == C:
    count = count + 1
if A == C:
    count = count + 1
if count == 0:
    print ("Tutte le profondità sono diverse.")
elif  count == 1:
    print("Due pozzi hanno la stessa profondità.")
else:
    print("Tutti i pozzi hanno la stessa profondità.")