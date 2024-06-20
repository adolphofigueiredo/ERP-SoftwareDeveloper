'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 19/03/2024

Esercizio: Menù di Scelta (Numeri Casuali)
Scrivere un programma che mostri il seguente menù di scelta:

1. Inserire N, A e B (numeri interi)
2. Media aritmetica di N lanci di un dado a sei facce
3. Estrazione e stampa di 10 numeri casuali compresi tra A e B
4. Media aritmetica di N numeri casuali estratti tra A e B
5. Uscita (con conferma)

'''

# Sezione di input Dati

import random as rd                                                                      #Importa e modifica i nomi per comodità in seguito.

# Inizializzazioni variabili

esci = False                                                                             #Creazione della variabile che mantiene attivo il menù.
hasA = False                                                                             #Variabile creata per sapere se la variabile A esiste
hasB = False                                                                             #Variabile creata per sapere se la variabile B esiste
hasN = False                                                                             #Variabile creata per sapere se la variabile N esiste

# Elaborazione

while esci == False:                                                                     #Aggiungi commenti
    scelta = input('''\n
Selezioni una delle opzioni:\n
    1. Inserire N, A e B
    2. Media aritmetica di N lanci di un dado a sei facce
    3. Estrazione e stampa di 10 numeri casuali compresi tra A e B
    4. Media aritmetica di N numeri casuali estratti tra A e B
    5. Uscita\n\n''')
    match scelta:
        case "1":
            N = int(input("Inserisci il numero di dati da inserire: "))                  #Numero di dati da inserire
            while N <= 0:                                                                #Loop creato per garantire che il numero di dati da inserire sia positivo.
                N = int(input("\nErrore - Il numero deve essere positivo!\n\nInserisci il numero di dati da inserire: "))
            hasN = True                                                                  #Argomento che informa che la variabile N ha un valore
            A = int(input("Inserisci il primo numero (A): "))
            B = int(input("Inserisci il secondo numero (B): "))
            while A >= B:                                                                #Loop creato per garantire che A sia minore che B
                A = int(input("\nErrore - Il primo numero deve essere minore che il secondo numero!\n\nInserisci il primo numero (A): "))
                B = int(input("Inserisci il secondo numero (B): "))
            hasA = True                                                                  #Argomento che informa che la variabile A ha un valore
            hasB = True                                                                  #Argomento che informa che la variabile B ha un valore
        case "2":
            if hasN == True:                                                             #Condizione creata per controllare se N ha un valore
                accumulatorelancio = 0                                                   #Questo accumulatore è stato dichiarato qui per evitare che l'opzione 2 si avvii con un accumulatore pieno
                for i in range ( 1 , N + 1 ):                                            #Loop creato per lanciare il dado
                    lancio = rd.randrange(1,7)
                    print(lancio , end=" | ")
                    accumulatorelancio = accumulatorelancio + lancio                     #Accumulatore creato per calcolare la media
                medialancio = accumulatorelancio / N                                     #Calcolo della media
                print("\nLa media aritmetica di {} lanci è {}.".format(N , medialancio))
            else:                                                                        #Condizione creata per segnalare l'errore
                print("\nPrima di selezionare questa opzione, è necessario determinare un valore di N.")
        case "3":
            if hasA == True and hasB == True:                                            #Condizione creata per controllare se A e B hanno valore
                for i in range ( 1 , 10 + 1):                                            #Stampa di 10 numeri casuali compresi tra A e B
                    print(rd.randrange(A , B + 1) , end=" | ")
            else:                                                                        #Condizione creata per segnalare l'errore
                print("\nPrima di selezionare questa opzione, è necessario determinare un valore di A e B.")
        case "4":
            if hasA == True and hasB == True and hasN == True:                           #Condizione creata per controllare se N, A e B hanno valore
                accumulatorecasuali = 0                                                  #Questo accumulatore è stato dichiarato qui per evitare che l'opzione 4 si avvii con un accumulatore pieno
                for i in range (1 , N + 1):                                              #Loop creato per creare i numeri
                    casuali = rd.randrange(A , B + 1)
                    print(casuali,end=" | ")
                    accumulatorecasuali = accumulatorecasuali + casuali                  #Accumulatore creato per calcolare la media. 
                mediacasuali = accumulatorecasuali / N                                   #Calcolo della media.
                print("\nLa media aritmetica di {} lanci è {}.".format(N , mediacasuali))                
            else:                                                                        #Condizione creata per segnalare l'errore
                print("\nPrima di selezionare questa opzione, è necessario determinare un valore di N, A e B.")
        case "5":
            conferma = input("\nConferma l'uscita?\nS - Si\nN - No\n")
            if conferma == "S" or conferma == "s":                                       #Condizione creata per confermare l'uscita.
                esci = True
        case _:
            print("\nErrore - Selezioni una delle opzioni valide!")

# Eventuali sotto processi di Elaborazione

# Sezione di output