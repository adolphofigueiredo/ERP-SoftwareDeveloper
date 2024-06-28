'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 21/05/2024

Quarto Esercizio

Rappresentare con una struttura le informazioni di una città: nome, numero di abitanti
attuale e numero di abitanti dello scorso anno. Costruire una funzione che permetta di
calcolare l’incremento (o decremento) degli abitanti. Scrivere un programma che permetta
di testare la funzione progettata, comprensivo di inserimento dati.

'''

from dataclasses import dataclass

# Funzioni:

    #Funzione:

@dataclass
class Popolazione:
    Citta: str                   = ""
    AbitantiAttuale: int         = 0
    AbitantiAnnoScorso: int     = 0

    #Funzione:

def Inserimento():
    '''
    
    '''
    while Popolazione.Citta == "":
        Popolazione.Citta = input("\nInserisci la città: ")

    while Popolazione.AbitantiAttuale <= 0:
        Popolazione.AbitantiAttuale = int(input("\nInserisci la popolazione attuale: "))

    while Popolazione.AbitantiAnnoScorso <= 0:
        Popolazione.AbitantiAnnoScorso = int(input("\nInserisci la popolazione dell'anno scorso: "))

    return Popolazione.Citta , Popolazione.AbitantiAttuale , Popolazione.AbitantiAnnoScorso

#Elaborazione:

Popolazione.Citta , Popolazione.AbitantiAttuale , Popolazione.AbitantiAnnoScorso = Inserimento()

DeltaPopolazione = ( ( Popolazione.AbitantiAttuale / Popolazione.AbitantiAnnoScorso ) - 1 ) * 100
DeltaAbitanti = Popolazione.AbitantiAttuale - Popolazione.AbitantiAnnoScorso

#Output:

if DeltaAbitanti < 0:
    print(f"\nLa popolazione di {Popolazione.Citta} ha perso {DeltaAbitanti * -1} abitanti,{DeltaPopolazione * -1: .2f}% della popolazione precedente.\n")
elif DeltaAbitanti == 0:
    print(f"\nLa popolazione di {Popolazione.Citta} è la stessa dell'anno precedente.")
else:
    print(f"\nLa popolazione di {Popolazione.Citta} ha aumentato {DeltaAbitanti} abitanti,{DeltaPopolazione: .2f}% della popolazione precedente.\n")