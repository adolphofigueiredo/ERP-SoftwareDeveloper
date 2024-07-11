from math import trunc

num = float(input('Enter a number: '))
print('The number {} has the integer part {}.'.format(num, trunc(num)))
print('The number {} has the integer part {}.'.format(num, int(num)))
