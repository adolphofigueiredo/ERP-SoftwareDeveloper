'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 07/05/2024

Esercizio 03

Leggere una lista di interi di N posizioni, N dato in input. Leggere un ulteriore numero intero
M e dire quanti numeri memorizzati nella lista sono inferiori e quanti superiori a M.
'''

# Variabili Globali:

                                                           #

# Funzioni:

    #Funzione:
def InserisciDatoInput():                                  #
    '''
Funzione: InserisciDatoInput
Funzione creata per conoscere il numero di elementi nella lista.

Parametri formali:

Valore di ritorno:
N --> Numero di elemento della lista.
    '''
    #Parametri formali:
    N = -1                                                 #
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
N --> Numero di elemento della lista.

Valore di ritorno:
Lista --> Variabile creata per memorizzare la lista. 
    '''
    #Parametri formali:
    Lista = []
    for x in range (N):                                    #
        elemento = int(input(f"Inserisci l'elemento {x+1}: "))
        Lista += [elemento]
    
    #Valore di ritorno:
    return Lista                                           #
                                                                                                        
    #Funzione:
def InserisciNumLimite():                                  #
    '''
Funzione: InserisciNumLmite
Funzione creata per conoscere il numero limite che verrà utilizzato nel calcolo.
Parametri formali:

Valore di ritorno:
NumLimite --> Variabile creata per memorizzare il numero limite.   
    '''
    #Parametri formali:
    NumLimite = int(input("Inserisci il numero limite: ")) #
    #Valore di ritorno:
    return NumLimite                                       #
                                                                                                        
    #Funzione:
def Classificazione(N , Lista , NumLimite):                                     #
    '''
Funzione: Classificazione
Funzione creata per contare quanti numeri sono maggiori, minori e uguali al numero limite.

Parametri formali:
N --> Numero di elemento della lista.
Lista --> Variabile creata per memorizzare la lista. 
NumLimite --> Variabile creata per memorizzare il numero limite.

Valore di ritorno:
Maggiore --> Contatore creato per contare quanti numeri sono maggiori del numero limite.
Minore --> Contatore creato per contare quanti numeri sono minori del numero limite.
Uguale --> Contatore creato per contare quanti numeri sono uguali del numero limite.
    '''
    #Parametri formali:
    Maggiore = 0
    Minore = 0
    Uguale = 0
    for x in range (N):                                    #
        if Lista[x] == NumLimite:                          #        
            Uguale += 1
        elif Lista[x] < NumLimite:                         #        
            Minore += 1
        else:                                              #
            Maggiore += 1
    #Valore di ritorno:
    return Maggiore, Minore, Uguale                        #

# Inizializzazioni Variabili

                                                           #

# Sezione di Input Dati

                                                           #
 
# Elaborazione

N = InserisciDatoInput()                                   #
Lista = InserisciLista(N)                                  #
NumLimite = InserisciNumLimite()                           #
Maggiore, Minore, Uguale = Classificazione(N , Lista , NumLimite)    #

# Eventuali Sotto Processi di Elaborazione

                                                           #

# Sezione di Output

print(f"\nI numeri presenti nella lista sono classificati come segue:\n")
print(f"Maggiore di {NumLimite}: {Maggiore}")
print(f"Minore di {NumLimite}: {Minore}")
print(f"Uguale a {NumLimite}: {Uguale}\n")
print(f"Numeri totali inseriti nella lista: {N}\n")