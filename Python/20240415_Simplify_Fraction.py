'''
Author: Adolpho Silverio Figueiredo Neto
Date: 15/04/2024

Fourth Exercise (Optional)
Create a function that, given two integers representing the numerator and denominator of a fraction, reduces the fraction to its lowest terms.
Then create a program that reads two fractions, reduces them to their lowest terms, and checks if they have the same denominator.

Suggestion: search the web for an algorithm to simplify a fraction to its lowest terms or an algorithm to calculate the GCD of two numbers.
'''

def GCD(x, y):
    '''This function calculates the greatest common divisor (GCD) of two numbers using Euclid's algorithm.
    The algorithm is iterative and involves successive divisions until the remainder of the division becomes zero.
    The last non-zero divisor is the GCD.'''
    
    while y:                           
        x, y = y, x % y
        '''
        It is the same as writing:
        while y != 0:
            temp = x
            x = y
            y = temp % y
        '''
    return x

def simplify_fraction(numerator, denominator):
    '''This function receives the numerator and denominator of a fraction as input.
    We calculate the GCD of the two numbers using the GCD function.
    Then, we divide both the numerator and the denominator by the GCD to simplify the fraction.
    We return the simplified numerator and denominator.'''
    common_divisor = GCD(numerator, denominator)
    return numerator // common_divisor, denominator // common_divisor

# Variable Initializations

numerator1 = 0
denominator1 = 0
numerator2 = 0
denominator2 = 0

# Input Data Section

while numerator1 == 0:
    numerator1 = int(input("Enter the first numerator: "))

while denominator1 == 0:
    denominator1 = int(input("Enter the first denominator: "))

while numerator2 == 0:
    numerator2 = int(input("Enter the second numerator: "))

while denominator2 == 0:
    denominator2 = int(input("Enter the second denominator: "))

# Processing

simplified_numerator1, simplified_denominator1 = simplify_fraction(numerator1, denominator1)
simplified_numerator2, simplified_denominator2 = simplify_fraction(numerator2, denominator2)

# Output Section

print(f"\nThe simplified fraction 1 is {simplified_numerator1}/{simplified_denominator1}.")
print(f"\nThe simplified fraction 2 is {simplified_numerator2}/{simplified_denominator2}.")

if simplified_denominator1 == simplified_denominator2:
    print("\nBoth fractions have the same denominator.\n")
else:
    print("\nThe two fractions have different denominators.\n")
