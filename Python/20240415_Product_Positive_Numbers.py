'''
Author: Adolpho Silverio Figueiredo Neto
Date: 15/04/2024

First Exercise
Write a function that accepts an indefinite number of integer arguments. 
This function should return the product of only the positive numbers. If there are no positive numbers present, 
the function should return -1. Construct a program that calls this function twice, each time with different parameters.
'''

# Function:
def Product(*numbers):
    result = 1                             # Initializes the product result.
    positive_count = 0                     # Counts the number of positive numbers.

    # Formal parameters:
    for val in numbers:                    # Iterates over each number passed to the function.
        if val > 0:                        # Checks if the number is positive.
            result *= val                  # Multiplies the result by the positive number.
            positive_count += 1            # Increments the count of positive numbers.

    # Return value:
    if positive_count == 0:                # If there are no positive numbers.
        return -1                          # Returns -1.
    
    return result                          # Returns the product of the positive numbers.

# Processing

print("Product 1: ", Product(4, 2, 3))      # Test 01
print("Product 2: ", Product(1, 1, 1))      # Test 02
print("Product 3: ", Product(-4, -5, -6))   # Test 03
print("Product 4: ", Product(4, 5, -6))     # Test 04
print("Product 5: ", Product(2, -5, 6))     # Test 05
print("Product 6: ", Product(-4, 5, 6))     # Test 06
print("Product 7: ", Product(-4, 5, 6, 2))  # Test 07
print("Product 8: ", Product())             # Test 08
print("Product 9: ", Product(-5))           # Test 09
print("Product 10: ", Product(5))           # Test 10
print("Product 11: ", Product(0))           # Test 11
print("Product 12: ", Product(0, 3))        # Test 12
print("Product 13: ", Product(0, -6, 9))    # Test 13
