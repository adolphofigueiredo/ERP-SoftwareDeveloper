'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 25/03/2024

Primo Esercizio

Riorganizzare il codice del programma di: "Gestione triplette di numeri" utilizzando le
funzioni. Per ogni opzione del menu' di scelta andare a richiamare una differente funzione.

'''

# Funzioni:

#Funzione: inserimentotripleta
def inserimentotripleta():                                                                      
#Parametri formali:
    A = int(input("\nInserisci il primo numero: "))                                                #Inserimento del primo numero.
    while A <= 0:                                                                                  #Loop creato per garantire che il numero sia positivo.
        A = int(input("\nErrore - Il numero deve essere positivo!\nInserisci il primo numero: "))
    B = int(input("\nInserisci il secondo numero: "))                                              #Inserimento del secondo numero.
    while B <= 0:                                                                                  #Loop creato per garantire che il numero sia positivo.
        B = int(input("\nErrore - Il numero deve essere positivo!\nInserisci il secondo numero: "))
    C = int(input("\nInserisci il terzo numero: "))                                                #Inserimento del terzo numero.
    while C <= 0:                                                                                  #Loop creato per garantire che il numero sia positivo.
        C = int(input("\nErrore - Il numero deve essere positivo!\nInserisci il terzo numero: "))
#Valore di ritorno:    
    return A,B,C


#Funzione: stampatripleta
def stampatripleta(A,B,C):                                                     #Definizione creata per stampare i numeri.
#Parametri formali:
    print("I tre numeri inseriti sono: {} | {} | {}.".format(A,B,C,))


#Funzione: massimo
def massimo(A,B,C):                                                            #Definizione creata per trovare il numero più grande.
#Parametri formali:
    massimo = A
    if massimo < B:
        massimo = B
    if massimo < C:
        massimo = C
    print("Il numero più grande è {}.".format(massimo))
#Valore di ritorno:
    return massimo


#Funzione: minimo
def minimo(A,B,C):                                                             #Definizione creata per trovare il numero più piccolo.
#Parametri formali:
    minimo = A
    if minimo > B:
        minimo = B
    if minimo > C:
        minimo = C
    print("Il numero più piccolo è {}.".format(minimo))
#Valore di ritorno:
    return minimo


#Funzione: media
def media(A,B,C):                                                              #Definizione creata per calcolare la media aritmetica.
#Parametri formali:
    somma = A + B + C
    media = somma / 3
    print("\nLa media aritmetica è {}.".format(media))
#Valore di ritorno:
    return media


#Funzione: crescente
def crescente(A,B,C):                                                          #Definizione creata per disporre i numeri in ordine crescente.
#Parametri formali:
    if A < B:
        if A < C:
            if B < C:
                print(A,B,C,sep = " | ")
                return(A,B,C)
            else: 
                print(A,C,B,sep = " | ")
                return(A,C,B)
        else:
            print(C,A,B,sep = " | ")
            return(C,A,B)
    else:
        if A < C:
            print(B,A,C,sep = " | ")
            return(B,A,C)
        elif B < C:
            print(B,C,A,sep =" | ")
            return(B,C,A)
        else:
            print(C,B,A,sep= " | ")
            return(C,B,A)


#Funzione: decrescente
def decrescente(A,B,C):                                                        #Definizione creata per disporre i numeri in ordine decrescente.
#Parametri formali:
    if A < B:
        if A < C:
            if B < C:
                print(C,B,A,sep = " | ")
                return(C,B,A)
            else: 
                print(B,C,A,sep = " | ")
                return(B,C,A)
        else:
            print(B,A,C,sep = " | ")
            return(B,A,C)
    else:
        if A < C:
            print(C,A,B,sep = " | ")
            return(C,A,B)
        elif B < C:
            print(A,C,B,sep =" | ")
            return(A,C,B)
        else:
            print(A,B,C,sep= " | ")
            return(A,B,C)


#Funzione: Conferma Uscita
def confermauscita(uscita):                                                    #Definizione creata per confermare l'uscita.
#Parametri formali:
    conferma = input("\nConferma l'uscita?\nS - Si\nN - No\n")
    if conferma == "S" or conferma == "s":
        uscita = True
#Valore di ritorno:
        return uscita

# Sezione di input Dati

esci = False                                     #Variabile che mantiene attivo il menu.
hasnum = False                                   #Variabile creata per sapere se il numero é gia stato inserito.

# Inizializzazioni variabili

                                                                                         #Aggiungi commenti

# Elaborazione

while not esci:
    scelta = input('''
Selezioni una delle opzioni:\n
    1. Inserimento tripletta di numeri
    2. Stampa tripletta
    3. Stampa massimo
    4. Stampa minimo
    5. Stampa media
    6. Stampa ordine crescente
    7. Stampa ordine decrescente
    8. Esci\n''')
    match scelta:
        case "1":
            num1,num2,num3 = inserimentotripleta()
            hasnum = True                                            #Conferma che il numero è stato inserito.            
        case "2":
            if not hasnum:                                           #Condizione creata per controllare l'inserimento della tripleta.
                print("Prima di selezionare questa opzione, devi selezionare l'opzione 1 e inserire la tripleta di numeri.")    
            else:
                stampatripleta(num1,num2,num3)
        case "3":
            if not hasnum:                                           #Condizione creata per controllare l'inserimento della tripleta.
                print("Prima di selezionare questa opzione, devi selezionare l'opzione 1 e inserire la tripleta di numeri.")    
            else:
                nummassimo = massimo(num1,num2,num3)                 #Ho portato le informazioni sul numero massimo nel caso in cui desideri utilizzarlo.
        case "4":        
            if not hasnum:                                           #Condizione creata per controllare l'inserimento della tripleta.
                print("Prima di selezionare questa opzione, devi selezionare l'opzione 1 e inserire la tripleta di numeri.")    
            else:
                numminimo = minimo(num1,num2,num3)                   #Ho portato le informazioni sul numero minimo nel caso in cui desideri utilizzarlo.  
        case "5":
            if not hasnum:                                           #Condizione creata per controllare l'inserimento della tripleta.
                print("Prima di selezionare questa opzione, devi selezionare l'opzione 1 e inserire la tripleta di numeri.")    
            else:
                nummedia = media(num1,num2,num3)                     #La media è stata calcolata nella definizione, ma è stata inserita anche qui per poterla utilizzare.
        case "6":
            if not hasnum:                                           #Condizione creata per controllare l'inserimento della tripleta.
                print("Prima di selezionare questa opzione, devi selezionare l'opzione 1 e inserire la tripleta di numeri.")    
            else:
                num1crescente,num2crescente,num3crescente = crescente(num1,num2,num3) #La definizione è stata creata per disporre i numeri in ordine crescente.
                                                                                      #Ho inserito i numeri qui per capire come funziona.
        case "7":
            if not hasnum:                                           #Condizione creata per controllare l'inserimento della tripleta.
                print("Prima di selezionare questa opzione, devi selezionare l'opzione 1 e inserire la tripleta di numeri.")    
            else:
                num1decrescente,num2decrescente,num3decrescente = decrescente(num1,num2,num3)  #La definizione è stata creata per disporre i numeri in ordine decrescente.
                                                                                               #Ho inserito i numeri qui per capire come funziona.
        case "8":
            esci = confermauscita(esci)            
        case _:
            print("\nErrore - Selezioni una delle opzioni valide!")

# Eventuali sotto processi di Elaborazione

# Sezione di output
