'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 04/03/2024

Quarto Esercizio
Si hanno in input due numeri reali A e B e una successione di numeri reali che termina con
il valore 0. Si vuole in output la somma dei soli numeri compresi tra A e B.
esempio:
Input: A: 3.5 B: 10 successione: 4.0 15.4 9.3 23.72 0
Output: somma: 4.0 + 9.3 = 13.3

'''

# Sezione di input Dati

numA = int(input("Inserisci il primo numero (A): "))
numB = int(input("Inserisci il secondo numero (B): "))
numS = int
somma = 0

# Elaborazione

while not numS == 0:
    numS = int(input("Inserisci un numero: "))
    if ( numA >= numS >= numB ) or ( numA <= numS <= numB ):
        somma = somma + numS

# Sezione di output
        
print("La somma dei numeri compressi tra {} e {} è {}.".format(numA,numB,somma))