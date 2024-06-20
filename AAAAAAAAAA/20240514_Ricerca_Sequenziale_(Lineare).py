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


Lista = [312,203,310,30,273,168,187,463,332,179,365,87,135,430,375,290,95,242,489,270,190,152,13,154,123,302,308,190,376,447,161,281,140,129,184,249,298,360,83,381,234,419,158,113,294,465,280,427,54,206]
Ricerca = 95

Trovato , Contatore = RicercaLineare(Lista,Ricerca)
print("Trovato: " , Trovato , "\nTest: " , Contatore)