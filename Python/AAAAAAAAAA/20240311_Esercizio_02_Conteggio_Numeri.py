'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 11/03/2024

Esercizio: Conteggio numeri
Dati N numeri contare quanti sono positivi, negativi e uguali a zero.

'''
# Sezione di input Dati

# Inizializzazioni variabili

scelta = "s"
contatore = 0
neutro = 0
maggiore = 0
minore = 0

# Elaborazione

while scelta == "s" or scelta == "S":
    contatore += 1
    num = int(input("\nInserisci il numero {}: ".format(contatore)))
    if num == 0:
        neutro += 1
    elif num > 0:
        maggiore += 1
    elif num < 0:
        minore += 1
    scelta = input("\nVuoi inserire un altro numero? \nS - Si \nN - No\n")

# Eventuali sotto processi di Elaborazione

# Sezione di output

print("\nHai inserito:\n{} numeri positivi\n{} numeri negativi\n{} volte lo 0.\n".format(maggiore,minore,neutro))
