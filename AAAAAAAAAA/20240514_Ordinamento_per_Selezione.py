    #Funzione:
def OrdinamentoSelezione(Lista):
    '''
Funzione: OrdinamentoSelezione
La funzione cerca l’elemento più piccolo e lo si sposta nella prima posizione. Poi, tra gli elementi
rimanenti, si cerca nuovamente il più piccolo e lo si sposta in seconda posizione e così via sino ad
arrivare all’ultimo che sarà il più grande di tutti.

Parametri formali:
N --> Numero di elementi nella lista

Valore di ritorno:
Lista --> Lista che verrà utilizzata per effettuare la ricerca
    '''
    #Parametri formali:
    N = len(Lista)
    for i in range ( N ):
        for j in range ( i , N ):
            if Lista[i] > Lista[j]:
                Lista[i] , Lista[j] = Lista[j] , Lista[i]
    #Valore di ritorno:
    return Lista

Lista = [312,203,310,30,273,168,187,463,332,179,365,87,135,430,375,290,95,242,489,270,190,152,13,154,123,302,308,190,376,447,161,281,140,129,184,249,298,360,83,381,234,419,158,113,294,465,280,427,54,206]

ListaOrdinata = OrdinamentoSelezione(Lista)

print(ListaOrdinata)