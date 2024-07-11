'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 15/03/2024

Macro-Flow

'''

# Sezione di input Dati



# Inizializzazioni variabili
    
esci = False

# Elaborazione

while esci == False:
    scelta = input("Selezioni una delle opzioni:\n1 - XXXXXXXXX\n2 - XXXXXXXXXX\n3 - Esci\n")
    match scelta:
        case "1":
            print("Scelta 1")
        case "2":
            print("Scelta 2")
        case "3":
            print("Scelta 3")
            conferma = input("Confermi l'uscita?\nS - Si\nN - no\n")
            if conferma == "s" or conferma == "S":
                esci = True
        case _:
            print("\nErrore\n")

# Eventuali sotto processi di Elaborazione



# Sezione di output


