'''

Autore: Adolpho Silverio Figueiredo Neto - ICTS23-25.432
email: adolpho.silverio@edu.itspiemonte.it / adolphoneto@gmail.com
Tel: +39 345 3359762
Categoria: Studente - Fondamenti di Programmazione
Data: 17/06/2024

Si vuole gestire una rubrica telefonica costruendo un applicativo in python. I contatti sono definiti dalle seguenti informazioni:
nome,  cognome,  numero di telefono, email e categoria. Costruire un programma che stampi un menu’ di scelta che presenti le
seguenti opzioni:

1. Inserimento di N contatti
2. Stampa del numero totale di contatti presenti
3. Stampa del cognome, nome, numero di telefono e email di tutti i contatti
4. Stampa di tutti i contatti ordinati per cognome (stampare cognome, nome e numero di telefono)
5. Ricerca di un contatto dato il cognome e nome (stampare cognome, nome e tutti i campi del contatto)
6. Stampa dei contatti di una particolare categoria inserita in input, ordinati per cognome e nome
7. Esci

'''


from dataclasses import dataclass #righa scrita per importare la libreria dataclasses e usar datclass che mi consente di combinare un novo tipo di strutura di dati.


# Definizione delle Strutture Dati


@dataclass                                       #Classe creata per memorizzare tutte le informazioni necessarie.
class Contatto:                                  #Determinazione del nome della classe.
    Nome: str                                    #Campo appartenente alla classe contatto.
    Cognome: str                                 #Campo appartenente alla classe contatto.
    Telefono: str                                #Campo appartenente alla classe contatto.
    email: str                                   #Campo appartenente alla classe contatto.
    Categoria: str                               #Campo appartenente alla classe contatto.

# Funzioni:


    #Funzione:

def SceltaMenu() -> str:
    '''
Funzione: SceltaMenu
Funzione creata per stampare il menu e ricevere l'input selezionato.

Valore di ritorno:
Scelta --> Variabile creata per scegliere l'opzione del menu.
    '''
    #Parametri formali:                          #Stampa del menu delle opzioni e dei rispettivi codici
    Scelta = input('''-----------------------------------------------------------------------------------------------------------------------------------
                                                               MENU
-----------------------------------------------------------------------------------------------------------------------------------
1. Inserimento di N contatti
2. Stampa del numero totale di contatti presenti
3. Stampa del cognome, nome, numero di telefono e email di tutti i contatti
4. Stampa di tutti i contatti ordinati per cognome e nome (stampare cognome, nome e numero di telefono)
5. Ricerca di un contatto dato il cognome e nome (stampare cognome, nome e tutti i campi del contatto)
6. Stampa dei contatti di una particolare categoria inserita in input, ordinati per cognome e nome
7. Esci
-----------------------------------------------------------------------------------------------------------------------------------
Selezioni una delle opzioni: ''')
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    
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
    if (Conferma == "S") or (Conferma == "s"):                  #Condizione che capisce se la conferma di uscita può essere azionata.
        Uscire = True                                           #Modifica della variabile che conferma la uscita dal programma.

    #Valore di ritorno:

    return Uscire                                               #Restituzione della variabile che autorizza la chiusura e l'uscita dal programma.                                     


#Funzione:
def ContattoVuoto():
    '''
Funzione: ContattoVuoto
Funzione creata per stampare il motivo dell'errore causato
quando si seleziona questa opzione di menu.

Parametri formali:
È stato inserito solo il messaggio di errore che informa dell'accaduto.
    '''

#Parametri formali:

    print("                       *****   Errore - Prima è necessario inserire almeno un contatto nella lista.   *****")

            
#Funzione:
def UscitaInserimento(Inserimento:bool) -> bool:
    '''
Funzione: UscitaInserimento
Funzione creata per mantenere attivo il ciclo di inserimento dei contatti.

Parametri formali:
ConfermaContatto --> Inserimento richiesto per confermare l'uscita dal ciclo per registrare un nuovo contatto.

Valore di ritorno:
Inserimento --> Variabile che si mantiene attivo il ciclo per registrare un nuovo contatto.
    '''

