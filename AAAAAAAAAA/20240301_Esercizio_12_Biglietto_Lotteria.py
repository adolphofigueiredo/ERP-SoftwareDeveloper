'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio : Biglietto lotteria

Realizzare un programma che legga in input la posizione del biglietto vincente ed indichi in
output il valore della vincita.

➔ premio posizione numero 1 = 5000000€
➔ premio posizione numero 2 = 2000000€
➔ premio posizione numero 3 = 1000000€
➔ premio posizione numero 4 = 500000€
➔ premio posizione numero 5 = 200000€
➔ per tutte le altre posizioni non si vince nulla

'''

posizione = int(input("Inserisci la posizione del biglietto vincente: "))

match posizione:
    case 1:
        print("Il premio per la prima posizione è 5.000.000€.")
    case 2:
        print("Il premio per la seconda posizione è 2.000.000€.")
    case 3:
        print("Il premio per la terza posizione è 1.000.000€.")
    case 4:
        print("Il premio per la quarta posizione è 500.000€.")
    case 5:
        print("Il premio per la quinta posizione è 200.000€.")
    case _:
        print("Non è previsto alcun premio per questa posizione.")
