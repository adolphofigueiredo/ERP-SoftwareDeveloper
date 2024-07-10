n1 = float(input('Enter the first grade: '))
n2 = float(input('Enter the second grade: '))
media = (n1 + n2) / 2
print('If the first grade is {:.2f} and the second grade is {:.2f}, your average '
      'is {:.2f}.'.format(n1, n2, media))
if media < 5:
    print('You are \033[1;31mfailed\033[m.'.format())
elif 7 > media >= 5:
    print('You are in \033[1;33mrecovery\033[m.'.format())
elif media >= 7:
    print('You are \033[1;34mpassed\033[m.'.format())
