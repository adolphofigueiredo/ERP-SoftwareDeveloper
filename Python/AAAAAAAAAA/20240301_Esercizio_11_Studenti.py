'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio : Studenti

Realizzare un programma che chieda all’utente di inserire l’età e la materia di studio. La
materia di studio viene rappresentata utilizzando il seguente prospetto:

➔ 1 -> Informatica
➔ 2 -> Fisica
➔ 3 -> Matematica

In output si deve mostrare un messaggio simile ai seguenti:

➔ "Ciao, hai 20 anni e studi Informatica."
➔ "Ciao, hai 22 anni e studi Matematica."

'''

eta = int(input("Quanti anni hai?"))
scelta = int(input("\nSeleziona la tua materia di studio:\n➔ 1 -> Informatica\n➔ 2 -> Fisica\n➔ 3 -> Matematica\n"))

match scelta:
    case 1:
        print("Ciao, hai {} anni e studi informatica.".format(eta))
    case 2:
        print("Ciao, hai {} anni e studi fisica.".format(eta))
    case 3:
        print("Ciao, hai {} anni e studi matematica.".format(eta))
    case _:
        print("Seleziona un'opzione valida!")