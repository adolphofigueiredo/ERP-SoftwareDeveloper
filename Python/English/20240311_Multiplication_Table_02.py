NTAB = int(input("Enter the number: "))

TABLE = 1

while TABLE <= NTAB:
    I = 1
    NUMBER = TABLE
    print("TABLE",NUMBER)
    while I <= NTAB:
        print(NUMBER, end=" | ")
        NUMBER = NUMBER + TABLE
        I = I + 1
    TABLE = TABLE + 1
    print("\n")
