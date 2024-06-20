n = int(input("N"))

riga = 2
colonna = 0

while riga < n + 2:
    print(riga,end="\t")
    riga += 1
    colonna = riga
    for i in range (1 , n ):
        print(colonna,end="\t")
        colonna += 1
    print("\n")