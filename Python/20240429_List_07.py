# Inserting N (size of the list)
N = int(input("N: "))
while N < 1:
    N = int(input("REENTER N: "))

# Inserting N elements into the list
lista = []  # create an empty list
# Loop to insert elements into the list
for i in range(N):
    # request input for the element to be inserted into the list
    elemento = float(input("Enter list element: "))
    # Store the element in the list
    lista += [elemento]

# print the list to the standard output
for ele in lista:
    print("List element: ", ele)
