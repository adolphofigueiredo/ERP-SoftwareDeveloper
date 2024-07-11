'''

Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: Triplet of numbers
Given three numbers A, B, and C, determine if B is strictly between A and C.

'''

A = int(input("Enter the first number (A): "))
B = int(input("Enter the second number (B): "))
C = int(input("Enter the third number (C): "))

if (A < B and B < C) or (A > B and B > C):
    print("B is strictly between A and C.")
else:
    print("B is not strictly between A and C.")
