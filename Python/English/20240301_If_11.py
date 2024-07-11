n1 = int(input('Enter the first number: '))
n2 = int(input('Enter the second number: '))
n3 = int(input('Enter the third number: '))

# Assume n1 is the smallest initially
smallest = n1

# Check if n2 or n3 is smaller than current smallest
if n2 < n1 and n2 < n3:
    smallest = n2
if n3 < n1 and n3 < n2:
    smallest = n3

# Assume n1 is the largest initially
largest = n1

# Check if n2 or n3 is larger than current largest
if n2 > n1 and n2 > n3:
    largest = n2
if n3 > n2 and n3 > n1:
    largest = n3

print('The smallest number is {}.'.format(smallest))
print('The largest number is {}.'.format(largest))
