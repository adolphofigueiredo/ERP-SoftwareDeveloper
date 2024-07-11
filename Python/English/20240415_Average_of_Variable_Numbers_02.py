def product(*numbers):
    result = 1                             # Initialize the product result.
    positive_count = 0                     # Count the number of positive numbers.

    # Process each number provided as an argument:
    for val in numbers:                    # Iterate over each number passed to the function.
        if val > 0:                        # Check if the number is positive.
            result *= val                  # Multiply the result by the positive number.
            positive_count += 1            # Increment the count of positive numbers.

    # Return value:
    if positive_count == 0:                # If there are no positive numbers.
        return -1                          # Return -1.
    
    return result                          # Return the product of the positive numbers.

# Testing the function with different inputs:

print("Product 1: ", product(4, 2, 3))       # Test 01
print("Product 2: ", product(1, 1, 1))       # Test 02
print("Product 3: ", product(-4, -5, -6))    # Test 03
print("Product 4: ", product(4, 5, -6))      # Test 04
print("Product 5: ", product(2, -5, 6))      # Test 05
print("Product 6: ", product(-4, 5, 6))      # Test 06
print("Product 7: ", product(-4, 5, 6, 2))   # Test 07
print("Product 8: ", product())              # Test 08
print("Product 9: ", product(-5))            # Test 09
print("Product 10: ", product(5))            # Test 10
print("Product 11: ", product(0))            # Test 11
print("Product 12: ", product(0, 3))         # Test 12
print("Product 13: ", product(0, -6, 9))     # Test 13
