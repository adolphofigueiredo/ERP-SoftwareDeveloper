'''
Author: Adolpho Silverio Figueiredo Neto
Date: 15/04/2024

First Exercise
Write a function that accepts an indeterminate number of integer arguments. This function should return the product of only the positive numbers. If there are no positive numbers, then the function should return the value -1. Build a program that calls this function twice each time with different parameters.
'''

# Function:
def Product(*numbers):
    result = 1                             # Accumulator created to reach the result.
    counter = 0                            # Counter of the number of times a number has been tested.
    negative = 0                           # Counter of negative numbers tested.
    # Formal parameters:
    for val in numbers:                    # Condition created to calculate with a variable number of arguments.
        counter += 1
        if val >= 0:                       # Condition created to check if the number is greater than zero.
            result *= val                  # Calculation of the new result.
    # Return value:
        elif val < 0:                      # Condition created to check if the number is less than zero.
            negative += 1
    if counter == negative:                # Condition created to check if the number of negative numbers is equal to the total number of numbers.
        result = -1
    return result

# Processing

print("Product: ", Product(4, 2, 3))       # Test 01
print("Product: ", Product(1, 1, 1))       # Test 02
print("Product: ", Product(-4, -5, -6))    # Test 03
print("Product: ", Product(4, 5, -6))      # Test 04
print("Product: ", Product(2, -5, 6))      # Test 05
print("Product: ", Product(-4, 5, 6))      # Test 06
print("Product: ", Product(-4, 5, 6, 2))   # Test 07
print("Product: ", Product())              # Test 08
print("Product: ", Product(-5))            # Test 09
print("Product: ", Product(5))             # Test 10
print("Product: ", Product(0))             # Test 11
print("Product: ", Product(0, 3))          # Test 12
print("Product: ", Product(0, -6, 9))      # Test 13

