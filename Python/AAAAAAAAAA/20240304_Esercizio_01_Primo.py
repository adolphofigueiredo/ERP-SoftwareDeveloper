'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 04/03/2024

Primo Esercizio
Si abbia in input un numero intero positivo N . In output si vuole il fattoriale di N.
Fattoriale di n: Definizione: n! = n(n-1)(n-2)...2*1 ; 0! = 1
esempio:
0!=1 1!=1 2!=2*1 3!=3*2*1! 4!= 4*3*2*1= 24

'''

# Sezione di input Dati

num = int(input("Inserisci il numero: "))
risultato = 1
counter = 1

# Elaborazione

if num == 0:
    print("Il fattoriale di {} è 1.".format(num))
elif num > 0:
    while counter <= num:
        risultato = counter * risultato
        counter += 1                                                #Lo stesso --> counter = counter + 1
    print("Il fattoriale di {} è {}.".format(num,risultato))
else:
    print("Il numero deve essere positivo.")