'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 14/06/2024

Una biblioteca ha identificato tutti i libri della propria collezione mediante un codice numerico.
Le informazioni peculiari del libro sono le seguenti: il codice numerico, il titolo, l’autore,
l’anno di pubblicazione, la casa editrice, nome utente che usufruisce del prestito, numero di
giorni che mancano allo scadere del prestito.

Costruire un programma che stampi un menu’ di scelta che presenti le seguenti opzioni:

1 - Inserimento di N libri nella biblioteca
2 - Stampa del numero totale di libri presenti
3 - Stampa di tutti i libri presenti
4 - Stampa di tutti i libri ordinati per autore
5 - Stampa dei libri che non sono in prestito ordinati per codice
6 - Stampa di tutti i libri in scadenza (a meno di 2 giorni dalla data di scadenza)
7 - Esci
'''


from dataclasses import dataclass #righa scrita per importare la libreria dataclasses e usar datclass che mi consente di combinare un novo tipo di strutura di dati.


# Definizione delle Strutture Dati


@dataclass                                       #Classe creata per memorizzare tutte le informazioni necessarie.
class Collezione:                                #Determinazione del nome della classe
    CodiceNumerico: int
    Titolo: str
    Autore: str
    Pubblicazione: int
    CasaEditrice: str
    UtentePrestito: str
    GiorniScadenza: int


# Funzioni:


    #Funzione:
def SceltaMenu():
    '''
Funzione: SceltaMenu
Funzione creata per stampare il menu e ricevere l'input selezionato.

Valore di ritorno:
Scelta --> Variabile creata per scegliere l'opzione del menu.
    '''
    #Parametri formali:                          #Stampa del menu delle opzioni e dei rispettivi codici
    Scelta = input('''-------------------------------------------------------------------------------------
                                        MENU
-------------------------------------------------------------------------------------
1. Inserimento di N libri nella biblioteca
2. Stampa del numero totale di libri presenti
3. Stampa di tutti i libri presenti
4. Stampa di tutti i libri ordinati per autore
5. Stampa dei libri che non sono in prestito ordinati per codice
6. Stampa di tutti i libri in scadenza (a meno di 2 giorni dalla data di scadenza)
7. Esci (con conferma)
-------------------------------------------------------------------------------------
Selezioni una delle opzioni: ''')
    print("-------------------------------------------------------------------------------------")
    #Valore di ritorno:
    return Scelta                                #Restituzione della variabile che determina quale delle opzioni verrà selezionata


    #Funzione:
def ConfermaUscita(Uscire) -> bool:
    '''
Funzione: ConfermaUscita
Funzione creata per confermare l'uscita dal programma.

Parametri formali:
Conferma --> Inserimento richiesto per confermare l'uscita dal programma.

Valore di ritorno:
Uscire --> Variabile che attiva la conferma di uscita dal programma.
    '''
    #Parametri formali:
    
    Conferma=input("Confermi l'uscita?\n\nS - Si\nN - No\n")    #Inserimento conferma di uscita programma.
    if (Conferma == "S") or (Conferma == "s"):   #Condizione che capisce se la conferma di uscita può essere azionata.
        Uscire = True                            #Modifica della variabile che conferma la uscita dal programma.

    #Valore di ritorno:
    return Uscire                                #Restituzione della variabile che autorizza o meno la chiusura e l'uscita dal programma.                                     

            
#Funzione:
def InserimentoLibro(Biblioteca:list , CeUnLibro:bool):
    '''
Funzione: InserimentoLibro
Funzione creata per ricevere la registrazione del libro per tutto il tempo che l'utente desidera e quindi
inviare informazioni su tutti i libri e la conferma che ora è possibile utilizzare le altre funzioni.

Parametri formali:
Inserimento --> Variabile che si mantiene attivo il ciclo per registrare un nuovo libro.
CodiceNumerico --> Variabilòe che riceve il codice del libro.
Titolo --> Variabilòe che riceve il titolo del libro.
Autore --> Variabilòe che riceve l'autore del libro.
Pubblicazione --> Variabilòe che riceve l'anno di pubblicazione del libro.
CasaEditrice --> Variabilòe che riceve la casa editrice del libro.
UtentePrestito --> Variabilòe che riceve il nome della persona che ha prestato il libro.
GiorniScadenza --> Variabilòe che riceve il numero di giorni rimasti alla scadenza.

