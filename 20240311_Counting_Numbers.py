'''

Author: Adolpho Silverio Figueiredo Neto
Date: 11/03/2024

Exercise: Counting Numbers
Given N numbers, count how many are positive, negative, and equal to zero.

'''

# Input Section

# Variable Initialization

choice = "y"
counter = 0
zero_count = 0
positive_count = 0
negative_count = 0

# Processing

while choice.lower() == "y": 
    counter += 1
    num = int(input("\nEnter number {}: ".format(counter)))
    if num == 0:
        zero_count += 1
    elif num > 0:
        positive_count += 1
    elif num < 0:
        negative_count += 1
    choice = input("\nDo you want to enter another number? \nY - Yes \nN - No\n")

# Output Section

print("\nYou have entered:\n{} positive numbers\n{} negative numbers\n{} zeros.\n".format(positive_count, negative_count, zero_count))
