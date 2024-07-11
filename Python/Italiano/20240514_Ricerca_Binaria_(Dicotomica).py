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


Lista = [312,203,310,30,273,168,187,463,332,179,365,87,135,430,375,290,95,242,489,270,190,152,13,154,123,302,308,190,376,447,161,281,140,129,184,249,298,360,83,381,234,419,158,113,294,465,280,427,54,206]
Ricerca = 10


Trovato , Posizione = RicercaBinaria(Lista , Ricerca)
print("Trovato:  " , Trovato , "\nPosizione:" , Posizione)