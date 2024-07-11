'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 01/03/2024

Esercizio: Formato data
Inserire una data nel formato ggmmaaaa mediante l’inserimento di tre numeri GG, MM e
AAAA .Verifica se la data inserita è corretta, cioè rappresenta una data vera.


'''

GG = int(input("inserisci il giorno dell'anno: "))
MM = int(input("inserisci il mese dell'anno: "))
AAAA = int(input("Inserisci l'anno: "))

if MM <= 12 and GG <= 31 and AAAA >= 0:
    if MM == 1 or MM == 3 or MM == 5 or MM == 7 or MM == 8 or MM == 10 or MM == 12:
            print("È una data corretta!")
    elif MM == 4 or MM == 6 or MM == 9 or MM == 11:
        if GG <= 30:
            print("È una data corretta!")
        else:
            print("Non é una data corretta!")
    elif AAAA // 4 == AAAA / 4:
        if GG <= 29:
            print("È una data corretta!")
        else:
            print("Non é una data corretta!")
    elif GG <= 28:
        print("È una data corretta!")
    else:
        print("Non é una data corretta!")
else:
      print("Non é una data corretta!")