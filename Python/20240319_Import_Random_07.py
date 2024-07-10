from random import randint

# Generate a tuple of 5 random integers between 0 and 10
numbers = (randint(0, 10), randint(0, 10), randint(0, 10),
           randint(0, 10), randint(0, 10))

# Sort the tuple to find the smallest and largest values
sorted_numbers = sorted(numbers)

# Print the original list of random numbers
print('The list is:')
for number in numbers:
    print(number, end=' ')

# Print the sorted list of numbers
print('\nThe sorted list is:')
print(sorted_numbers)

# Print the largest and smallest values in the original list
print(f'The largest randomly generated value was {max(numbers)}.')
print(f'The smallest randomly generated value was {min(numbers)}.')
