'''

Author: Adolpho Silverio Figueiredo Neto
Date: 04/03/2024

Third Exercise
Input N bank account balances. The output should be the harmonic average of only the bank accounts
that have a negative balance.
Harmonic average H of n elements x1, x2, …, xn is calculated with the following formula:
example:
Input: N = 4 balances: 1240.5 -200.0 21.0 -2.3
Output: average = 2 / (1/(-200) + 1/(-2.3)) = -4.548

'''

# Data Input Section

choice = "s"
sum_inverse = 0
counter = 0

# Processing

while choice == "s" or choice == "S":
    balance = float(input("\nEnter the bank account balance (€): "))
    if balance < 0:
        counter += 1
        sum_inverse += (1 / balance)
    choice = input("\nDo you want to add another bank account balance?\n\n(s) - Yes\n(n) - No\n\n")

if counter > 0:
    harmonic_average = counter / sum_inverse

    # Output Section
    print("The harmonic average is {}.".format(harmonic_average))
else:
    print("No negative balances were entered.")
