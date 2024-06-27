n = int(input("Enter a value for N: "))

row = 2
column = 0

while row < n + 2:
    print(row, end="\t")
    row += 1
    column = row
    for i in range(1, n):
        print(column, end="\t")
        column += 1
    print("\n")
