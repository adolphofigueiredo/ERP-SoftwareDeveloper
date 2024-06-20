    #Funzione:
def Minimo(Lista):
    '''
Funzione: Massimo
Funzione creata per trovare il valore minimo nella lista

Parametri formali:
Lista --> Lista che verrà utilizzata per effettuare la ricerca
N --> Numero di elementi nella lista
Contatore --> Contatore che registra il numero di elementi testati

Valore di ritorno:
Min --> Variabile creata per memorizzare il valore minimo della lista
    '''
    #Parametri formali:
    N = len(Lista)
    Min = Lista[0]
    Contatore = 1
    while Contatore < N:
        if Lista[Contatore] < Min:
            Min = Lista[Contatore]
        Contatore += 1
    #Valore di ritorno:
    return Min


Lista = [312,203,310,30,273,168,187,463,332,179,365,87,135,430,375,290,95,242,489,270,190,152,13,154,123,302,308,190,376,447,161,281,140,129,184,249,298,360,83,381,234,419,158,113,294,465,280,427,54,206]
Min = Minimo(Lista)

print(Min)