'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 19/03/2024

Esercizio: Lanci del Dado (Numeri Casuali)
Scrivere un programma che lanci N volte un dado a sei facce. N deve essere scelto
dall’utente. In output si deve stampare la faccia uscita per ogni lancio e il numero di volte
che è stata estratta la faccia 6.

'''

# Sezione di input Dati

import random as rd                                                                      #Importa e modifica i nomi per comodità in seguito.

N = int(input("\nInserisci il numero di lanci: "))                                                            
while N <= 0:                                                                            #Loop creato per garantire che il numero di lancio sia positivo.
    N = int(input("\nI numeri di lanci deve essere maggiore che 0!\n\n Inserisci il numero di lanci: "))

# Inizializzazioni variabili

faccia6 = 0                                                                              #Contatore creato per contare il numero di volte in cui è uscita la faccia 6.                                                                                                           #Aggiungi commenti

# Elaborazione

for volta in range (1 , N+1):                                                            #Loop cvreato per lanciare il dado.
    lancio = rd.randrange(1,7)                                                           #Numero di facce sul dado.
    print("\nLancio {}: {}".format(volta,lancio))                                                          
    if lancio == 6:                                                                      #Condizione creata per contare il numero di volte con la faccia 6.
        faccia6 += 1

# Eventuali sotto processi di Elaborazione

# Sezione di output

if faccia6 == 0:
    print("\nLa faccia 6 non è stata estratta.\n")                                       #Condizione creata per capire se è singolare, plurale o no è stata estratta.
elif faccia6 == 1:
    print("\nLa faccia 6 è stata estratta {} volta.\n".format(faccia6))
else:
    print("\nLa faccia 6 è stata estratta {} volte.\n".format(faccia6))                                        
