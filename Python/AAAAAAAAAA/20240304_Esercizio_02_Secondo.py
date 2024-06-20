'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 04/03/2024

Secondo Esercizio
Si abbia in input un numero N di misure di temperatura, in output si vuole la media
aritmetica di tali temperature.
esempio:
Input: N = 3 temperature: 19.5 20.3 21.0
Output: media = (19.5 + 20.3 + 21.0)/ 3 = 20.267

'''

# Sezione di input Dati

n = int(input("Inserisci il numero di misure: "))
somma = 0
counter = 1
media = 0

# Elaborazione
if n <= 0:
    print("Il numero di misure deve essere positivo!")
else:
    for n in range (1,n+1):
        misura = int(input("Inserisci la temperatura {}: ".format(counter)))
        somma = somma + misura
        counter += 1
    media = somma / n
    print("La media aritmetica è {}.".format(media))