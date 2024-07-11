'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 08/04/2024

Quarto Esercizio

Creare una funzione che data l’altezza calcoli in quanto tempo un oggetto cade al livello
del suolo. Si faccia in modo che la funzione possa operare con la gravità del pianeta in cui
ci si trova (usare una variabile globale).
Si crei una funzione per impostare il pianeta in cui ci si trova:

● passando 0 ci si troverà sulla Terra (g =9,81 m/s^2),
● passando 1 ci si troverà sulla Luna (g= 1,62 m/s^2),
● passando 2 ci si troverà su Marte (g = 3,71 m/s^2),

passando altri valori ci si troverà sempre sulla Terra.
Creare un programma in cui si chieda all’utente il pianeta in cui ci si trova (puoi
implementare un menù di scelta), l’altezza (in metri) . Stampare in output il tempo (in
secondi) che impiegherà per arrivare al suolo.

Suggerimento: si utilizzi la seguente formula per calcolare il tempo di caduta dell'oggetto:

tempo = sqrt(2*altezza/g) g è l'accelerazione di gravità

'''


# Funzioni:


# Funzione: isAltezza
def isAltezza():                                           #Funzione che richiede l'altezza.
    global altezza                                         #Determinazione della variabile come globale.
# Parametri formali:
    while altezza <= 0:                                    #Loop creato per garantire que l'altezza sia positiva.
        altezza = float(input("\nInserisci l'altura (m): "))         #Richiesta inserimento altezza.


# Funzione: Menu
def Menu():                                                #Funzione che stampa il menu.
# Parametri formali:
    global scelta                                          #Determinazione delle variabili come globali.
    scelta = input('''
Selezioni una delle opzioni:
          
    0. Ci si trova sulla Terra (g =9,81 m/s^2)
                       
    1. Ci si trova sulla Luna (g= 1,62 m/s^2)

    2. Ci si trova su Marte (g = 3,71 m/s^2)\n    
''')


# Funzione: isPianeta
def isPianeta():                                           #Funzione che determina la gravità.
    '''
    fhsdbgfgdashgjkhsdfjklghadfjklghafjkhgaflgjkladfhgjk
    dgfksdghafasdfjgsdhfsadfjkdsfldkasò
    5645645645654
    4564564
45656
    '''
    global gravita, pianeta                                #Determinazione delle variabili come globali.
# Parametri formali:
    match scelta:                                           
        case "1":                                          #Inizio delle azioni che verranno eseguite quando l'utente inserisce questo valore.
            pianeta = "Luna"                               #Determinazione del valore del pianeta da stampare alla fine del programma.
            gravita = 1.62                                 #Determinazione del valore di gravità che verrà utilizzato nei calcoli.
        case "2":                                          #Inizio delle azioni che verranno eseguite quando l'utente inserisce questo valore.
            pianeta = "Marte"                              #Determinazione del valore del pianeta da stampare alla fine del programma.
            gravita = 3.71                                 #Determinazione del valore di gravità che verrà utilizzato nei calcoli.
        case _:                                            #Inizio delle azioni che verranno eseguite quando l'utente inserisce questo valore.
            pianeta = "Terra"                              #Determinazione del valore del pianeta da stampare alla fine del programma.
            gravita = 9.81                                 #Determinazione del valore di gravità che verrà utilizzato nei calcoli.


# Valore di ritorno:


# Inizializzazioni variabili

altezza = 0                                                #Variabile creata per garantire che il programma inizi il ciclo.
gravita = 0                                                #Variabile creata per il calcolo della gravità.
pianeta = ""                                               #Variabile creata per indicare il pianeta.

# Sezione di input Dati

isAltezza()                                                #Attivazione della funzione isAltezza.

# Elaborazione

Menu()                                                     #Attivazione della funzione isMenu.
isPianeta()                                                #Attivazione della funzione isPianeta.
tempo = ( 2 * altezza / gravita ) ** 0.5                   #Tempo (in secondi) che impiegherà per arrivare al suolo.

# Sezione di output

print(pianeta,"--> Gravità",gravita," m/s^2")              #Stampa i risultati.
print(tempo,"s\n")                                         #Stampa i risultati.

print(isPianeta.__doc__)