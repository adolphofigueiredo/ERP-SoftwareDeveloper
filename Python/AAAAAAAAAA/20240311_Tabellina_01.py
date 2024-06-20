NTAB = int(input("Inserisci il numero: "))

TABELLINA = 1

while TABELLINA <= NTAB:
    I = 1
    print("\n")
    NUMERO = TABELLINA
    while I <= NTAB:
        print(TABELLINA," x ",I,"= ",NUMERO,)
        NUMERO = NUMERO + TABELLINA
        I = I + 1
    TABELLINA = TABELLINA + 1
