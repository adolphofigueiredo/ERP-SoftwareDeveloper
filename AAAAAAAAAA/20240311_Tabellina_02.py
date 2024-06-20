NTAB = int(input("Inserisci il numero: "))

TABELLINA = 1

while TABELLINA <= NTAB:
    I = 1
    NUMERO = TABELLINA
    print("Tabellina",NUMERO)
    while I <= NTAB:
        print(NUMERO, end=" | ")
        NUMERO = NUMERO + TABELLINA
        I = I + 1
    TABELLINA = TABELLINA + 1
    print("\n")