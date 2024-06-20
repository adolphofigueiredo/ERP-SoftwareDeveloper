def isPari(test):
    if test % 2 == 0:
        risultato = True
    else:
        risultato = False
    return risultato

risultato = False

test = int(input("Inserisci il numero: "))

risultato = isPari(test)

print(risultato)