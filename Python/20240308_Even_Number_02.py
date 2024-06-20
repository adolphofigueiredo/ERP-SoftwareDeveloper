'''

Author: Adolpho Silverio Figueiredo Neto
Date: 03/08/2024

Exercise: Even numbers (2)
Input a number N. Print the ten even numbers following the number N.

'''

# Input Data Section

num = int(input("\nEnter the number: "))
accumulator = num

# Variable Initializations
# Processing

print("\nThe ten even numbers following {} are: \n".format(num))

if num % 2 == 0:                               # even numbers
    for counter in range(1, 11):
        accumulator = accumulator + 2
        print(accumulator, end=" | ")
else:                                          # odd numbers
    accumulator = accumulator + 1
    for counter in range(1, 11):
        print(accumulator, end=" | ")
        accumulator = accumulator + 2


# Any subprocesses of Processing
# Output Section