#Parametri formali:

    print("-----------------------------------------------------------------------------------------------------------------------------------")    
    ConfermaContatto=input("Vuoi inserire un nuovo contatto?\n\nS - Si\nN - No\n")     #Inserimento conferma di registro di un nuovo contatto.
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    if (ConfermaContatto == "N") or (ConfermaContatto == "n"):      #Condizione che capisce se la conferma di uscita può essere azionata.
            Inserimento = False             #Modifica della variabile che controlla la continuazione delle registrazioni di nuovi contatti.

#Valore di ritorno:

    return Inserimento


#Funzione:
def InserimentoContatto(Contatti:list , CeUnContatto:bool):
    '''
Funzione: InserimentoContatto
Funzione creata nata per inserire i contatti desiderati quante volte l'utente vuole, questa
opzione può anche essere utilizzata quante volte si vuole senza la necessità di determinare
il numero di contatti che verranno registrati inizialmente.

Parametri formali:
Inserimento --> Variabile che si mantiene attivo il ciclo per registrare un nuovo contatto.
Nome --> Variabilòe che riceve il nome.
Cognome --> Variabilòe che riceve il cognome.
Telefono --> Variabilòe che riceve il telefono.
email --> Variabilòe che riceve l'email.
Categoria --> Variabilòe che riceve la categoria. 

Valore di ritorno:
Contatti --> Lista che memorizzerà le informazioni su tutti i contatti.
CeUnLibro  --> Variabile che informa se un contatto è già stato registrato oppure no.
    '''

#Parametri formali:

    Inserimento = True                      #Variabile che conferma l'ingresso nel ciclo per registrare un nuovo contatto.
            
    while Inserimento:                      #Ciclo creato per registrare un nuovo contatto.

        Nome = ""
        while not Nome:                     #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
            Nome = input("Inserisci il nome del contatto: ")
        
        Cognome = ""
        while not Cognome:                  #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
            Cognome = input("Inserisci il cognome del contatto: ")
        
        Telefono = ""
        while not Telefono:                 #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
            Telefono = input("Inserisci il telefono del contatto: ")

        email = ""
        while not email:                    #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
            email = input("Inserisci il email del contatto: ")

        Categoria = ""
        while not Categoria:                #Ciclo creato per verificare se le informazioni inserite possono essere registrate.
            Categoria = input("Inserisci la categoria del contatto: ")

        Contatti.append(Contatto( Nome , Cognome , Telefono , email , Categoria ))          
        
        Inserimento = UscitaInserimento(Inserimento)
            
    CeUnContatto = True                     #Attivazione della variabile che informa che un libro è già stato registrato.

#Valore di ritorno:

    return Contatti , CeUnContatto

            
#Funzione:
def NumeroTotaleContatti(Contatti:list) -> int:
    '''
Funzione: NumeroTotaleContatti
Funzione creata per contare il numero totale di contatti inseriti.

Valore di ritorno:
Contatti --> Lista che memorizzerà le informazioni su tutti i contatti.
    '''

#Valore di ritorno:

    return len(Contatti)                    #Funzione che conta quanti contatti sono stati aggiunti alla lista.              


#Funzione:
def StampaTutto(Contatti:list):
    '''
Funzione: StampaTutto
Funzione creata per stampare tutti i contatti inseriti nella lista.
    '''
#Parametri formali:

    print("      Cognome       " , "      Nome      " , "      Telefono      " , "               email               " , "      Categoria     ")
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    for Contatto in Contatti:               #Ciclo creato per stampare tutti i contatti della lista contatti.
        print(f"{Contatto.Cognome:<20} {Contatto.Nome:<16} {Contatto.Telefono:<20} {Contatto.email:<35} {Contatto.Categoria:<20}")


#Funzione:
def StampaTuttoSenzaCategoria(Contatti:list):
    '''
Funzione: StampaTutto
Funzione creata per stampare tutti i contatti inseriti nella lista senza il campo categoria.
    '''
