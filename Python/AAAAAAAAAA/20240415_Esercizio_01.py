'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 15/04/2024

Primo Esercizio
Scrivere una funzione che accetti un numero indeterminato di argomenti interi. Tale
funzione deve restituire il prodotto dei soli numeri positivi. Se non sono presenti dei numeri
positivi allora la funzione deve restituire il valore -1. Costruire un programma che richiami
due volte tale funzione ogni volta con parametri diversi.
'''

    #Funzione:
def Prodotto(*numero):
    risultato = 1                           #Accumulatore creato per raggiungere il risultato.
    contatore = 0                           #Contatore del numero di volte in cui un numero è stato testato.
    negativo  = 0                           #Contatore di numeri negativi testato.
    #Parametri formali:
    for val in numero:                      #Condizione creata per calcolare con un numero variabile di argomenti.
        contatore += 1
        if val >= 0:                        #Condizione creata per verificare se il numero è maggiore di zero.
            risultato *= val                #Calcolo del nuovo risultato.
    #Valore di ritorno:
        elif val < 0:                       #Condizione creata per verificare se il numero è inferiore a zero.
            negativo += 1
    if contatore == negativo:               #Condizione creata per verificare se il numero di numeri negativi è uguale al numero totale di numeri.
        risultato = -1
    return risultato

# Elaborazione

print("Prodotto: ",Prodotto(4,2,3)     )    #Test 01
print("Prodotto: ",Prodotto(1,1,1)     )    #Test 02
print("Prodotto: ",Prodotto(-4,-5,-6)  )    #Test 03
print("Prodotto: ",Prodotto(4,5,-6)    )    #Test 04
print("Prodotto: ",Prodotto(2,-5,6)    )    #Test 05
print("Prodotto: ",Prodotto(-4,5,6)    )    #Test 06
print("Prodotto: ",Prodotto(-4,5,6,2)  )    #Test 07
print("Prodotto: ",Prodotto()          )    #Test 08
print("Prodotto: ",Prodotto(-5)        )    #Test 09
print("Prodotto: ",Prodotto(5)         )    #Test 10
print("Prodotto: ",Prodotto(0)         )    #Test 11
print("Prodotto: ",Prodotto(0,3)       )    #Test 12
print("Prodotto: ",Prodotto(0,-6,9)    )    #Test 13
