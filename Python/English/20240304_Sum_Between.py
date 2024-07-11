'''

Author: Adolpho Silverio Figueiredo Neto
Date: 03/04/2024

Fourth Exercise
Given two real numbers A and B as input and a sequence of real numbers that ends with
the value 0, the goal is to output the sum of only the numbers between A and B.
Example:
Input: A: 3.5 B: 10 sequence: 4.0 15.4 9.3 23.72 0
Output: sum: 4.0 + 9.3 = 13.3

'''

# Input Section

numA = float(input("Enter the first number (A): "))
numB = float(input("Enter the second number (B): "))
numS = float
sum_total = 0

# Processing

while True:
    numS = float(input("Enter a number: "))
    if numS == 0:
        break
    if (numA <= numS <= numB) or (numB <= numS <= numA):
        sum_total += numS

# Output Section

print("The sum of the numbers between {} and {} is {}.".format(numA, numB, sum_total))
