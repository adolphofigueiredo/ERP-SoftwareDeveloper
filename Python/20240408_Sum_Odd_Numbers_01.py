'''

Author: Adolpho Silverio Figueiredo Neto
Date: 08/04/2024

First Exercise

Write a function that, given two integers x and y, calculates the sum of all odd numbers
between x and y. Construct a program that calls this function n times on n
different intervals (n given as input).
Suggestion: use the pseudorandom number generation function.

'''

import random

# Functions:

# Function: GetTimes
def GetTimes():                                     # Function that asks for the number of times x and y will be generated.
    # Formal parameters:
    n = -1                                          # Variable created to enter the loop.
    while n <= 0:                                   # Condition created to ensure n is positive.
        n = int(input("How many times do you want to do the calculations? "))
    # Return value:
    return n                                        # Return the variable to the calling program.


# Function: GenerateNumbers
def GenerateNumbers():                              # Function created to generate x and y.
    # Formal parameters:
    x = int(random.randrange(1000))                 # Formula that generates x.
    y = int(random.randrange(1000) + x + 1)         # Formula that generates y and ensures it is greater than x.
    # Return value:
    return x, y                                     # Return the variables to the calling program.


# Function: SumOdd
def SumOdd(Min, Max):                               # Function created to calculate the sum of all odd numbers between x and y.
    sum_value = 0                                   # Initialization of the sum variable.
    # Formal parameters:
    while Min <= Max:                               # Loop created to ensure that the minimum is less than the maximum.
        if Min % 2 != 0:                            # Function created to check if the number is odd.
            sum_value += Min                        # Addition to the accumulator when the condition is met.
        Min += 1                                    # Accumulator created to increase the minimum to the maximum.
    # Return value:
    return sum_value                                # Return the variable to the calling program.


# Processing

times = GetTimes()                                  # Activation of the GetTimes function.

for _ in range(1, times + 1):                       # Loop created to generate x and y the requested number of times.
    Min, Max = GenerateNumbers()                    # Activation of the function that generates x and y.
    sum_value = SumOdd(Min, Max)                    # Activation of the function that sums all odd numbers between x and y.
    print("\nx =", Min, "\ny =", Max, "\nSum =", sum_value)  # Print the results.

print("\n")
