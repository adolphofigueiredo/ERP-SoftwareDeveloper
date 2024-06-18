'''

Author: Adolpho Silverio Figueiredo Neto
Date: 08/03/2024

Exercise: Even Numbers
Ask for a number N as input. Print the even numbers between 0 and N.

Example:

Input N=4 Output: 0 2 4

'''

# Data input section

n = int(input("Enter the number: "))

# Variable initializations

to_print = 0
counter = 0

# Processing

if n > 0:
    while to_print <= n:
        print(to_print, end=" | ")
        counter += 1
        to_print = counter * 2                        # The % sign returns only the remainder of the division.
else:
    print("The number must be positive.")

# Any subprocesses of Processing

# Output section
