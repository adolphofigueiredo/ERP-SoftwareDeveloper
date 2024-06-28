'''

Author: Adolpho Silverio Figueiredo Neto
Date: 08/04/2024

Second Exercise

Read a sequence of numbers. Terminate the reading when an odd number is encountered.
Print how many numbers were read and how many of them were non-zero.

Example: INPUT: 4 0 6 10 6 0 5
OUTPUT: Numbers read: 6 Non-zero numbers: 4

'''

# Functions:

# Function: read_numbers
def read_numbers():                                # Function that reads numbers.
    # Formal parameters:
    test = 0                                       # Initialization of the variable to be tested.
    even_count = 0                                 # Initialization of the accumulator that counts the number of tests with even numbers.
    total_count = 0                                # Initialization of the accumulator that counts the number of tests.
    while (test % 2) == 0:                         # Loop created to ensure the test is even.
        test = int(input("\nEnter a number: "))
        if (test % 2) == 0:                        # Condition created to check if the number is even.
            total_count += 1                       # Counter created to count how many times numbers were read.
            if test != 0:                          # Condition created to check if the number is zero.
                even_count += 1                    # Counter created to count how many times even numbers were entered.
    # Return value:
    return total_count, even_count                 # Return the variables to the calling program.


# Variable initializations

# Processing

total_count, even_count = read_numbers()           # Activation of the read_numbers function.

# Output section

print("\nNumbers read: {}\nNon-zero numbers: {}\n".format(total_count, even_count))  # Print the results.
