'''

Author: Adolpho Silverio Figueiredo Neto
Date: 08/03/2024

Exercise: Multiples of an Integer
Input two integers A and N. Print all multiples of A less than N.

Example:

Input A=2 N=13 Output: 4 (2*2) 6 (2*3) 8 (2*4) 10 (2*5) 12(2*6)

'''

# Input Section

factor = int(input("\nEnter the number to multiply: "))
maximum = int(input("\nEnter the maximum number: "))

# Variable Initializations

counter = 0
to_print = 0

# Processing
if factor > 0 and maximum > 0:
    while to_print <= maximum:
        print(to_print, end=" | ")
        counter += 1
        to_print = factor * counter
else:
    print("\nThe numbers must be positive.\n")

# Optional processing steps

# Output Section
