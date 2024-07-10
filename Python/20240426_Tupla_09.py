numbers = (int(input('Enter a number: ')),
           int(input('Enter another number: ')),
           int(input('Enter one more number: ')),
           int(input('Enter the last number: ')))

print(f'You entered the numbers: {numbers}')

# Count and display occurrences of 9
if numbers.count(9) > 0:
    print(f'The number 9 appeared {numbers.count(9)} times.')

# Check and display the position of the first occurrence of 3
if 3 in numbers:
    print(f'The number 3 appeared in the {numbers.index(3) + 1}° position.')
else:
    print('The number 3 was not entered in any position.')

# Display even numbers
print('The even numbers are: ', end="")
for num in numbers:
    if num % 2 == 0:
        print(num, end=' ')
