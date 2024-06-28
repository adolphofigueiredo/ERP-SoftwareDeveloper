'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 28/05/2024

Primo Esercizio
Si scriva un programma Python che permetta di gestire le squadre di un campionato di calcio.
Le squadre sono definite da queste informazioni:

● nome squadra,
● codice squadra,
● goal fatti,
● goal subiti.

Costruire un programma che stampi un menu’ di scelta che presenti le seguenti opzioni:
1. Inserimento di N squadre di calcio
2. Stampa di tutte le squadre che hanno un numero di goal maggiore di quelli subiti
3. Dato un codice di una squadra stampare tutti i dati della stessa
4. Stampa di tutte le squadre in ordine alfabetico per nome
5. Esci
'''

from dataclasses import dataclass

# Definizione delle Strutture Dati

@dataclass
class Squadra:
    NomeSquadra: str
    CodiceSquadra: str
    GoalFatti: int
    GoalSubiti: int

# Funzioni:

    #Funzione:

def Menu() -> bool:

    '''
Funzione: Menu
Funzione creata per stampare il menu e ricevere l'input selezionato.

Parametri formali:

Valore di ritorno:
scelta --> Variabile creata per scegliere l'opzione del menu.
    '''
    #Parametri formali:

    scelta = input('''-------------------------------------------------------------------------------------
                                        MENU
-------------------------------------------------------------------------------------
1. Inserimento di N squadre di calcio
2. Stampa di tutte le squadre che hanno un numero di goal maggiore di quelli subiti
3. Dato un codice di una squadra stampare tutti i dati della stessa
4. Stampa di tutte le squadre in ordine alfabetico per nome
5. Esci
-------------------------------------------------------------------------------------
Selezioni una delle opzioni: ''')
    print("-------------------------------------------------------------------------------------")

    #Valore di ritorno:

    return scelta

    #Funzione:

def ConfermaUscita(Uscita:bool) -> bool:

    '''
Funzione: ConfermaUscita
Funzione creata per confermare l'uscita dal programma.

Parametri formali:

Valore di ritorno:
uscire --> Variabile che attiva la conferma di uscita dal programma.
    '''
    
    #Parametri formali:
    
    Conferma = input("Confermi l'uscita?\nS - Si\nN - No\n")
    if (Conferma == "S") or (Conferma == "s"):
        Uscita = True
    print("-------------------------------------------------------------------------------------")

    #Valore di ritorno:

    return Uscita

    #Funzione:

def InserisciSquadra(ListaSquadra:list[Squadra] , InfoSquadra:bool):
    
    '''
Funzione: InserisciSquadra
Funzione creata per inserire la squadra e le sue informazioni

Parametri formali:
NomeSquadra   --> Variabile che memorizza il nome della squadra.
CodiceSquadra --> Variabile che memorizza il codice della squadra.
GoalFatti  --> Variabile che memorizza i goal fatti dalla squadra.
GoalSubiti --> Variabile che memorizza i goal subiti dalla squadra.

Valore di ritorno:
ListaSquadra --> Lista che memorizza informazioni sulle squadre.
InfoSquadra  --> Booleano che indica se la lista è vuota.

    '''

    #Parametri formali:

    InfoSquadra = True
    NomeSquadra = ""
    CodiceSquadra = ""
    GoalFatti = -1
    GoalSubiti = -1



    while NomeSquadra == "":
        NomeSquadra = input("Inserisci il nome della squadra: ")

    while CodiceSquadra == "":
        CodiceSquadra = input("Inserisci il codice della squadra: ")

    while GoalFatti < 0:
        GoalFatti = int(input("Inserisci il numero di goals fatti: "))

    while GoalSubiti < 0:
        GoalSubiti = int(input("Inserisci il numero di goals subiti: "))

    ListaSquadra.append(Squadra(NomeSquadra , CodiceSquadra , GoalFatti , GoalSubiti))

    #Valore di ritorno:

    return ListaSquadra , InfoSquadra

    #Funzione:

def StampaGoalFattiMaggiore(ListaSquadra:list[Squadra] , InfoSquadra:bool):

    '''
Funzione: StampaGoalFattiMaggiore
Funzione creata per stampare tutte le squadre che hanno un numero maggiore di goal fatti rispetto a quelli subiti.

Parametri formali:

Valore di ritorno:
ListaSquadra --> Lista che memorizza informazioni sulle squadre.
InfoSquadra  --> Booleano che indica se la lista è vuota.

    '''

    #Parametri formali:
    
    if not InfoSquadra:
    
        print("Errore - Prima di selezionare questa opzione, inserisci almeno una squadra!")
    
    else:

        print("Codice" , "NomeSquadra    " , "  Fatti" , "Subiti")
        print("-------------------------------------------------------------------------------------")

        for Squadra in ListaSquadra:
        
            if Squadra.GoalFatti > Squadra.GoalSubiti:
        
                print(f"{Squadra.CodiceSquadra:>6} {Squadra.NomeSquadra:<15} {Squadra.GoalFatti:>7} {Squadra.GoalSubiti:>6}")
    
    #Valore di ritorno:

    return ListaSquadra , InfoSquadra

    #Funzione:

def StampaSquadra(ListaSquadra:list[Squadra] , InfoSquadra:bool):

    '''
