'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio : Calcolatrice [FACOLTATIVO]

Realizzare un programma che chieda all’utente di inserire due numeri reali e permetta
all’utente di scegliere quale operazione fare con i due numeri.

➔ Se l’utente inserisce il carattere ‘+’ si eseguirà l'addizione tra i due numeri.
➔ Se l’utente inserisce il carattere ‘-’ si eseguirà la sottrazione tra i due numeri.
➔ Se l’utente inserisce il carattere ‘*’ si eseguirà la moltiplicazione tra i due numeri.
➔ Se l’utente inserisce il carattere ‘/’ si eseguirà la divisione tra i due numeri.

Esempio: input: 3 + 4 output: 7 input: 4 z 2 output: errore!

'''

num1 = int(input("Inserisci il primo numero per fare il calcolo: "))
operatore = str(input("Inserisci l'operatore del calcolo: "))
num2 = int(input("Inserisci il secondo numero per fare il calcolo: "))

match operatore:
    case "+":
        print(num1 + num2)
    case "-":
        print(num1 - num2)
    case "*":
        print(num1 * num2)
    case "/":
        print(num1 / num2)
    case _:
        print("Questo operatore non è valido.")