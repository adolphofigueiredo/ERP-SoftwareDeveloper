'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 29/04/2024

Esercizio 02

Data una lista di N elementi inseriti in input, stampare la media di tutti gli elementi
maggiori di un valore dato in input.

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
def ValoreMinimo():                                        #
    '''
Funzione: ValoreMinimo
Permette all'utente di inserire il valore minimo che ogni elemento della lista deve avere per essere considerato nela media.
Parametri formali:
Chiede di inserire il valore minimo
Valore di ritorno:
ValoreMin
    '''
#Parametri formali:
    ValoreMin = int(input("Inserisci il valore minimo che ogni elemento della lista deve avere per essere considerato nella media: "))#
    #Valore di ritorno:
    return ValoreMin                                       #

#Funzione:
def CalcoloMedia(N , Lista , ValoreMin):                   #
    '''
Funzione: CalcoloMedia
Calcola il valore medio in base ai parametri inseriti.
Parametri formali:
Elaborare i dati
Valore di ritorno:
ValoreMin
    '''
    Somma = 0
    NumElementi = 0

#Parametri formali:
    for x in range(N):
        if Lista[x] >= ValoreMin:
            Somma += Lista[x]
            NumElementi += 1
    if NumElementi == 0:
        Media = 0
    else:
        Media = Somma / NumElementi
    return Media         

# Inizializzazioni Variabili
                                                           #
# Sezione di Input Dati
                                                           #
# Elaborazione

N = NumeriInput()
Lista = InserimentoLista(N)
ValoreMin = ValoreMinimo()
Media = CalcoloMedia(N , Lista , ValoreMin)
                                                           #
# Eventuali Sotto Processi di Elaborazione
                                                           #
# Sezione di Output
if Media == 0:
    print("\nNon ci sono elementi per calcolare la media.\n")
else:
    print(f"\nLa media è: {Media}\n")                      #