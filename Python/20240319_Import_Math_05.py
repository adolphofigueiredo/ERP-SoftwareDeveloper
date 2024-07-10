from math import factorial

print('-' * 30)
print('{:^30}'.format('Factorial Calculation'))
print('-' * 30)

number = float(input('Enter a number: '))
result = factorial(int(number))
multiplication = number

print('The result of {:.0f}! is:'.format(number))

while multiplication >= 1:
    print('{:.0f}'.format(multiplication), end='')
    print(' x ' if multiplication > 1 else ' = ', end='')
    multiplication -= 1

print('{}'.format(result))
