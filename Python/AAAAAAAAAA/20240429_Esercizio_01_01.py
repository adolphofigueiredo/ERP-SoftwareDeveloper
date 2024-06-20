'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 29/04/2024

Esercizio 01

Dato N in input, inserire N elementi numerici in una lista. Successivamente stampare tale
lista.

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

# Inizializzazioni Variabili
                                                           #
# Sezione di Input Dati
                                                           #
# Elaborazione

N = NumeriInput()                                          #
Lista = InserimentoLista(N)                                #
# Eventuali Sotto Processi di Elaborazione
                                                           #
# Sezione di Output
print("\n",Lista,"\n")                                     #