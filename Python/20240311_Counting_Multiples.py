'''

Author: Adolpho Silverio Figueiredo Neto
Date: 11/03/2024

Exercise: Counting Multiples
Input two integers A and N, and then N numbers. Count how many of these numbers are multiples of A.

'''

# Input Section

n = int(input("Enter the number of data to input: "))
while n <= 0:
    n = int(input("The value of N must be greater than zero: "))

a = int(input("Enter the factor to check: "))
while a <= 0:
    a = int(input("The value of A must be greater than zero: "))

# Variable Initialization

multiples_count = 0

# Processing

for x in range(1, n + 1):
    test = int(input("Enter value {}: ".format(x)))
    if test % a == 0 and test > 0:
        multiples_count += 1

# Output Section

print(multiples_count, "numbers are multiples of", a, ".")