#Parametri formali:

    print("      Cognome       " , "      Nome      " , "      Telefono      " , "               email               ")
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    for Contatto in Contatti:               #Ciclo creato per stampare tutti i contatti della lista contatti.
        print(f"{Contatto.Cognome:<20} {Contatto.Nome:<16} {Contatto.Telefono:<20} {Contatto.email:<35}")


#Funzione:
def OrdinareNome(Contatti:list) -> list:
    '''
Funzione: OrdinareCognome
Funzione creata per ordinare tutti i contatti per nome.

Valore di ritorno:
Contatti --> Lista che memorizzerà le informazioni su tutti i contatti.
    '''
#Parametri formali:
      
    for i in range ( len(Contatti) ):
        for j in range ( i , len(Contatti) ):
            if Contatti[i].Nome > Contatti[j].Nome:
                Contatti[i] , Contatti[j] = Contatti[j] , Contatti[i]

#Valore di ritorno:

    return Contatti


#Funzione:
def OrdinareCognome(Contatti:list) -> list:
    '''
Funzione: OrdinareCognome
Funzione creata per ordinare tutti i contatti per cognome.

Valore di ritorno:
Contatti --> Lista che memorizzerà le informazioni su tutti i contatti.
    '''
#Parametri formali:
      
    for i in range ( len(Contatti) ):
        for j in range ( i , len(Contatti) ):
            if Contatti[i].Cognome > Contatti[j].Cognome:
                Contatti[i] , Contatti[j] = Contatti[j] , Contatti[i]

#Valore di ritorno:

    return Contatti


#Funzione:
def StampaCognomeNomeTelefono(Contatti:list):
    '''
Funzione: StampaCognomeNomeTelefono
funzione creata per stampare tutti i contatti della lista, ma solo i campi cognome, nome e telefono.
    '''
#Parametri formali:

    print("      Cognome       " , "      Nome      " , "      Telefono      ")
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    for Contatto in Contatti:               #Ciclo creato per stampare tutti i contatti della lista contatti.
        print(f"{Contatto.Cognome:<20} {Contatto.Nome:<16} {Contatto.Telefono:<20}")


#Funzione:
def RicercaContatto(Contatti: list):
    '''
    Funzione: RicercaContatto
    Funzione creata per cercare un contatto specifico nella lista dei contatti dati cognome e nome.

    Parametri formali:
    Contatti --> Lista che memorizza le informazioni su tutti i contatti.
    cognome --> Variabile che riceve il cognome da cercare.
    nome --> Variabile che riceve il nome da cercare.

    Valore di ritorno:
    Nessuno
    '''
    trovato = False

    cognome = input("Inserisci il cognome del contatto da cercare: ")
    nome = input("Inserisci il nome del contatto da cercare: ")
    
    for Contatto in Contatti:
        if Contatto.Cognome.lower() == cognome.lower() and Contatto.Nome.lower() == nome.lower():
            print("-----------------------------------------------------------------------------------------------------------------------------------")
            print(f"\nCognome: {Contatto.Cognome}\nNome: {Contatto.Nome}\nTelefono: {Contatto.Telefono}\nEmail: {Contatto.email}\nCategoria: {Contatto.Categoria}\n")
            trovato = True
    if not trovato:
        print("-----------------------------------------------------------------------------------------------------------------------------------")
        print("Contatto non trovato.")


#Funzione:

def StampaContattiPerCategoria(Contatti: list):

    '''
Funzione: StampaContattiPerCategoria
Funzione creata per cercare una categoria specifico nella lista e stampare i contatti.
    '''

