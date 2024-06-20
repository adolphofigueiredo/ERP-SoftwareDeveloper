'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: Gli intervalli [FACOLTATIVO]

Realizzare un programma che chieda all’utente di inserire un numero intero. Il programma
deve riconoscere se tale numero è interno ad uno dei seguenti intervalli:

➔ [15,18] --> da 15 a 18 con 15 e 18 inclusi.
➔ [39,45) --> da 39 a 45 con 39 incluso e 45 escluso.
➔ (91,103) --> da 91 a 103 con 91 e 103 esclusi.

Esempi:

Utente inserisce 42 --> “Il numero 42 è valido”.
Utente inserisce 32 --> “Il numero 32 inserito non è valido”.

'''

numero = int(input("Inserisci un numero intero: "))

if (numero >= 15 and numero <= 18) or (numero >= 39 and numero < 45) or (numero > 91 and numero < 103):
    print("Il numero {} inserito è valido.".format(numero))
else:
    print("Il numero {} inserito non è valido.".format(numero))