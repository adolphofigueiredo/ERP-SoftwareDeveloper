'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 08/04/2024

Primo Esercizio

Scrivere una funzione che dati due numeri interi x e y, calcoli la somma di tutti i numeri
dispari compresi tra x e y. Costruire un programma che richiami n volte la funzione su n
differenti intervalli (n dato in input).
Suggerimento: utilizzare la funzione di generazione di numeri pseudocausali.

'''

import random

#Funzioni:


#Funzione: InserisciVolte
def InserisciVolte():                                      #Funzione che chiede il numero di volta che sarà generato x e y.
#Parametri formali:
    n = -1                                                 #Variabile creata per entrare nel ciclo.
    while n <= 0:                                          #Condizione creata per garantire che n sia positivo.
        n = int(input("Quante volte vuoi fare i calcoli? "))
#Valore di ritorno:
    return n                                               #Invio della variabile al programma chiamante.


#Funzione: GenerareNumeri
def GenerareNumeri():                                      #Funzione creata per generare il x e il y.
#Parametri formali:
    x = int(random.randrange(1000))                        #Formula che genera x.
    y = int(random.randrange(1000) + x + 1)                #Formula che genera y e garantisce che sia maggiore di x.
#Valore di ritorno:
    return x, y                                            #Invio delle variabili al programma chiamante.


#Funzione: Sommare
def Sommare(Min,Max):                                      #Funzione creata per calcolare la somma di tutti i numeri dispari compresi tra x e y.
    somma = 0                                              #Inizializzazione della variabile somma.
#Parametri formali:
    while Min <= Max :                                       #Ciclo creato per garantire che il minimo sia inferiore al massimo.
        if Min % 2 != 0:                                   #Funzione creata per capire se il numero è dispari.
            somma = somma + Min                            #Addizione all'accumulatore quando la condizione è soddisfatta.
        Min = Min + 1                                      #Accumulatore creato per portare il minimo al massimo.
#Valore di ritorno:
    return somma                                           #Invio della variabile al programma chiamante.


# Elaborazione

volte = InserisciVolte()                                   #Attivazione della funzione InserisciVolte.

for _ in range (1 , volte + 1 ):                           #Ciclo creato per generare il x e il y per il numero di volte richiesto.
    Min, Max = GenerareNumeri()                            #Attivazione della funzione che genera il x e il y.
    somma = Sommare(Min,Max)                               #Attivazione della fuzione che somma tutti i numeri compressi tra x e y.
    print("\nx = ",Min,"\ny = ",Max,"\nSomma = ",somma)    #Stampa i risultati.

print("\n")