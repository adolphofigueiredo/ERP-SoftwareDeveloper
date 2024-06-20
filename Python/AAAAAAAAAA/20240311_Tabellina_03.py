NTAB = int(input("Inserisci il numero: "))

TABELLINA = 1

while TABELLINA <= NTAB:
    I = 1
    NUMERO = TABELLINA
    while I <= NTAB:
        print(NUMERO ,end="\t")
        NUMERO = NUMERO + TABELLINA
        I = I + 1
    TABELLINA = TABELLINA + 1
    print()
    