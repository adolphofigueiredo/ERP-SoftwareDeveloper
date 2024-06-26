from math import sqrt, ceil, floor

# Input section
num = int(input('Enter a number: '))  # Prompts the user to enter a number and converts the input to an integer.

# Processing section
raiz = sqrt(num)  # Calculates the square root of the entered number.

# Output section
print('The square root of {} is {}.'.format(num, raiz))  # Prints the square root without specific formatting.
print('The square root of {} is {:.2f}.'.format(num, raiz))  # Prints the square root with two decimal places.
print('The square root of {} is {}.'.format(num, ceil(raiz)))  # Prints the square root rounded up.
print('The square root of {} is {}.'.format(num, floor(raiz)))  # Prints the square root rounded down.
