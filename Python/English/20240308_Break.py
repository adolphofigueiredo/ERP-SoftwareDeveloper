n = s = 0
while True:
    n = int(input('Enter a number: '))
    if n == 999:
        break
    s += n
print('The sum of all the numbers is {}.'.format(s))
print(f'The sum of all the numbers is {s}.')
