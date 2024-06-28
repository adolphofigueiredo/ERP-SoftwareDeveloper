    #Funzione:
def IsNumero(Num):
    '''
Funzione: IsNumero
Funzione che permette al programma di capire se l'informazione inserita è numerica.
Parametri formali:
Num --> Variabile che verrà testata
Controllo --> Variabile che informa se il numero testato è un numero o no.
Valore di ritorno:
Controllo --> bool
    '''
    #Parametri formali:
    Controllo = True
    Filtro="-.0123456789"         #Variabile che contiene i caratteri che mantengono il controllo come vero.
    for x in Num:                 #Ciclo creato per testare ogni cifra della variabile Num.
        if x not in Filtro:       #Condizione creata per dare istruzioni da eseguire dopo aver trovato una cifra non accettabile.
            Controllo = False     #La variabile diventa falsa perché è stato trovato un carattere non consentito.
            break                 #Dopo che il ciclo incontra un carattere non consentito, il ciclo termina.
    #Valore di ritorno:
    return Controllo


'''
--------------------------------------------------------------------------------------------------------
'''

Controllo = False

while Controllo == False:
    test = input("Inserisci il numero: ")
    Controllo = IsNumero(test)

test = float(test)

print(test *  4)
