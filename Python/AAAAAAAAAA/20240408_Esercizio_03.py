'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 08/04/2024

Terzo Esercizio

Scrivi un programma che esegua il calcolo delle soluzioni di un’equazione di secondo
grado nella forma ax2 + bx + c = 0 . Il programma deve mostrare il seguente menù di scelta:

1. Inserimento coefficienti (a,b,c)

2. Calcolo del discriminante (delta = b*b -4*a*c)

3. Calcolo delle soluzioni

4. Uscita

Quando si seleziona una voce di calcolo stampare il risultato calcolato.
Ogni voce deve essere gestita da una funzione. Le funzioni devono utilizzare le variabili
globali.

'''


# Funzioni:


# Funzione: Menu
def Menu():                                                #Funzione che stampa il menu.
# Parametri formali:
    global scelta                                          #Determinazione della variabile come globale.
    scelta = input('''
Selezioni una delle opzioni:
    
    1. Inserimento coefficienti (a,b,c)

    2. Calcolo del discriminante (delta = b*b -4*a*c)

    3. Calcolo delle soluzioni

    4. Uscita\n
''')


# Funzione: InserimentoCoefficienti
def InserimentoCoefficienti():                             #Funzione che richiede l'inserimento del coefficiente.
# Parametri formali:
    global a, b, c, HasCoef                                #Determinazione della variabile come globale.
    a = int(input("\nInserisci il coefficiente A: "))      #Richiesta della variabile A.   
    b = int(input("\nInserisci il coefficiente B: "))      #Richiesta della variabile B.   
    c = int(input("\nInserisci il coefficiente C: "))      #Richiesta della variabile C.
    HasCoef = True                                         #Modifica della variabile globale HasCoef per indicare che sono stati inseriti dei coefficienti.


# Funzione: CalcoloDiscriminante
def CalcoloDiscriminante():                                #Funzione che calcola il discriminante.
# Parametri formali:
    global HasDiscr , delta                                #Determinazione della variabile come globale.
    if not HasCoef:                                        #Condizione creata per controlare se è possibile calcolare il discriminante.
        print("\nErrore! - Prima di selezionare l'opzione è necessario inserire i coefficienti.")
# Valore di ritorno:
    else:
        delta = (b*b) - (4 * a * c)                        #Calcolo del delta.
        print("\nIl delta è {}.".format(delta))            #Stampa i risultati.
# Valore di ritorno:
        HasDiscr = True                                    #Modifica della variabile globale HasDiscr per indicare che è stato calcolato il discriminante.


# Funzione: CalcoloSoluzioni
def CalcoloSoluzioni():                                    #Funzione che calcola la soluzione.
# Parametri formali:
    global x, x1, x2                                       #Determinazione della variabile come globale.
    if not HasCoef:                                        #Condizione creata per controlare se è possibile calcolare la soluzione.
        print("\nErrore! - Prima di selezionare l'opzione è necessario inserire i coefficienti.")
    elif not HasDiscr:                                     #Condizione creata per controlare se è possibile calcolare la soluzione.
        print("\nErrore! - Prima di selezionare l'opzione è necessario calcolare il discriminante.")        
    else:
        if delta < 0:                                      #Condizione creata per capire come calcolare la soluzione.
            print("Il delta è inferiore a zero e quindi il risultato è impossibile.")
        elif delta == 0:
            x = - b / (2 * a)
            print("La soluzione è: ",x)
        else:
            x1 = (-b * + (delta ** 0.5)) / (2 * a)
            x2 = (-b * - (delta ** 0.5)) / (2 * a)
            print("Le soluzioni possibili sono:{} e {}.".format(x1,x2))


# Funzione: Uscita
def Uscita():                                              #Funzione che conferma l'uscita.
# Parametri formali:
    global ciclo                                           #Determinazione della variabile come globale.
    conferma = "x"                                         #Inizializzazione della variabile che conferma l'uscita.
    while conferma != "S" and conferma != "s" and conferma != "N" and conferma != "n":   #Ciclo creato per garantire che l'utente scelga una delle opzioni.
        conferma = input("\nSei sicuro di uscire?\nS - Si\nN - No\n\n")                  #Domanda di conferma.
        if conferma == "S" or conferma == "s":                                           #Condizione creata per confermare l'uscita.
# Valore di ritorno:
            ciclo = False                                  #Modifica della variabile globale ciclo in modo che possa uscire dal loop creato.

# Funzione: Errore
def Errore():                                              #Funzione che informa dell'errore che si è verificato.
# Parametri formali:
    print("\nErrore - Devi scegliere una delle opzioni menzionate!!")


# Inizializzazioni variabili


ciclo = True                                               #Variabile creata per mantenere attivo il ciclo del menu.
HasCoef = False                                            #Variabile creata per indicare che sono stati inseriti dei coefficienti.
HasDiscr = False                                           #Variabile creata per indicare che è stato calcolato il discriminante.


# Elaborazione

while ciclo == True:
    Menu()                                                 #Attivazione della funzione Menu.
    match scelta:
        case "1":                                          #Inizio delle azioni che verranno eseguite quando l'utente inserisce questo valore.
            InserimentoCoefficienti()                      #Attivazione della funzione InserimentoCoefficienti.
        case "2":                                          #Inizio delle azioni che verranno eseguite quando l'utente inserisce questo valore.
            CalcoloDiscriminante()                         #Attivazione della funzione CalcoloDiscriminante.
        case "3":                                          #Inizio delle azioni che verranno eseguite quando l'utente inserisce questo valore.
            CalcoloSoluzioni()                             #Attivazione della funzione CalcoloSoluzioni.
        case "4":                                          #Inizio delle azioni che verranno eseguite quando l'utente inserisce questo valore.
            Uscita()                                       #Attivazione della funzione Uscita.
        case _:                                            #Inizio delle azioni che verranno eseguite quando l'utente inserisce un valore diverso da quelli sopra.
            Errore()                                       #Attivazione della funzione Errore.

help(InserimentoCoefficienti)