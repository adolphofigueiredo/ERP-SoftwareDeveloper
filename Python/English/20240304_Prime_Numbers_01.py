number = int(input('Enter a number: '))
div_count = 0
for c in range(1, number + 1):
    if number % c == 0:
        print('\033[1;34m', end='')  # Blue for divisible numbers
        div_count += 1
    else:
        print('\033[1;31m', end='')  # Red for non-divisible numbers
    print('{} '.format(c), end='')
print('\n\033[mThe number {} was divisible by {} numbers.'.format(number, div_count))
if div_count == 2:
    print('Therefore, this number\033[1;34m is prime\033[m.')
else:
    print('Therefore, this number\033[1;31m is not prime\033[m.')
