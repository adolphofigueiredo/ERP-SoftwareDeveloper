'''

Author: Adolpho Silverio Figueiredo Neto
Date: 04/03/2024

Fourth Exercise
Input two real numbers A and B and a sequence of real numbers that ends with
the value 0. The output should be the sum of only the numbers between A and B (inclusive).
example:
Input: A: 3.5 B: 10 sequence: 4.0 15.4 9.3 23.72 0
Output: sum: 4.0 + 9.3 = 13.3

'''

# Data Input Section

A = float(input("Enter the first number (A): "))
B = float(input("Enter the second number (B): "))
sum_numbers = 0
num = None

# Processing

while True:
    num = float(input("Enter a number (enter 0 to stop): "))
    if num == 0:
        break
    if A <= num <= B or A >= num >= B:
        sum_numbers += num

# Output Section
        
print("The sum of the numbers between {} and {} is {}.".format(A, B, sum_numbers))
