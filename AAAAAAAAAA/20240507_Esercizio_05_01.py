'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 07/05/2024

Esercizio 05
Leggere una lista di N posizioni, N dato in input. Dire se ogni valore memorizzato nella
lista è minore del quadrato del numero nella posizione precedente.
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
def MinoreQuadratoPrecedente(N, Lista):                    #
    '''
Funzione: MinoreQuadratoPrecedente
Funzione che controlla se ogni valore memorizzato nella
lista è minore del quadrato del numero nella posizione
precedente.

Parametri formali:
N --> Numero di elemento della lista.
Lista --> Variabile creata per memorizzare la lista.

Valore di ritorno:
VolteQuaPrec --> Variabile creata per contare quante volte
la condizione viene soddisfatta.
    '''
    #Parametri formali:
    VolteQuaPrec = 0
    for x in range (N):                                    #
        if x == 0:
            print(f"Elemento {x+1}: Il primo elemento non può essere testato.")
        elif Lista[x] < (Lista[x-1] * Lista[x-1]):
            print(f"Elemento {x+1}: {Lista[x]} è minore del {Lista[x-1]} x {Lista[x-1]} = {Lista[x-1] * Lista[x-1]}.")
            VolteQuaPrec += 1
        else:
            print(f"Elemento {x+1}: {Lista[x]} non è minore del {Lista[x-1]} x {Lista[x-1]} = {Lista[x-1] * Lista[x-1]}.")
    #Valore di ritorno:
    return VolteQuaPrec                                    #

# Inizializzazioni Variabili

                                                           #

# Sezione di Input Dati

                                                           #
 
# Elaborazione

N = InserisciDatoInput()                                   #
Lista = InserisciLista(N)
print("\n",Lista,"\n")
VolteQuaPrec = MinoreQuadratoPrecedente(N , Lista)

# Eventuali Sotto Processi di Elaborazione

                                                           #

# Sezione di Output

print(f"\nLa condizione avrebbe potuto essere soddisfatta {N-1} ​​volte ed è stata soddisfatta {VolteQuaPrec} volte.\n") #