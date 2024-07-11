'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 04/06/2024

Secondo Esercizio

Un mobilificio deve gestire la vendita di tavoli prodotti dai diversi mastri artigiani loro fornitori.
Ogni tavolo è di una tipologia, ha un numero massimo di persone che possono stare sedute intorno, ha
delle dimensioni (altezza da terra, lunghezza e larghezza del piano) in metri. Si vuole creare un
programma che permetta di memorizzare tutte le diverse tipologie di tavolo che il mobilificio vende,
tale applicativo deve permettere la stampa dei tavoli a seconda del mastro artigiano inserito nella
query di ricerca, ordinata per la superficie media a persona che il tavolo può offrire.

'''
from dataclasses import dataclass

# Definizione delle Strutture Dati

@dataclass
class Tavolo:
    Artigiano: str
    NumeroPersone: int
    AltezzaInMetri: float
    LunghezzaInMetri: float
    LarghezzaInMetri: float

# Funzioni:

#Funzione:
def InserimentoTavolo(Tavoli:list) -> list:
    '''
Funzione: InserimentoTavolo
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Parametri formali:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Valore di ritorno:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

#Parametri formali:
    
    Inserimento = True

    while Inserimento:

        Artigiano = ""
        while not Artigiano:
            Artigiano = input("Inserisci il mastro artigiano: ")
    
        NumeroPersone = 0
        while NumeroPersone <= 0:
            NumeroPersone = int(input("Inserisi il numero massimo de persone ch possono stare sedute introno: "))
    
        AltezzaInMetri = 0
        while AltezzaInMetri <= 0:
            AltezzaInMetri = float(input("Inserisci la altezza in metri: "))
    
        LunghezzaInMetri = 0
        while LunghezzaInMetri<= 0:
            LunghezzaInMetri = float(input("Inserisci la lunghezza in metri: "))
    
        LarghezzaInMetri = 0
        while LarghezzaInMetri<= 0:
            LarghezzaInMetri = float(input("Inserisci la larghezza in metri: "))

        Tavoli.append(Tavolo( Artigiano , NumeroPersone , AltezzaInMetri , LunghezzaInMetri , LarghezzaInMetri ))

        Conferma = input("Vuoi inserire un nuovo tavolo?\n\nS - Si\nN - No\n")
        if Conferma == "N" or Conferma == "n":
            Inserimento = False

#Valore di ritorno:

    return Tavoli


#Funzione:
def SuperficieMedia(Lunghezza:float , Larghezza: float , NumeroPersone:int) -> float:
    '''
Funzione: xxxxxxx
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Parametri formali:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Valore di ritorno:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

#Parametri formali:

    SuperficieMedia = ( ( Lunghezza * Larghezza ) / NumeroPersone )

#Valore di ritorno:

    return SuperficieMedia


#Funzione:
def OrdineSuperficieMedia(Tavoli:list) -> list:
    '''
Funzione: xxxxxxx
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Parametri formali:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Valore di ritorno:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

#Parametri formali:

    for i in range ( len(Tavoli) ):
        for j in range ( i , len(Tavoli)):
            if SuperficieMedia(Tavoli[i].LunghezzaInMetri , Tavoli[i].LarghezzaInMetri , Tavoli[i].NumeroPersone ) > SuperficieMedia(Tavoli[j].LunghezzaInMetri , Tavoli[j].LarghezzaInMetri , Tavoli[j].NumeroPersone ):
                Tavoli[i] , Tavoli[j] = Tavoli[j] , Tavoli[i]

#Valore di ritorno:

    return Tavoli

#Funzione:
def OrdineMastro(Tavoli:list) -> list:
    '''
Funzione: xxxxxxx
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Parametri formali:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Valore di ritorno:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

#Parametri formali:

    for i in range ( len(Tavoli) ):
        for j in range ( i , len(Tavoli)):
            if Tavoli[i].Artigiano > Tavoli[j].Artigiano:
                Tavoli[i] , Tavoli[j] = Tavoli[j] , Tavoli[i]

#Valore di ritorno:

    return Tavoli


# Inizializzazioni Variabili

Tavoli = []

# Sezione di Input Dati

Tavoli = InserimentoTavolo(Tavoli)

# Elaborazione

Tavoli = OrdineSuperficieMedia(Tavoli)
Tavoli = OrdineMastro(Tavoli)

# Eventuali Sotto Processi di Elaborazione

# Sezione di Output

print( "     Artigiano      " , " Persone " , " Altezza " , " Lunghezza " , " Larghezza " , " Superficie / Persona " )

for Tavolo in Tavoli:
    
    print(f"{Tavolo.Artigiano:<20} {Tavolo.NumeroPersone:<9} {Tavolo.AltezzaInMetri:<9} {Tavolo.LunghezzaInMetri:<11} {Tavolo.LarghezzaInMetri:<11} {SuperficieMedia(Tavolo.LunghezzaInMetri , Tavolo.LarghezzaInMetri , Tavolo.NumeroPersone ):<22}")