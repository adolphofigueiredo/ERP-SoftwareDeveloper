# Input values
n1 = int(input('Enter a value: '))
n2 = int(input('Enter another value: '))

# Calculations
s = n1 + n2
sb = n1 - n2
m = n1 * n2
d = n1 / n2
di = n1 // n2
e = n1 ** n2

# Output with formatted strings
print('The sum is {}.'.format(n1 + n2), end=' >>> ')
print('The sum is {}.'.format(s), end=' >>> ')
print('The subtraction is {}.'.format(sb))
print('The multiplication is {}.'.format(m), end=' ')
print('The division is {:.4f}.'.format(d), end=' ')
print('The integer division is {}.'.format(di))
print('The exponentiation is {}.'.format(e))

# Output with new lines
print('The sum is\n{}.'.format(n1 + n2))
print('The sum is\n{}.'.format(s))
print('The subtraction is\n{}.'.format(sb))
print('The multiplication is\n{}.'.format(m))
print('The division is\n{:.4f}.'.format(d))
print('The integer division is\n{}.'.format(di))
print('The exponentiation is\n{}.'.format(e))
