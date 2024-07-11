'''

Author: Adolpho Silverio Figueiredo Neto
Date: 25/03/2024

Fourth Exercise

Create a function that calculates the product and sum of three integers and returns the
difference between the calculated product and sum.
Use this function in a main program.

'''

# Functions:

# Function: calculate_difference

def calculate_difference(a, b, c):                      # Definition created to calculate the difference between the product and the sum.

    # Formal parameters:

    sum_value = a + b + c                               # Calculation of the sum.
    product_value = a * b * c                           # Calculation of the product.

    # Return value:

    if sum_value <= product_value:                      # Condition created to check if the sum is less than or equal to the product.
        difference = product_value - sum_value          # Calculation of the difference.
    else:
        difference = sum_value - product_value          # Calculation of the difference.
    return difference, product_value, sum_value         # Return the results.

# Data Input Section

num1 = int(input("Enter the first number: "))           # Data request to calculate the product and sum.
while num1 <= 0:                                        # Loop created to ensure the number is positive.
    num1 = int(input("Error - The number must be positive!\nEnter the first number: "))  # Error information and new input request.

num2 = int(input("Enter the second number: "))          # Data request to calculate the product and sum.
while num2 <= 0:                                        # Loop created to ensure the number is positive.
    num2 = int(input("Error - The number must be positive!\nEnter the second number: "))  # Error information and new input request.

num3 = int(input("Enter the third number: "))           # Data request to calculate the product and sum.
while num3 <= 0:                                        # Loop created to ensure the number is positive.
    num3 = int(input("Error - The number must be positive!\nEnter the third number: "))  # Error information and new input request.

# Variable Initialization

# Processing

difference, product_value, sum_value = calculate_difference(num1, num2, num3)  # Using the function that calculates the difference between the product and the sum.

# Any additional processing

# Output Section

if product_value > sum_value:                            # Condition created to check if the product is greater than the sum.
    print("The difference between the product ({}) and the sum ({}) is {}.".format(product_value, sum_value, difference))
elif product_value < sum_value:                          # Condition created to check if the sum is greater than the product.
    print("The difference between the sum ({}) and the product ({}) is {}.".format(sum_value, product_value, difference))
else:                                                    # Condition created to check if the sum is equal to the product.
    print("The sum ({}) and the product ({}) are equal, so the difference is {}.".format(sum_value, product_value, difference))
