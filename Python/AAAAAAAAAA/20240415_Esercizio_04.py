'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 15/04/2024

Quarto Esercizio (Facolativo)
Creare una funzione che ricevuti due interi che rappresentano numeratore e denominatore
di una frazione, riduca la frazione ai minimi termini.
Creare poi un programma che legga due frazioni le riduca ai minimi termini e verifichi se
abbiano lo stesso denominatore.

Suggerimento: cercare sul web l’algoritmo che semplifichi una frazione ai minimi termini
oppure l’algoritmo per calcolare l’M.C.D. tra due numeri.
'''

def MCD(x, y):
    '''Questa funzione calcola il massimo comune divisore (MCD) tra due numeri utilizzando l'algoritmo di Euclide.
    L'algoritmo è iterativo e consiste in divisioni successive fino a quando il resto della divisione diventa zero.
    L'ultimo divisore non nullo è il MCD.'''
    
    while y:                           
        x, y = y, x % y
        '''
        È lo stesso che scrivere:
        while y != 0:
            temp = x
            x = y
            y = temp % y
        '''
    return x

def semplifichi_frazione(numeratore, denominatore):
    '''Questa funzione riceve in input il numeratore e il denominatore della frazione.
    Calcoliamo il MCD dei due numeri utilizzando la funzione MCD.
    Successivamente, dividiamo sia il numeratore che il denominatore per il MCD per semplificare la frazione.
    Restituiamo il numeratore e il denominatore semplificati.'''
    divisore_comune = MCD(numeratore, denominatore)
    return numeratore // divisore_comune, denominatore // divisore_comune

# Inizializzazioni Variabili

numeratore1 = 0
denominatore1 = 0
numeratore2 = 0
denominatore2 = 0

# Sezione di Input Dati

while numeratore1 == 0:
    numeratore1 = int(input("Inserisci il primo numeratore: "))

while denominatore1 == 0:
    denominatore1 = int(input("Inserisci il primo denominatore: "))

while numeratore2 == 0:
    numeratore2 = int(input("Inserisci il secondo numeratore: "))

while denominatore2 == 0:
    denominatore2 = int(input("Inserisci il secondo denominatore: "))

# Elaborazione

semplificato_numeratore1, semplificato_denominatore1 = semplifichi_frazione(numeratore1, denominatore1)
semplificato_numeratore2, semplificato_denominatore2 = semplifichi_frazione(numeratore2, denominatore2)

# Sezione di Output


print(f"\nLa frazione 1 semplificata è {semplificato_numeratore1}/{semplificato_denominatore1}.")
print(f"\nLa frazione 2 semplificata è {semplificato_numeratore2}/{semplificato_denominatore2}.")

if semplificato_denominatore1 == semplificato_denominatore2:
    print("\nEntrambe le frazioni hanno lo stesso denominatore.\n")
else:
    print("\nLe due frazioni hanno denominatori diversi.\n")