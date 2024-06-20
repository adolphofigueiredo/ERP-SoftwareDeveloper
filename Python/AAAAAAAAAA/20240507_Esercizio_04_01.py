'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 07/05/2024

Esercizio 04

Leggere una lista di interi di N posizioni, N dato in input. Dire se i valori memorizzati nella
lista sono in ordine crescente oppure no.
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
def IsCrescente(N , Lista):                                         #
    '''
Funzione: IsCrescente
Funzione creata per verificare se la lista è stata creata in ordine crescente.

Parametri formali:
N --> Numero di elemento della lista.
Lista --> Variabile creata per memorizzare la lista. 

Valore di ritorno:
Crescente --> Variabile booleana che informa se la lista è in ordine crescente.
    '''
    Crescente = True
    #Parametri formali:
    for x in range (N-1):                                  #
        if Lista[x] > Lista[x+1]:
            Crescente = False
            break
    #Valore di ritorno:
    return Crescente                                       #

# Inizializzazioni Variabili

                                                           #

# Sezione di Input Dati

                                                           #
 
# Elaborazione

N = InserisciDatoInput()                                   #
Lista = InserisciLista(N)
Crescente = IsCrescente(N , Lista)

# Eventuali Sotto Processi di Elaborazione

                                                           #

# Sezione di Output

print("\n",Lista,"\n")                                          #
if Crescente == True:
    print("La lista è in ordine crescente.\n")
else:
    print("La lista non è in ordine crescente.\n")