Valore di ritorno:
Biblioteca --> Lista che memorizzerà le informazioni su tutti i libri.
CeUnLibro  --> Variabile che informa se un libro è già stato registrato oppure no.
    '''
#Parametri formali:

    Inserimento = True                   #Variabile che conferma l'ingresso nel ciclo per registrare un nuovo libro.
            
    while Inserimento:                      #Ciclo creato per registrare un nuovo libro.
            
        CodiceNumerico = -1
        while CodiceNumerico < 0:           #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
            CodiceNumerico = int(input("Inserisci il codice del libro: "))
        
        Titolo = ""
        while not Titolo:
            Titolo = input("Inserisci il titolo del libro: ")
        
        Autore = ""
        while not Autore:                   #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
            Autore = input("Inserisci l'autore del libro: ")
        
        Pubblicazione = 0
        while Pubblicazione <= 0:           #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
            Pubblicazione = int(input("Inserisci l'anno di pubblicazione del libro: "))                
        
        CasaEditrice = ""
        while not CasaEditrice:             #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
            CasaEditrice = input("Inserisci la casa editrice del libro: ")
        
        UtentePrestito = input("Inserisci il nome della persona che ha prestato il libro (Lasciare il campo vuoto se non è in prestito): ")
        
        GiorniScadenza = 0
        if UtentePrestito != "":
            while GiorniScadenza <= 0:           #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
                GiorniScadenza = int(input("Inserisci il numero di giorni rimasti alla scadenza: "))                

        Biblioteca.append(Collezione(CodiceNumerico , Titolo , Autore , Pubblicazione , CasaEditrice , UtentePrestito , GiorniScadenza))          
        
        print("-------------------------------------------------------------------------------------")    
        ConfermaLibro=input("Vuoi inserire un nuovo libro??\n\nS - Si\nN - No\n")     #Inserimento conferma di registro di un nuovo libro.
        print("-------------------------------------------------------------------------------------")    
        if (ConfermaLibro == "N") or (ConfermaLibro == "n"):      #Condizione che capisce se la conferma di uscita può essere azionata.
            Inserimento = False          #Modifica della variabile che conferma la uscita dal programma.            
            
    CeUnLibro = True                     #Attivazione della variabile che informa che un libro è già stato registrato.

#Valore di ritorno:

    return Biblioteca , CeUnLibro

            
#Funzione:
def NumeroTotaleLibri(Biblioteca:list) -> int:
    '''
Funzione: NumeroTotaleLibri
Funzione creata per contare il numero totale di libri inseriti.

Valore di ritorno:
Biblioteca --> Lista che memorizzerà le informazioni su tutti i libri.
    '''

#Valore di ritorno:

    return len(Biblioteca)                  #Funzione che conta quanti libri sono stati aggiunti alla lista.              


#Funzione:
def StampaTutto(Biblioteca:list):
    '''
Funzione: StampaTutto
Funzione creata per stampare tutti i libri inseriti nella lista.
    '''
#Parametri formali:

    print("  Codice  " , "       Titolo       " , "       Autore       " , " Pubblicazione " , "    Casa Editrice   " , "       Utente       " , " Scadenza ")
    print("--------------------------------------------------------------------------------------------------------------------------")
    for Collezione in Biblioteca:
        print(f"{Collezione.CodiceNumerico:<10} {Collezione.Titolo:<20} {Collezione.Autore:<20} {Collezione.Pubblicazione:<15} {Collezione.CasaEditrice:<20} {Collezione.UtentePrestito:<20} {Collezione.GiorniScadenza:<10}")

            
#Funzione:
def StampaOrdiniAutore(Biblioteca:list):
    '''
Funzione: StampaOrdiniAutore
Funzione creata per stampare tutti i libri ordinati per autore.
    '''
#Parametri formali:
      
    for i in range ( len(Biblioteca) ):
        for j in range ( i , len(Biblioteca) ):
            if Biblioteca[i].Autore > Biblioteca[j].Autore:
                Biblioteca[i] , Biblioteca[j] = Biblioteca[j] , Biblioteca[i]

    print("  Codice  " , "       Titolo       " , "       Autore       " , " Pubblicazione " , "    Casa Editrice   " , "       Utente       " , " Scadenza ")
    print("--------------------------------------------------------------------------------------------------------------------------")
    for Collezione in Biblioteca:
        print(f"{Collezione.CodiceNumerico:<10} {Collezione.Titolo:<20} {Collezione.Autore:<20} {Collezione.Pubblicazione:<15} {Collezione.CasaEditrice:<20} {Collezione.UtentePrestito:<20} {Collezione.GiorniScadenza:<10}")

            
#Funzione:
def StampaNonPrestitoOrdineCodice(Biblioteca:list):
    '''
