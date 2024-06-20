'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 14/05/2024

Esercizio 03

Scrivere due funzioni che implementano la ricerca lineare e la ricerca dicotomica.
Provare le due funzioni attraverso un programma principale.

'''


# Funzioni:


    #Funzione:
def RicercaBinaria(Lista , Ricerca):
    '''
Funzione: RicercaBinaria
Si confronta la chiave "Ricerca" con l’elemento che si trova a metà lista. Se l’elemento individuato
non è uguale a quello cercato si prosegue la ricerca nella semilista inferiore o superiore a seconda
che la chiave sia più piccola o più grande dell’elemento che si trova a metà.

Parametri formali:
N --> Numero di elementi nella lista
Lista --> Lista che verrà utilizzata per effettuare la ricerca
Ricerca --> La chiave di ricerca
TentativoMAX --> Numero massimo di tentativi ancora possibili

Valore di ritorno:
Trovato --> Variabile booleana che indica se la chiave è stata trovata nella lista
Posizione --> Posizione in cui viene effettuato il test nella lista sorted.
    '''
    #Parametri formali:
    Trovato =  False
    Lista = sorted(Lista)
    Tentativo = 0
    N = len(Lista)
    Possibilita = N - 1
    Posizione = int((Tentativo + Possibilita) / 2 )
    while (Tentativo < Possibilita) and (Lista[Posizione] != Ricerca):
        if Lista[Posizione] > Ricerca:
            Possibilita = Posizione - 1
        else:
            Tentativo = Posizione + 1
        Posizione = int((Tentativo + Possibilita) / 2 )
    if Lista[Posizione] == Ricerca:
        Trovato = True
    if not Trovato:
        Posizione = "-----"
    #Valore di ritorno:
    return Trovato , Posizione




    #Funzione:
def RicercaLineare(Lista , Ricerca):
    '''
Funzione: RicercaLineare
Si ricerca la chiave "Ricerca" confrontandola con ciascun elemento della lista.
L’algoritmo termina con successo se la chiave viene trovata. Se si arriva all’ultimo
elemento senza aver trovato la chiave l’algoritmo esce senza successo.

Parametri formali:
N --> Numero di elementi nella lista
Lista --> Lista che verrà utilizzata per effettuare la ricerca
Ricerca --> La chiave di ricerca

Valore di ritorno:
Trovato --> Variabile booleana che indica se la chiave è stata trovata nella lista
Contatore --> Contatore che registra il numero di tentativi di ricerca della chiave nella lista
    '''
    #Parametri formali:
    Trovato = False
    N = len(Lista)
    Contatore = 0
    while (Contatore < N) and (Lista[Contatore] != Ricerca):
        Contatore += 1
    if Contatore < N:
        Trovato = True
    #Valore di ritorno:
    return Trovato , Contatore




# Elaborazione

Lista = [312,203,310,30,273,168,187,463,332,179,365,87,135,430,375,290,95,242,489,270,190,152,13,154,123,302,308,190,376,447,161,281,140,129,184,249,298,360,83,381,234,419,158,113,294,465,280,427,54,206]
Ricerca = 95

Trovato , Contatore = RicercaLineare(Lista,Ricerca)
print("\n----- Ricerca Lineare -----","\n\nTrovato:  " ,Trovato , "\nPosizione:" , Contatore)

Trovato , Posizione = RicercaBinaria(Lista , Ricerca)
print("\n----- Ricerca Binaria -----","\n\nTrovato:  " ,Trovato , "\nPosizione:" , Posizione,"(Lista Ordinata)")

print("\n---------------------------")

print(sorted(Lista))