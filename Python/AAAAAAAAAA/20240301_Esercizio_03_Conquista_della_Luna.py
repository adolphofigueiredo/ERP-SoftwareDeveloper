'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: Conquista della Luna
La prima volta che l’uomo è andato sulla Luna è stato il 1969, creare un programma che
chieda l’anno di nascita all’utente e gli risponda se è nato l’anno in cui l’uomo è andato
sulla Luna o quanti anni prima o quanti anni dopo.



'''

anno = int(input("Quando sei nato? "))

if anno==1969:
    print("Sei nato lo stesso anno in cui l'uomo è andato sulla luna.")
else:
    if anno > 1969:
        x = anno - 1969
        print("Sei nato {} anni dopo che l'uomo è andato sulla luna.".format(x))
    else:
        x = 1969 - anno
        print("Sei nato {} anni prima che l'uomo andasse sulla luna.".format(x))