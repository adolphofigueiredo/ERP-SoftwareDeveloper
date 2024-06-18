n1 = float(input('Enter the first grade: '))
n2 = float(input('Enter the second grade: '))
n = (n1 + n2) / 2
print('Your average is {:.1f}.'.format(n))
if n >= 6.0:
    print('Your average was good! Congratulations!')
else:
    print('Careful! You need to study more!')
