'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 25/03/2024

Terzo Esercizio

Progettare una funzione che verifichi se il carattere dato in input sia una lettera maiuscola.
Creare un programma che faccia inserire all’utente tre caratteri e stampi quale di questi sia
maiuscolo. Stampare anche il numero totale dei caratteri maiuscoli.

'''

# Funzioni:

#Funzione: maiuscola

def maiuscola(A):                                #Definizione creata per verificare se il carattere è in lettera maiuscola.

#Parametri formali:

    if A == A.upper():
        controllo = True                         #Variabile creata per dire che la lettera è maiuscola.
    else:                           
        controllo = False                        #Variabile creata per dire che la lettera non è maiuscola.

#Valore di ritorno:

    return controllo                             #Invio del risultato.

# Sezione di input Dati

# Inizializzazioni variabili

contatore = 0                                    #Responsabile del conteggio di quante volte è stato inserito un carattere maiuscolo.

# Elaborazione

for x in range (1,4):                            #Loop creato per richiedere gli stessi dati tre volte.
    lettera = input("Inserisci la lettera: ")    #Richiesta di dati per verificare se il carattere è in lettera maiuscola.
    while lettera.isalpha() == False:            #Loop creato per verificare se il dato inserito è una lettera.
        lettera = input("Errore - L'input non è una lettera.\nInserisci la lettera: ")             #Informazione sull'errore che si è verificato e richiesta di un nuovo input.
    controllo = maiuscola(lettera)               #Utilizzando la definizione che informa se la lettera è maiuscola.
    if controllo == True:                        
        contatore += 1                           

# Eventuali sotto processi di Elaborazione

# Sezione di output

if contatore == 0:                               #Risultato quando non ci sono lettere maiuscole.
    print("Nessuna delle lettere inserite è in maiuscolo.")
elif contatore == 1:                             #Risultato quando c'è una lettera maiuscola.
    print("Solo una delle lettere inserite è in maiuscolo.")
else:                                            #Risultato quando è presente più di una lettera maiuscola.
    print("Sono state inserite {} lettere maiuscole.".format(contatore))