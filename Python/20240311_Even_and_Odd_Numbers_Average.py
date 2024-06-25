'''

Author: Adolpho Silverio Figueiredo Neto
Date: 11/03/2024

Exercise: Average of Even and Odd Numbers
Given N numbers, calculate the arithmetic average of even values and odd values separately.

'''

# Input Section

n = int(input("Enter the number of data to input: "))
while n <= 0:
    n = int(input("\nThe number must be positive!\n\nEnter the number of data to input: "))

# Variable Initialization

even_count = 0
even_average = 0
even_accumulator = 0
odd_count = 0
odd_average = 0
odd_accumulator = 0
counter = 1

# Processing

while counter <= n:
    num = int(input("\nEnter data {}: ".format(counter)))
    if num % 2 == 0:
        even_count += 1
        even_accumulator += num
    else:
        odd_count += 1
        odd_accumulator += num
    counter += 1

if even_count > 0:
    even_average = even_accumulator / even_count

if odd_count > 0:
    odd_average = odd_accumulator / odd_count

# Output Section

print("\nThere are", even_count, "even numbers and the average is", even_average)
print("\nThere are", odd_count, "odd numbers and the average is", odd_average, "\n")