Funzione: StampaSquadra
Funzione creata per stampare una determinata squadra secondo il suo codice.

Parametri formali:
N --> Numero di elementi nella lista
Trovato --> Variabile booleana che indica se la chiave è stata trovata nella lista
Contatore --> Contatore che registra il numero di tentativi di ricerca della chiave nella lista
Ricerca --> La chiave di ricerca

Valore di ritorno:
ListaSquadra --> Lista che memorizza informazioni sulle squadre.
InfoSquadra  --> Booleano che indica se la lista è vuota. 

    '''

    #Parametri formali:
    
    if not InfoSquadra:
    
        print("Errore - Prima di selezionare questa opzione, inserisci almeno una squadra!")
    
    else:

        Trovato = False

        Ricerca = input("Inserisci il codice che vuoi cercare: ")
        print("-------------------------------------------------------------------------------------")

        for Squadra in ListaSquadra:

            if Squadra.CodiceSquadra == Ricerca:

                Trovato = True

                print("Codice" , "NomeSquadra    " , "  Fatti" , "Subiti")
                print("-------------------------------------------------------------------------------------")
                print(f"{Squadra.CodiceSquadra:>6} {Squadra.NomeSquadra:<15} {Squadra.GoalFatti:>7} {Squadra.GoalSubiti:>6}")

                break

        if not Trovato:

            print("Codice non trovato!")                

    #Valore di ritorno:

    return ListaSquadra , InfoSquadra

    #Funzione:

def StampaSquadraOrdAlfab(ListaSquadra:list[Squadra] , InfoSquadra:bool):

    '''
Funzione: StampaSquadraOrdAlfab
Funzione creata per stampare tutte le squadre in ordine alfabetico.

Parametri formali:
N --> Numero di elementi nella lista

Valore di ritorno:
ListaSquadra --> Lista che memorizza informazioni sulle squadre.
InfoSquadra  --> Booleano che indica se la lista è vuota. 

    '''

    #Parametri formali:
    
    if not InfoSquadra:
    
        print("Errore - Prima di selezionare questa opzione, inserisci almeno una squadra!")
    
    else:
        N = len(ListaSquadra)
        for i in range ( N ):
            for j in range ( i , N ):
                if ListaSquadra[i].NomeSquadra > ListaSquadra[j].NomeSquadra:
                    ListaSquadra[i] , ListaSquadra[j] = ListaSquadra[j] , ListaSquadra [i]
    
    print("---------------------------------- O r d i n a t a ----------------------------------")
    print("Codice" , "NomeSquadra    " , "  Fatti" , "Subiti")
    print("-------------------------------------------------------------------------------------")
    
    for Squadra in ListaSquadra:
        print(f"{Squadra.CodiceSquadra:>6} {Squadra.NomeSquadra:<15} {Squadra.GoalFatti:>7} {Squadra.GoalSubiti:>6}")

    #Valore di ritorno:

    return ListaSquadra , InfoSquadra

# Inizializzazioni Variabili

ListaSquadra = list()
Uscita = False
InfoSquadra = False

# Sezione di Input Dati
 
# Elaborazione

while not Uscita:

    scelta = Menu()
    
    match scelta:

        case "1":
            
            ListaSquadra , InfoSquadra = InserisciSquadra(ListaSquadra , InfoSquadra)
            print("-------------------------------------------------------------------------------------")

        case "2":
        
            ListaSquadra , InfoSquadra = StampaGoalFattiMaggiore(ListaSquadra , InfoSquadra)
            print("-------------------------------------------------------------------------------------")
        
        case "3":
        
            ListaSquadra , InfoSquadra = StampaSquadra(ListaSquadra , InfoSquadra)
            print("-------------------------------------------------------------------------------------")
        
        case "4":
            
            ListaSquadraOrdinata , InfoSquadra = StampaSquadraOrdAlfab(ListaSquadra , InfoSquadra)
            print("-------------------------------------------------------------------------------------")
        
        case "5":
            
            Uscita = ConfermaUscita(Uscita)

# Eventuali Sotto Processi di Elaborazione

# Sezione di Output

#print("Codice" , "NomeSquadra    " , "  Fatti" , "Subiti")
#print("-------------------------------------------------------------------------------------")

#for Squadra in ListaSquadra:
#    print(f"{Squadra.CodiceSquadra:>6} {Squadra.NomeSquadra:<15} {Squadra.GoalFatti:>7} {Squadra.GoalSubiti:>6}")

#print("---------------------------------- O r d i n a t a ----------------------------------")
#print("Codice" , "NomeSquadra    " , "  Fatti" , "Subiti")
#print("-------------------------------------------------------------------------------------")

#for Squadra in ListaSquadraOrdinata:
#    print(f"{Squadra.CodiceSquadra:>6} {Squadra.NomeSquadra:<15} {Squadra.GoalFatti:>7} {Squadra.GoalSubiti:>6}")

#print("-------------------------------------------------------------------------------------")