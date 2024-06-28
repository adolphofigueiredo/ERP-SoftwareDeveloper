'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 07/05/2024

Esercizio 02

Dopo aver letto e memorizzato N numeri reali in una lista, N dato in input, calcolare la
somma di quelli negativi e, successivamente, sovrascrivere il loro valore con zero.
Stampare la somma calcolata e la lista modificata.
'''

# Variabili Globali:

                                                           #

# Funzioni:

    #Funzione:
def InserisciDatoInput() -> int:                           #
    '''
Funzione: InserisciDatoInput
Funzione creata per conoscere il numero di elementi nella lista.

Parametri formali:

Valore di ritorno:
N --> Numero di elemento della lista.
    '''
    #Parametri formali:
    N = 0
    while N <= 0:
        N = int(input("Inserisci il numero di elementi della lista: "))
    #Valore di ritorno:
    return N                                               #

    #Funzione:
def InserisciLista(N):                                     #
    '''
Funzione: InserisciLista
Funzione creata per inserire gli elementi della lista.

Parametri formali:
elemento --> Variabile creata per inserire ciascun elemento nella lista.

Valore di ritorno:
Lista --> Variabile creata per memorizzare la lista. 
    '''
    #Parametri formali:
    Lista = []
    for x in range (N):
        elemento = int(input(f"Inserisci l'elemento {x+1}: "))
        Lista += [elemento]

    #Valore di ritorno:
    return Lista                                           #

    #Funzione:
def SommaNegativi(N , Lista):                              #
    '''
Funzione: SommaNegativi
Funzione creata per sommare i numeri negativi e sostituirli con zero.
Parametri formali:

Valore di ritorno:
Somma --> Funzione creata per sommare i valori negativi.
    '''
    #Parametri formali:
    Somma = 0
    for x in range (N):                                    #
        if Lista[x] < 0:
            Somma += Lista[x]
            Lista[x] = 0

    #Valore di ritorno:

    return Somma                                           #

# Inizializzazioni Variabili

                                                           #

# Sezione di Input Dati

                                                           #

# Elaborazione

N = InserisciDatoInput()                                   #
Lista = InserisciLista(N)                                  #
Somma = SommaNegativi(N , Lista)                           #

# Eventuali Sotto Processi di Elaborazione

                                                           #

# Sezione di Output

print(f"La lista modificata con {N} elementi è {Lista} e la somma dei numeri negativi è {Somma}")  #
