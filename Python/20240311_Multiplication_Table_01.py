NTAB = int(input("Enter the number: "))

TABLE = 1

while TABLE <= NTAB:
    I = 1
    print("\n")
    NUMBER = TABLE
    while I <= NTAB:
        print(TABLE," x ",I,"= ",NUMBER,)
        NUMBER = NUMBER + TABLE
        I = I + 1
    TABLE = TABLE + 1
