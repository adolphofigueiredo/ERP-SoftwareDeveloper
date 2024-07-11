'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: Patente di guida
In Italia si può prendere la patente B se si ha almeno 18 anni. Progettare un programma
che inserito in input l’età indichi se l’utente puo’ conseguire la patente.

'''

eta = int(input("Inserisci la tua età: "))
if eta>=18:
    print("Puoi prendere la patente!")
else:
    print("Non puoi prendere la patente!")