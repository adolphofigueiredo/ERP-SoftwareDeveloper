'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 25/03/2024

Secondo Esercizio

Creare una funzione che riceva una quantità di tempo in formato ore, minuti e secondi e la
restituisca espressa solamente in secondi.
Creare un programma principale che chieda in input all’utente due quantità di tempo e
stampi in output quale quantità di tempo è maggiore.

'''

# Funzioni:

#Funzione: tempo
def tempo(ora,minuti,secondi):                             #Definizione creata per trasformare il tempo in secondi.
#Parametri formali:
    tempo = (ora*60*60) + (minuti*60) + secondi            #Calcolo 
#Valore di ritorno:
    return tempo

# Sezione di input Dati

ora1 = int(input("Inserisci le ore (24h) dell'orario 1: "))                                                  #Richiesta di dati per calcolare la quantità di tempo maggiore.
while ora1 < 0:                                                                                              #Loop creato per verificare se il numero inserito é positivo.
    ora1 = int(input("Errore - Il numero deve essere positivo!\nInserisci le ore (24h) dell'orario 1: "))    #Informazione sull'errore che si è verificato e richiesta di un nuovo input

minuti1 = int(input("Inserisci i minuti dell'orario 1: "))                                                   #Richiesta di dati per calcolare la quantità di tempo maggiore.
while minuti1 <= 0:                                                                                          #Loop creato per verificare se il numero inserito è positivo
    minuti1 = int(input("Errore - Il numero deve essere positivo!\nInserisci i minuti dell'orario 1:"))      #Informazione sull'errore che si è verificato e richiesta di un nuovo input

secondi1 = int(input("Inserisci i secondi dell'orario 1: "))                                                 #Richiesta di dati per calcolare la quantità di tempo maggiore.
while secondi1 <= 0:                                                                                         #Loop creato per verificare se il numero inserito è positivo.
    secondi1 = int(input("Errore - Il numero deve essere positivo!\nInserisci i secondi dell'orario 1:"))    #Informazione sull'errore che si è verificato e richiesta di un nuovo input

ora2 = int(input("Inserisci le ore (24h) dell'orario 2: "))                                                  #Richiesta di dati per calcolare la quantità di tempo maggiore.
while ora2 < 0:                                                                                              #Loop creato per verificare se il numero inserito è positivo.
    ora2 = int(input("Errore - Il numero deve essere positivo!\nInserisci le ore (24h) dell'orario 2: "))    #Informazione sull'errore che si è verificato e richiesta di un nuovo input

minuti2 = int(input("Inserisci i minuti dell'orario 2: "))                                                   #Richiesta di dati per calcolare la quantità di tempo maggiore.
while minuti2<= 0:                                                                                           #Loop creato per verificare se il numero inserito è positivo.
    minuti2 = int(input("Errore - Il numero deve essere positivo!\nInserisci i minuti dell'orario 2: "))     #Informazione sull'errore che si è verificato e richiesta di un nuovo input

secondi2 = int(input("Inserisci i secondi dell'orario 2: "))                                                 #Richiesta di dati per calcolare la quantità di tempo maggiore.
while secondi2 <= 0:                                                                                         #Loop creato per verificare se il numero inserito é positivo.
    secondi2 = int(input("Errore il numero deve essere positivo!\nInserisci i secondi dell'orario 2: "))     #Informazione sull'errore che si è verificato e richiesta di un nuovo input

# Inizializzazioni variabili

# Elaborazione

tempo1 = tempo(ora1,minuti1,secondi1)            #Utilizzando la definizione che trasforma il tempo in secondi.
tempo2 = tempo(ora2,minuti2,secondi2)            #Utilizzando la definizione che trasforma il tempo in secondi.

if tempo1 < tempo2:                              #Condizione che definisce quale dei tempi è maggiore
    print("Il primo tempo inserito {}:{}:{} é minore del secondo tempo inserito {}:{}:{}.".format(ora1,minuti1,secondi1,ora2,minuti2,secondi2))
elif tempo1 > tempo2:                            #Condizione che definisce quale dei tempi è maggiore
    print("Il primo tempo inserito {}:{}:{} é maggiore del secondo tempo inserito {}:{}:{}.".format(ora1,minuti1,secondi1,ora2,minuti2,secondi2))
else:                                            #Condizione che definisce se i tempi sono uguali.
    print("Il primo tempo inserito {}:{}:{} é uguale del secondo tempo inserito {}:{}:{}.".format(ora1,minuti1,secondi1,ora2,minuti2,secondi2))

# Eventuali sotto processi di Elaborazione

# Sezione di output
