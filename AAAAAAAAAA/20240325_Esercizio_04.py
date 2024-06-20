'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 25/03/2024

Quarto Esercizio

Creare una funzione che calcoli il prodotto e la somma tra tre numeri interi e restituisca la
differenza tra il prodotto e la somma calcolati.
Utilizzare questa funzione in un programma principale.

'''

# Funzioni:

#Funzione: calcolodifferenza

def calcolodifferenza(a,b,c):                              #Definizione creata per calcolare la differenza tra il prodotto e la somma.

#Parametri formali:

    somma = a + b + c                                      #Calcolo della somma.
    prodotto = a * b * c                                   #Calcolo del prodotto.

#Valore di ritorno:

    if somma <= prodotto:                                  #Condizione creata per capire se la somma è inferiore al prodotto.
        differenza = prodotto - somma                      #Calcolo della differenza.
    else:
        differenza = somma - prodotto                      #Calcolo della differenza.
    return differenza,prodotto,somma                       #Invio dei risultati.

# Sezione di input Dati

num1 = int(input("Inserisci il primo numero: "))           #Richiesta di dati per calcolare il prodotto e la somma.
while num1 <= 0:                                           #Loop creato per garantire che il numer sia positivo.
    num1 = int(input("Errore - Il numero deve essere positivo!\nInserisci il primo numero: "))     #Informazione sull'errore che si è verificato e richiesta di un nuovo input.

num2 = int(input("Inserisci il secondo numero: "))         #Richiesta di dati per calcolare il prodotto e la somma.
while num2 <= 0:                                           #Loop creato per garantire che il numero sia positivo.
    num2 = int(input("Errore - Il numero deve essere positivo!\nInserisci il secondo numero: "))   #Informazione sull'errore che si è verificato e richiesta di un nuovo input.

num3 = int(input("Inserisci il terzo numero: "))           #Richiesta di dati per calcolare il prodotto e la somma.
while num3 <= 0:                                           #Loop creato per garantire che il numero sia positivo.
    num3 = int(input("Errore - Il numero deve essere positivo!\nInserisci il terzo numero: "))     #Informazione sull'errore che si è verificato e richiesta di un nuovo input.

# Inizializzazioni variabili

# Elaborazione

differenza , prodotto , somma = calcolodifferenza(num1,num2,num3)    #Utilizzando la definizione che calcola la differenza tra il prodotto e la somma.

# Eventuali sotto processi di Elaborazione

# Sezione di output

if prodotto > somma:                                       #Condizione creata per capire se la somma è inferiore al prodotto.
    print("La differenza tra il prodotto ({}) e la somma ({}) è {}. ".format(prodotto,somma,differenza))
elif prodotto < somma:                                     #Condizione creata per capire se il prodotto è inferiore alla somma.
    print("La differenza tra la somma ({}) e il prodotto ({}) è {}.".format(somma,prodotto,differenza))
else:                                                      #Condizione creata per capire se la somma è uguale al prodotto.
    print("La somma ({}) e il prodotto ({}) sono numeri uguale, allora la differenza è {}.".format(somma,prodotto,differenza))