#Parametri formali:
    categoria = input("Inserisci la categoria dei contatti da stampare: ")
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    
    for i in range ( len(Contatti) ):
        for j in range ( i , len(Contatti) ):
            if Contatti[i].Categoria > Contatti[j].Categoria:
                Contatti[i] , Contatti[j] = Contatti[j] , Contatti[i]
    
    trovato = False

    for Contatto in Contatti:
        if Contatto.Categoria.lower() == categoria.lower():
            print("-----------------------------------------------------------------------------------------------------------------------------------")
            print(f"{Contatto.Cognome:<20} {Contatto.Nome:<16} {Contatto.Telefono:<20} {Contatto.email:<35} {Contatto.Categoria:<20}")
            trovato = True
    if not trovato:
        print("-----------------------------------------------------------------------------------------------------------------------------------")
        print("Categoria non trovata.")    
    
                                                                                                   
# Inizializzazioni Variabili

Uscire = False                                   #Variabile che conferma la uscita dal programma.
CeUnContatto = False                             #Variabile che informa se un Contatto è già stato registrato oppure no.
Contatti = []                                    #Inizializzazione della lista che memorizzerà le informazioni su tutti i contatti.

# Sezione di Input Dati


 
# Elaborazione

while not Uscire:                                #Ciclo creato per capire se la variabile di conferma di uscita è stata attivata.
    Scelta = SceltaMenu()                        #Attivazione della funzione che stampa il menù e comprende la scelta selezionata.
    match Scelta:                                #Menu con un elenco di tutte le opzioni che possono essere selezionate.
        case "1":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 1.
            
            Contatti , CeUnContatto = InserimentoContatto(Contatti , CeUnContatto)

        case "2":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 2.

            if not CeUnContatto:                 #Condizione creata per sapere se un contatto è già stato aggiunto alla lista.

                ContattoVuoto()                  #Attivazione della funzione creata per informare il motivo dell'errore causato.
            
            else:
                
                NumeroRegistri = NumeroTotaleContatti(Contatti)

                if NumeroRegistri == 1:
                    print(f"Finora è stato registrato {NumeroRegistri} contatto.")
                else:
                    print(f"Finora sono stati registrati {NumeroRegistri} contatti.")
            
        case "3":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 3.

            if not CeUnContatto:                 #Condizione creata per sapere se un contatto è già stato aggiunto alla lista.

                ContattoVuoto()                  #Attivazione della funzione creata per informare il motivo dell'errore causato.
            
            else:
                
                StampaTutto(Contatti)

        case "4":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 4.

            if not CeUnContatto:                 #Condizione creata per sapere se un contatto è già stato aggiunto alla lista.

                ContattoVuoto()                  #Attivazione della funzione creata per informare il motivo dell'errore causato.
            
            else:
                
                Contatti = OrdinareNome(Contatti)
                Contatti = OrdinareCognome(Contatti)
                StampaCognomeNomeTelefono(Contatti)

        case "5":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 5.

            if not CeUnContatto:                 #Condizione creata per sapere se un contatto è già stato aggiunto alla lista.

                ContattoVuoto()                  #Attivazione della funzione creata per informare il motivo dell'errore causato.
            
            else:
                
                Contatti = RicercaContatto(Contatti)

        case "6":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 6.

            if not CeUnContatto:                 #Condizione creata per sapere se un contatto è già stato aggiunto alla lista.

                ContattoVuoto()                  #Attivazione della funzione creata per informare il motivo dell'errore causato.
            
            else:
                
                Contatti = StampaContattiPerCategoria(Contatti)

        case "7":                                #Inizio dei comandi che verranno attivati ​​quando viene selezionata l'opzione 7.
                        
            Uscire = ConfermaUscita(Uscire)      #Attivazione della funzione che conferma l'uscita e la chiusura del programma.
            
        case _:                                  #Attivazione del messaggio di errore stampato se l'utente digita qualcosa che non è una delle funzioni.
            
            print("                              *****   Errore - È necessario selezionare una delle opzioni valide.   *****")        #Stampa dei messaggi di errore.

# Eventuali Sotto Processi di Elaborazione

# Sezione di Output

print('''-----------------------------------------------------------------------------------------------------------------------------------
                                                               END
-----------------------------------------------------------------------------------------------------------------------------------''')