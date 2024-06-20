'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 15/04/2024

Secondo Esercizio
Creare una funzione che accetti tre parametri formali: GG -> giorno del mese, MM: mese
dell’anno e AAAA: anno, tale funzione deve restituire se i parametri inseriti possano
rappresentare una data possibile (vera). Utilizzare i parametri denominati.
Provare la funzione facendo inserire all’utente almeno due date. L’inserimento deve essere
effettuato implementando una funzione.

Esempio:

INPUT: data 12 01 1450 OUTPUT: VERA
INPUT: data 30 02 2024 OUTPUT: FALSA
'''

def InserisciData():
    AAAA = int(input("Inserisci l'anno: "   ))
    MM   = int(input("Inserisci il mese: "  ))
    GG   = int(input("Inserisci il giorno: "))
    return GG,MM,AAAA

def isVera(GG:int,MM:int,AAAA:int):
    ''''
    Funzione: isVera
    Permette all'utente si inserire una data dallo standard input secondo il formato:
    GG MM AAAA

    Parametri formali:
    GG   -> int - Giorno del mese
    MM   -> int - Mese dell'ano
    AAAA -> int - Anno
    '''
    if MM <= 12 and GG <= 31 and AAAA >= 0:                                             #Condizione creata per vedere se c'è un errore di battitura nella data o se è una data assurda.
        if MM == 1 or MM == 3 or MM == 5 or MM == 7 or MM == 8 or MM == 10 or MM == 12: #Condizione creata per comprendere il mese della data
               controllo = True                            #In base alle condizioni si può dire che la data è vera.
        elif MM == 4 or MM == 6 or MM == 9 or MM == 11:    #Condizione creata per comprendere il mese della data                 
            if GG <= 30:                                   #Conoscere il mese rende chiaro quanti giorni possono esserci.
                controllo = True                           #In base alle condizioni si può dire che la data è vera.
            else:
                controllo = False                          #In base alle condizioni si può dire che la data è falsa.
        elif AAAA // 4 == AAAA / 4:                        #Condizione creata per sapere se l'anno è bisestile
            if GG <= 29:                                   #Numero di giorni applicati agli anni bisestili nel mese di febbraio
                controllo = True                           #In base alle condizioni si può dire che la data è vera.
            else:
                controllo = False                          #In base alle condizioni si può dire che la data è falsa.
        elif GG <= 28:                                     #Numero di giorni del mese di febbraio                              
            controllo = True                               #In base alle condizioni si può dire che la data è vera.
        else:
            controllo = False                              #In base alle condizioni si può dire che la data è falsa.
    else:
          controllo = False                                #In base alle condizioni si può dire che la data è falsa.
    return controllo

print("---- ---- ---- Inserisci la prima data ---- ---- ----")
GG1 , MM1 , AAAA1 = InserisciData()
print("---- ---- ---- Inserisci la seconda ---- ---- ----")
GG2 , MM2 , AAAA2 = InserisciData()

print("-------------------------")
print(GG1,"/",MM1,"/",AAAA1," - ",isVera(GG1 , MM1 , AAAA1))
print(GG2,"/",MM2,"/",AAAA2," - ",isVera(GG2 , MM2 , AAAA2))
print("-------------------------")