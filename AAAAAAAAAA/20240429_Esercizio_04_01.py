'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 29/04/2024

Esercizio 04

Date due liste LISTA1 e LISTA2 di rispettivamente N e M numeri float inseriti in input,
creare una terza lista i cui elementi siano la somma dei rispettivi elementi di LISTA1 e
LISTA2.
Fare attenzione al fatto che, generalmente, M != N , in questo caso si prenda come
dimensione della lista somma il valore minore.

Esempio:

N=4 LISTA1=[-3.4,10.0,-5.0,1.0]
M=6 LISTA2=[0.0, 1.0,3.0,0.5,0.6,4.0]
Output LISTASOMMA = [-3.4, 11.0, -2.0,1.5]

'''

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
def SommaLista(N , M , Lista1 ,Lista2):                    #
    '''
Funzione: SommaLista
Funzione creata per sommare gli elementi delle liste in base alla lista che ha il minor numero di valori.
Parametri formali:
Per prima cosa identifico quale lista ha meno valori, poi sommo i valori delle liste e, infine, creo una terza lista con i risultati.
Valore di ritorno:
ListaSomma
    '''
    #Parametri formali:
    ListaSomma = []
    if N == M or N < M:
        cicli = N
    else:
        cicli = M
    for x in range (cicli):
        ListaSomma += [(Lista1[x] + Lista2[x])]
    #Valore di ritorno:
    return ListaSomma                                      #

# Inizializzazioni Variabili
                                                           #
# Sezione di Input Dati
                                                           #
# Elaborazione

N = NumeriInput()                                          #
M = NumeriInput()
Lista1 = InserimentoLista(N)
Lista2 = InserimentoLista(M)
ListaSomma = SommaLista(N , M , Lista1 ,Lista2)

# Eventuali Sotto Processi di Elaborazione

                                                           #

# Sezione di Output

print("\nLista 01:   ",Lista1,"\nLista 02:   ",Lista2,"\nLista Somma:",ListaSomma,"\n")  #