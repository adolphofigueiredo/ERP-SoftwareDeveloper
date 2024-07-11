'''

Author: Adolpho Silverio Figueiredo Neto
Date: 11/03/2024

Exercise: Counting the Highest Value
Given N numbers, determine the highest value and how many times it occurs.

Example

Input N = 5 Numbers: { 10, 12, 2, 12, 2 }
Output: 12 2

'''
# Input Section

n = int(input("Enter the number of data to input: "))
while n <= 0:
    n = int(input("\nThe number must be positive!\n\nEnter the number of data to input: "))

counter = 1
max_occurrences = 0

num = int(input("\nEnter data {}: ".format(counter)))

# Variable Initialization

max_occurrences += 1
max_value = num

# Processing

for x in range(1, n):
    counter += 1
    num = int(input("\nEnter data {}: ".format(counter)))
    if num == max_value:
        max_occurrences += 1
    elif num > max_value:
        max_occurrences = 1
        max_value = num

# Output Section

if max_occurrences == 1:
    print("\nThe highest value is {} and it occurs {} time.\n".format(max_value, max_occurrences))
else:
    print("\nThe highest value is {} and it occurs {} times.\n".format(max_value, max_occurrences))
