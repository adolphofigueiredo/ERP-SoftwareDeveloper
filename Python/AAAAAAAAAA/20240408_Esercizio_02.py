'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 08/04/2024

Secondo Esercizio

Si legga una sequenza di numeri. Terminare la lettura quando si incontra un numero
dispari. In output si stampi quanti numeri sono stati letti e quanti fra essi sono risultati
diversi da zero.

Esempio: INPUT: 4 0 6 10 6 0 5
OUTPUT: Numeri letti: 6 Numeri diversi da zero: 4

'''


# Funzioni:


# Funzione: lettura
def lettura():                                             #Funzione che legge il numero.
# Parametri formali:
    test = 0                                               #Inizializzazione della variabile da testare.
    pari = 0                                               #Inizializzazione dell'accumulatore che conta il numero di test con numeri pari.
    numeri = 0                                             #Inizializzazione dell'accumulatore che conta il numero di test.
    while (test % 2) == 0 :                                #Ciclo creato per garantire che test sia pari.
        test = int(input("\nInserisci il numero: "))
        if (test % 2) == 0:                                #Condizione creata per conntrollare se il numero è pari.
            numeri += 1                                    #Contatore creato per contare quante volte sono stati letti i numeri.
            if test != 0:                                  #Condizione creata per controllare se il numero è zero.
                pari += 1                                  #Contatore creato per contare quante volte sono stati inseriti numeri pari.
# Valore di ritorno:
    return numeri,pari                                     #Invio delle variabili al programma chiamante.


# Inizializzazioni variabili

# Elaborazione

numeri, pari = lettura()                                   #Attivazione della funzione lettura.

# Sezione di output

print("\nNumeri letti: {}\nNuneri diversi da zero: {}\n".format(numeri,pari))      #Stampa i risultati.