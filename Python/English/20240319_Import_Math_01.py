import math

# Input Section
num = int(input('Enter a number: '))

# Processing
root = math.sqrt(num)

# Output Section
print('The square root of {} is equal to {}.'.format(num, root))
print('The square root of {} is equal to {:.2f}.'.format(num, root))
print('The square root of {} is equal to {}.'.format(num, math.ceil(root)))
print('The square root of {} is equal to {}.'.format(num, math.floor(root)))
