'''

Author: Adolpho Silverio Figueiredo Neto
Date: 19/03/2024

Exercise: Sum Table (Nested Loops)

We want to print the table of all possible sums that can be obtained by rolling two dice with N faces (N input by the user).
Example: N = 4

  1 2 3 4
1 2 3 4 5
2 3 4 5 6
3 4 5 6 7
4 5 6 7 8

Attention:
● Do not print the borders of the rows and columns of the table and numbers with a gray background. To format the prints, you can use tabulation:
print(end="\t")

● You must necessarily use nested loops.

'''

# Data Input Section

N = int(input("\nEnter the number of faces on the die: ")) # Number of faces on the die
while N <= 0:                                               # Loop created to ensure the number of faces entered is positive.
    N = int(input("\nError - The number must be positive!\n\nEnter the number of faces on the die: "))

# Variable Initializations

row = 1
column = 1

# Processing

while row <= N:                                 # Loop created to calculate the first variable of the row
    print("\n", end="")
    column = 1
    while column <= N:                           # Loop created to calculate the other variables of the row
        print(row + column, end="\t")
        column += 1
    row += 1

print("\n")

# Any subprocesses for processing

# Output Section