Funzione: StampaNonPrestitoOrdineCodice
Funzione creata per stampare dei libri che non sono in prestito ordinati per codice.
'''
#Parametri formali:

    for i in range ( len(Biblioteca) ):
        for j in range ( i , len(Biblioteca) ):
            if Biblioteca[i].CodiceNumerico > Biblioteca[j].CodiceNumerico:
                Biblioteca[i] , Biblioteca[j] = Biblioteca[j] , Biblioteca[i]
    
    print("  Codice  " , "       Titolo       " , "       Autore       " , " Pubblicazione " , "    Casa Editrice   " , "       Utente       " , " Scadenza ")
    print("--------------------------------------------------------------------------------------------------------------------------")
    for Collezione in Biblioteca:
        if Collezione.UtentePrestito == "":
            print(f"{Collezione.CodiceNumerico:<10} {Collezione.Titolo:<20} {Collezione.Autore:<20} {Collezione.Pubblicazione:<15} {Collezione.CasaEditrice:<20} {Collezione.UtentePrestito:<20} {Collezione.GiorniScadenza:<10}")



            
#Funzione:
def Scadenza2Giorni(Biblioteca:list):
    '''
Funzione: Scadenza2Giorni
Funzione creata per stampare tutti i libri in scadenza a meno di 2 giorni.
    '''
#Parametri formali:
    
    print("  Codice  " , "       Titolo       " , "       Autore       " , " Pubblicazione " , "    Casa Editrice   " , "       Utente       " , " Scadenza ")
    print("--------------------------------------------------------------------------------------------------------------------------")
    for Collezione in Biblioteca:
        if Collezione.GiorniScadenza <= 2 and Collezione.UtentePrestito != "":
            print(f"{Collezione.CodiceNumerico:<10} {Collezione.Titolo:<20} {Collezione.Autore:<20} {Collezione.Pubblicazione:<15} {Collezione.CasaEditrice:<20} {Collezione.UtentePrestito:<20} {Collezione.GiorniScadenza:<10}")


# Inizializzazioni Variabili

Uscire = False                                   #Variabile che conferma la uscita dal programma.
CeUnLibro = False                                #Variabile che informa se un libro è già stato registrato oppure no.
Biblioteca = []                                  #Inizializzazione della lista che memorizzerà le informazioni su tutti i libri.

# Sezione di Input Dati


 
# Elaborazione

while not Uscire:                                #Ciclo creato per capire se la variabile di conferma è stata attivata.
    Scelta = SceltaMenu()                        #Attivazione della funzione che stampa il menù e comprende la scelta selezionata.
    match Scelta:                                #Menu con un elenco di tutte le opzioni che possono essere selezionate.
        case "1":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 1.
            
            Biblioteca , CeUnLibro = InserimentoLibro(Biblioteca,CeUnLibro)

        case "2":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 2.

            if not CeUnLibro:                    #Condizione creata per sapere se un libro è già stato aggiunto alla lista.
                print("  *****   Errore - Prima è necessario inserire almeno un libro nella lista.   ***** ")
            
            else:
                
                NumeroRegistri = NumeroTotaleLibri(Biblioteca)
                print(f"Finora sono stati registrati {NumeroRegistri} libri.")
            
        case "3":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 3.

            if not CeUnLibro:                    #Condizione creata per sapere se un libro è già stato aggiunto alla lista.
                print("  *****   Errore - Prima è necessario inserire almeno un libro nella lista.   ***** ")
            
            else:
                StampaTutto(Biblioteca)

        case "4":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 4.
   
            if not CeUnLibro:                    #Condizione creata per sapere se un libro è già stato aggiunto alla lista.
                print("  *****   Errore - Prima è necessario inserire almeno un libro nella lista.   ***** ")
            
            else:
                StampaOrdiniAutore(Biblioteca)


        case "5":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 5.
   
            if not CeUnLibro:                    #Condizione creata per sapere se un libro è già stato aggiunto alla lista.
                print("  *****   Errore - Prima è necessario inserire almeno un libro nella lista.   ***** ")
            
            else:
                StampaNonPrestitoOrdineCodice(Biblioteca)


        case "6":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 6.
   
            if not CeUnLibro:                    #Condizione creata per sapere se un libro è già stato aggiunto alla lista.
                print("  *****   Errore - Prima è necessario inserire almeno un libro nella lista.   ***** ")
            
            else:
                Scadenza2Giorni(Biblioteca)


        case "7":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 7.
                        
            Uscire = ConfermaUscita(Uscire)      #Attivazione della funzione che conferma l'uscita e la chiusura del programma.
            
        case _:                                  #Attivazione del messaggio di errore stampato se l'utente digita qualcosa che non è una delle funzioni.
            
            print("     *****   Errore - È necessario selezionare una delle opzioni valide.   *****")        #Stampa dei messaggi di errore.

# Eventuali Sotto Processi di Elaborazione

# Sezione di Output

print('''-------------------------------------------------------------------------------------
                                        END
-------------------------------------------------------------------------------------''')