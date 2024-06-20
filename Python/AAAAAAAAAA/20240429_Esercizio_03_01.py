'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 29/04/2024

Esercizio 03

Data una lista di N elementi inseriti in input, stampare il valore massimo e minimo.

'''

# Variabili Globali:
                                                           #
# Funzioni:

    #Funzione:
def NumeriInput():                                         #
    '''
Funzione: NumeriInput
Permette all'utente di inserire il numero di input.
Parametri formali:
Loop criato per garantire che il numero sia positivo.
Valore di ritorno:
N --> int
    '''
    #Parametri formali:
    N = -1                                                 #
    while N <= 0:                                          #
        N = int(input("Inserisci il numero di input: "))   #
    #Valore di ritorno:
    return N                                               #

    #Funzione:
def InserimentoLista(N):                                   #
    '''
Funzione: InserimentoLista
Permette all'utente di inserire gli elementi numerici in una lista.
Parametri formali:
Ciclo creato per garantire che nella lista vengano inseriti N numeri.
Valore di ritorno:
Lista
    '''
    #Parametri formali:
    Lista = []
    for x in range (N):                                    #
        ListaTemp = float(input("Inserisci l'elemento numerico: ")) #
        Lista += [ListaTemp]                               #
    #Valore di ritorno:
    return Lista                                           #

#Funzione:
def MinMax(N , Lista):                                     #
    '''
Funzione: MinMax
Funzione creata per identificare il valore minimo e massimo della lista
Parametri formali:
Condizione che assume un certo valore ogni volta che questo è maggiore o minore di un valore precedentemente assunto
Valore di ritorno:
Min , Max
    '''
    Max = Lista[0]
    Min = Lista[0]
#Parametri formali:
    for x in range (N):
        if Lista[x] > Max:
            Max = Lista[x]
        elif Lista[x] < Min:
            Min = Lista[x]

    #Valore di ritorno:
    return Min , Max                                       #
                                                                                                          
# Inizializzazioni Variabili

                                                           #

# Sezione di Input Dati

                                                           #
 
# Elaborazione

N = NumeriInput()                                          #
Lista = InserimentoLista(N)
Min , Max = MinMax(N,Lista)

# Eventuali Sotto Processi di Elaborazione

                                                           #

# Sezione di Output

print(f"\nIl valore minimo è {Min} e il valore massimo è {Max}.\n")  #
