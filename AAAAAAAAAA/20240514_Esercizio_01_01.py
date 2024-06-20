'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 14/05/2024

Esercizio 01

Si scriva un programma che permetta di far inserire due liste all’utente (elementi interi) e di
fare delle operazioni aritmetiche con queste. Le operazioni sono scelte dall’utente
mediante il seguente menù di scelta:
1. Inserisci N (numero di elementi della prima lista)
2. Inserisci M (numero di elementi della seconda lista)
3. Inserisci gli N elementi della prima lista
4. Inserisci gli M elementi della seconda lista
5. Stampa la prima lista
6. Stampa la seconda lista
7. Stampa la somma degli elementi della prima lista con i rispettivi elementi della
seconda lista
8. Inserire il numero K, quindi ricercare quante volte K e presente nella prima lista e
indicare le posizioni.
9. Uscita (con conferma)
Segnalare con una stampa di errore se l’utente fa delle operazioni che richiedono degli
input che non sono stati inseriti.

'''




# Funzioni:

    #Funzione:
def SceltaMenu():
    '''
Funzione: StampaMenu
Definizione creata per stampare il menu e ricevere l'input selezionato.

Parametri formali:

Valore di ritorno:
scelta --> Variabile creata per scegliere l'opzione del menu.
    '''
    #Parametri formali:
    scelta = input('''-----------------------------------------------------------------------------------------------------------------------
                                                    MENU
-----------------------------------------------------------------------------------------------------------------------
1. Inserisci N (numero di elementi della prima lista)
2. Inserisci M (numero di elementi della seconda lista)
3. Inserisci gli N elementi della prima lista.
4. Inserisci gli M elementi della seconda lista.
5. Stampa la prima lista.
6. Stampa la seconda lista.
7. Stampa la somma degli elementi della prima lista con i rispettivi elementi della seconda lista.
8. Inserire il numero K, quindi ricercare quante volte K e presente nella prima lista e indicare le posizioni.
9. Uscita (con conferma)
-----------------------------------------------------------------------------------------------------------------------
Selezioni una delle opzioni: ''')
    print("-----------------------------------------------------------------------------------------------------------------------")
    #Valore di ritorno:
    return scelta




    #Funzione:
def ConfermaUscita(uscire):
    '''
Funzione: ConfermaUscita
Funzione creata per confermare l'uscita dal programma.

Parametri formali:
conferma --> Ingresso richiesto per confermare l'uscita dal programma.

Valore di ritorno:
uscire --> Variabile che attiva la conferma di uscita dal programma.
    '''
    #Parametri formali:
    
    conferma=input("Confermi l'uscita?\nS - Si\nN - No\n")
    if (conferma == "S") or (conferma == "s"):
        uscire = True

    #Valore di ritorno:
    return uscire




    #Funzione:
def IsNumeroPositivo(Num):
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
    Filtro="0123456789"           #Variabile che contiene i caratteri che mantengono il controllo come vero.
    for x in Num:                 #Ciclo creato per testare ogni cifra della variabile Num.
        if x not in Filtro:       #Condizione creata per dare istruzioni da eseguire dopo aver trovato una cifra non accettabile.
            Controllo = False     #La variabile diventa falsa perché è stato trovato un carattere non consentito.
            break                 #Dopo che il ciclo incontra un carattere non consentito, il ciclo termina.
    #Valore di ritorno:
    return Controllo




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




    #Funzione:
def NumeroElementi():
    '''
Funzione: NumeroElementi
Funzione creata per conoscere il numero di elementi nella lista.

Parametri formali:

Valore di ritorno:
Num --> Numero di elemento della lista.
    '''
    #Parametri formali:
    ControlloNumPositivo = False

    while not ControlloNumPositivo:
        Num = input("Inserisci il numero di elementi della lista: ")
        ControlloNumPositivo = IsNumeroPositivo(Num)
    Num = int(Num)

    #Valore di ritorno:
    return Num




    #Funzione:
def InserisciLista(QTA):
    '''
Funzione: InserisciLista
Funzione creata per inserire gli elementi della lista.

Parametri formali:
elemento --> Variabile creata per inserire ciascun elemento nella lista.

Valore di ritorno:
Lista --> Variabile creata per memorizzare la lista. 
    '''
    #Parametri formali:
    Lista = []
    for x in range (QTA):
        ControlloNumero = False
        while not ControlloNumero:
            elemento = input(f"Inserisci l'elemento {x+1}: ")
            ControlloNumero = IsNumero(elemento)
        elemento = float(elemento)
        Lista += [elemento]

    #Valore di ritorno:
    return Lista




    #Funzione:
def SommaLista(N , M , Lista01 ,Lista02):
    '''
