'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 04/06/2024

Primo Esercizio

Una rivendita di libri usati descrive i propri prodotti secondo le seguenti caratteristiche:

● codice numerico (numero intero)
● numero di pagine
● costo

Per questioni commerciali si ha la necessità di raccogliere in un’archivio tutti i libri in
vendita e si vuole la stampa di questi secondo l’ordine crescente di costo per pagina.

'''
from dataclasses import dataclass

# Definizione delle Strutture Dati

@dataclass
class Libro:
    Codice: int
    Pagine: int
    Costo: float


# Funzioni:

#Funzione:
def InserimentoLibro(Libreria:list) -> list:
    '''
Funzione: InserimentoLibri
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Parametri formali:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Valore di ritorno:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

#Parametri formali:
    
    Inserimento = True

    while Inserimento == True:
        
        Codice = -1
        while Codice < 0:
            Codice = int(input("\nInserisci il codice: "))
    
        Pagine = 0
        while Pagine <= 0:
            Pagine = int(input("Inserisci il numero di pagine: "))

        Costo = 0
        while Costo <= 0:
            Costo = float(input("Inserisi il costo del libro: "))
    
        Libreria.append( Libro( Codice , Pagine , Costo ) )

        Conferma = input("\nVuoi inserire un nuovo libro?\n\nS - Si\nN - No\n")
        if (Conferma == "N") or (Conferma == "n"):
            Inserimento = False
    
#Valore di ritorno:

    return Libreria


#Funzione:
def OrdineCostoPagina(Libreria:list) -> list:
    '''
Funzione: OrdineCostoPagina
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Parametri formali:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Valore di ritorno:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

#Parametri formali:

    for i in range ( len(Libreria) ):
        for j in range ( i , len(Libreria) ):
            if ( Libreria[i].Costo / Libreria[i].Pagine ) > ( Libreria[j].Costo / Libreria[j].Pagine ) :
                Libreria[i] , Libreria[j] = Libreria[j] , Libreria[i]

#Valore di ritorno:

    return Libreria

# Inizializzazioni Variabili

Libreria = []

# Sezione di Input Dati
# Elaborazione

Libreria = InserimentoLibro(Libreria)

Libreria = OrdineCostoPagina(Libreria)


print( "   Codice   " , "   Pagine   " , "   Costo    " , " Costo / Pagine " )
for Libro in Libreria:
    print(f"{Libro.Codice:<12} {Libro.Pagine:<12} {Libro.Costo:<12} {(Libro.Costo / Libro.Pagine):<16}" )

# Eventuali Sotto Processi di Elaborazione
# Sezione di Output
