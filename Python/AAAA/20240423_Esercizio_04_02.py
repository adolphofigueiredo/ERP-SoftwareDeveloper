'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 23/04/2024

Esercizio 4 
Leggi una frase e stampala in ordine inverso.
Esempio:
input: CIAO COME STAI? output: ?IAST EMOC OAIC
'''

##
## Funzioni:
##

def inserisciStringa(prompt: str) -> str:

    """
Funzione: inserisciStringa
Permette all'utente di inserire una stringa
dallo standard input
Parametri formali:
str -> prompt che viene visualizzato
Valore di ritorno:
str stringa -> stringa inserita dall'utente
    """

# inizializzazione stringa fuori dominio

    stringa = ""

# loop di inserimento e controllo stringa
    while stringa == "":
        stringa = input(prompt)
    return stringa

def invertiStringa(stringa: str) -> str:

    """
Funzione: invertiStringa
Restituisce la stringa passata come parametro formale invertita (primo carattere in ultima posizione e così via)
Parametri formali:
str stringa -> stringa che si vuole invertire
Valore di ritorno:
str strOutput -> stringa invertita
    """

# inizializzazione valore di ritorno

    strOutput = ""

# loop principale di inversione

    for pos in range(len(stringa)-1,-1,-1):
        strOutput +=stringa[pos]
    return strOutput
# Funzione molto più compatta

    """
def invertiStringa1(stringa: str) -> str:
return stringa[::-1]
    """

"""
Programma principale
Il programma permette all'utente di inserire
una stringa che poi stampa a partire dall'ultimo carattere
per arrivare al primo.
"""

# Sezione di input Dati

stringa = inserisciStringa("Inserisci la stringa: ")

# Elaborazione e output

print(invertiStringa(stringa))