Funzione: SommaLista
Funzione creata per sommare gli elementi delle liste in base alla lista che ha il minor numero di valori.

Parametri formali:
N --> Numero di elemento della lista 01.
M --> Numero di elemento della lista 02.
Lista 01 --> Lista con N elementi.
Lista 02 --> Lista con M elementi.
cicli --> Numero di elemento della lista minore.

Valore di ritorno:
ListaSomma --> Lista con la somma delle due liste.
    '''
    #Parametri formali:
    ListaSomma = []
    if N == M or N < M:
        cicli = N
    else:
        cicli = M
    for x in range (cicli):
        ListaSomma += [(Lista01[x] + Lista02[x])]
    #Valore di ritorno:
    return ListaSomma




    #Funzione:
def RicercaPosizione( N:int , Lista01):
    '''
Funzione: RicercaPosizione
Funzione creata per cercare un valore, contando quante volte è stato trovato e dove.

Parametri formali:
N --> Numero di elemento della lista 01.
K --> Valore che deve essere cercato.

Valore di ritorno:
RicercaVolte --> Contatore creato per contare quante volte è stato trovato il valore cercato
Posizioni --> Lista creata per dire in quali posizioni è stato trovato il valore cercato
    '''
    #Parametri formali:
    Posizioni = []
    RicercaVolte = 0
    ControlloNumero = False

    while not ControlloNumero:
        K = input("Inserisci il valore che deve essere cercato: ")
        ControlloNumero = IsNumero(K)
    K = float(K)

    for x in range (N):
        if Lista01[x] == K:
            RicercaVolte += 1
            Posizioni += [x]
    #Valore di ritorno:
    return RicercaVolte , Posizioni , K




# Inizializzazioni Variabili


uscire = False
NInserito = False
MInserito = False
Lista01Inserita = False
Lista02Inserita = False

 
# Elaborazione


while not uscire:
    scelta = SceltaMenu()
    match scelta:
        case "1":
            N = NumeroElementi()
            NInserito = True
            Lista01Inserita = False
        case "2":
            M = NumeroElementi()
            MInserito = True
            Lista02Inserita = False
        case "3":
            if not NInserito:
                print("\n*****   Errore - È necessario inserire N prima.   *****")
            else:
                Lista01 = InserisciLista(N)
                Lista01Inserita = True
        case "4":
            if not MInserito:
                print("\n*****   Errore - È necessario inserire M prima.   *****")
            else:
                Lista02 = InserisciLista(M)
                Lista02Inserita = True
        case "5":
            if not NInserito:
                print("\n*****   Errore - È necessario inserire N prima.   *****")
            if not Lista01Inserita:
                print("\n*****   Errore - È necessario inserire la lista 01 prima.   *****")
            if NInserito and Lista01Inserita:
                print(Lista01)
        case "6":
            if not MInserito:
                print("\n*****   Errore - È necessario inserire M prima.   *****")
            if not Lista02Inserita:
                print("\n*****   Errore - È necessario inserire la lista 02 prima.   *****")
            if MInserito and Lista02Inserita:
                print(Lista02)
        case "7":
            if not NInserito:
                print("\n*****   Errore - È necessario inserire N prima.   *****")
            if not Lista01Inserita:
                print("\n*****   Errore - È necessario inserire la lista 01 prima.   *****")
            if not MInserito:
                print("\n*****   Errore - È necessario inserire M prima.   *****")
            if not Lista02Inserita:
                print("\n*****   Errore - È necessario inserire la lista 02 prima.   *****")
            if NInserito and MInserito and Lista01 and Lista02:
                ListaSomma = SommaLista( N , M , Lista01 , Lista02 )
                print("Lista 01: ",Lista01)                
                print("Lista 02: ",Lista02)
                print("Somma:    ",ListaSomma)
        case "8":
            if not NInserito:
                print("\n*****   Errore - È necessario inserire N prima.   *****")
            if not Lista01Inserita:
                print("\n*****   Errore - È necessario inserire la lista 01 prima.   *****")
            if NInserito and Lista01Inserita:
                RicercaVolte , Posizioni , K = RicercaPosizione( N , Lista01)
                if RicercaVolte == 0:
                    print(f"\nIl numero {K} non è stato trovato.")
                elif RicercaVolte == 1:
                    print(f"\nIl numero {K} é stato trovato {RicercaVolte} volta nella posizione {Posizioni}.")
                else:
                    print(f"\nIl numero {K} é stato trovato {RicercaVolte} volte nelle posizioni {Posizioni}.")
        case "9":
            uscire = ConfermaUscita(uscire)
        case _:
            print("\n*****   Errore - È necessario selezionare una delle opzioni valide.   *****")