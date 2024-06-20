'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: Promozione cinema
Realizzare un programma che dopo aver chiesto l'età all'utente indica se tale persona può
usufruire della promozione del cinema. La promozione è riservata a coloro che hanno più
di 64 anni oppure a chi ha tra 5 e 18 anni.


'''

eta = int(input("Inserisci la tua età: "))
if (eta>=64) or (eta>=5 and eta<=18):
    print("Puo usufruire!")
else:
    print("Non puo usufruire!")