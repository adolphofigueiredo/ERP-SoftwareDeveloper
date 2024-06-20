'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 15/03/2024

Esercizio: Medie (menù di scelta)
Costruire un programma che presenti il seguente menù:
1. Inserire N (intero)
2. Inserire i numeri A e B
3. Inserire N valori e stampare il massimo
4. Inserire N valori e stampare la media aritmetica dei soli valori compresi tra A e B
5. Uscita
L’uscita con conferma.

'''

# Sezione di input Dati



# Inizializzazioni variabili
    
ciclo = True
n = 0
accumulatore = 0
contatoremedia = 0

# Elaborazione

while ciclo == True:
    scelta = input('''
                    1. Inserire N (intero)
                    2. Inserire i numeri A e B
                    3. Inserire N valori e stampare il massimo
                    4. Inserire N valori e stampare la media aritmetica dei soli valori compresi tra A e B
                    5. Uscita\n
                   ''')
    match scelta:
        case "1":
            n = int(input("\nInserisci il numero di dati da inserire: "))
            while n <= 0:
                n = int(input("\nIl numero deve essere positivo!\n\nInserisci il numero di dati da inserire: "))
        case "2":
            a = int(input("\nInserisci il primo numero (A): "))
            b = int(input("\nInserisci il secondo numero (B): "))
        case "3":
            contatore = 1
            test = int(input("\nInserisci il valore {}: ".format(contatore)))
            testmax = test
            for i in range (1, n):
                contatore += 1
                test = int(input("\nInserisci il valore {}: ".format(contatore)))
                if test > testmax:
                    testmax = test
            print("\nIl valore massimo inserito è {}.".format(testmax))
        case "4":
            contatore = 1
            for i in range (1 , n + 1):
                test = int(input("\nInserisci il valore {}: ".format(contatore)))
                contatore += 1
                if (a >= test >= b) or (a <= test <= b):    # Nao e correto aceitar assim, o ideal é na hora de pedir a variavel A e B dizer que deve ser em ordem crescente.
                    accumulatore = accumulatore + test
                    contatoremedia += 1
            print("\n\nLa media aritmetica dei valori compressi tra {} e {} è {}.".format(a,b,accumulatore/contatoremedia))
        case "5":
            conferma = input("Confermi l'uscita?\nS - Si\nN - no\n")
            if conferma == "s" or conferma == "S":
                ciclo = False
        case _:
            print("\nSelezioni un'opzione valida!\n")
# Eventuali sotto processi di Elaborazione



# Sezione di output


