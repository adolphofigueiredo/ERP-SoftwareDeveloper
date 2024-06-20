'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: I due orari
Scrivere un programma che legga 2 orari in ore minuti e secondi e dica quale viene prima
dei due. (Si provi a risolvere l’esercizio senza trasformare tutto in secondi).

'''

ora1 = int(input("Inserisci gli ore (24h) dell orario 1: "))
min1 = int(input("Inserisci i minuti dell orario 1: "))
sec1 = int(input("Inserisci i secondi dell orario 1: "))
ora2 = int(input("Inserisci gli ore (24h) dell orario 2: "))
min2 = int(input("Inserisci i minuti dell orario 2: "))
sec2 = int(input("Inserisci i secondi dell orario 2: "))

if ora1 == ora2:
    if min1 == min2:
        if sec1 == sec2:
            print("Gli orari sono uguale.")
        elif sec1 < sec2:
            print("La prima ora vieni prima.")
        else:
            print("La seconda ora vieni prima.")
    elif min1 < min2:
        print("La prima ora vieni prima.")
    else:
        print("La seconda ora vieni prima.")
elif ora1 < ora2:
    print("La prima ora vieni prima.")
else:
    print("La seconda ora vieni prima.")