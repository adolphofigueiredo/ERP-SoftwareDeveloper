'''
Author: Adolpho Silverio Figueiredo Neto
Date: 15/03/2024

Exercise: Insurance Recalculation
Given N car insurances defined as a pair (amount, accident), where accident is 0 if there was no accident or 1 if there was at least one accident. 
Each amount is increased by 10% if there was an accident, otherwise it is discounted by 6%. Calculate the sum of the amounts and print the result.
'''

# Data Input Section

n = int(input("Enter the number of insurances: "))
while n <= 0:
    n = int(input("\nThe number must be positive!\n\nEnter the number of insurances: "))

# Variable Initializations

total = 0
counter = 0

# Processing

while counter < n:
    counter += 1
    valid_input = True
    amount = int(input("\nEnter amount {}: ".format(counter)))
    while amount <= 0:
        amount = int(input("\nThe number must be positive!\n\nEnter amount {}: ".format(counter)))                
    while valid_input:
        accident = input("\nChoose an option:\n0 - No accident\n1 - At least one accident\n")
        match accident:
            case "0":
                final_amount = amount * 0.94
                total += final_amount
                valid_input = False
            case "1":
                final_amount = amount * 1.1
                total += final_amount
                valid_input = False
            case _:
                print("\nSelect a valid option!\n")

# Any sub-processes of Processing

# Output Section

print("\nThe total amount is {}.\n".format(total))
