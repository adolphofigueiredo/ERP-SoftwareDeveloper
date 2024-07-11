'''

Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: Arithmetic progression
The program, given three numbers, determines if they can be considered an arithmetic
progression; an arithmetic progression is a series of numbers in which the difference between two
successive numbers is constant.

Example:

3 5 7 output: arithmetic progression
3 4 8 output: Not in arithmetic progression

'''

A = int(input("Enter the first number: "))
B = int(input("Enter the second number: "))
C = int(input("Enter the third number: "))

if (B - A) == (C - B):
    print("Arithmetic progression!")
else:
    print("Not in arithmetic progression!")
