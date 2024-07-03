n1 = float(input('Enter the first grade: '))
n2 = float(input('Enter the second grade: '))
average = (n1 + n2) / 2
print('Your average is {:.1f}.'.format(average))
if average >= 6.0:
    print('Your average is good! Congratulations!')
else:
    print('Be careful! You need to study more!')
