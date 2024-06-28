'''
Author: Adolpho Silverio Figueiredo Neto
Date: 15/04/2024

Third Exercise
Create a function that, given three money amounts, moves any debts (considering negative amounts as debts) to the first amount. Use default parameters. Create a main program to test the function.

Example:

If the amounts are 5 -1 -2, the amounts after applying the function will be 2 0 0.
If the amounts are -3 4 -2, the amounts after applying the function will be -5 4 0.
If the amounts are 4 -2 -2, the amounts after applying the function will be 0 0 0.
If the amounts are 6 -4 -3, the amounts after applying the function will be -1 0 0.
'''

def InsertDebt():
    x1 = int(input("Insert the first debt: "))
    x2 = int(input("Insert the second debt: "))
    x3 = int(input("Insert the third debt: "))
    return x1, x2, x3

def debtfirst(x1, x2, x3):
    if x1 >= 0 and x2 >= 0 and x3 >= 0:
        r1 = x1
        r2 = x2
        r3 = x3
    elif x2 < 0 and x3 < 0:
        r1 = x1 + x2 + x3
        r2 = 0
        r3 = 0
    elif x2 < 0:
        r1 = x1 + x2
        r2 = 0
        r3 = x3
    elif x3 < 0:
        r1 = x1 + x3
        r2 = x2
        r3 = 0

    return r1, r2, r3

x1, x2, x3 = InsertDebt()

r1, r2, r3 = debtfirst(x1, x2, x3)

print("Amount: ", r1, " ", r2, " ", r3, " ")
