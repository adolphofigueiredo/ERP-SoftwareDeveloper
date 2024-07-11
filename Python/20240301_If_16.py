n1 = int(input('Enter a number: '))
n2 = int(input('Enter another number: '))
if n1 > n2:
    print('The first value is \033[1;34m{}\033[m and is greater than the second'
          ' value which is \033[1;31m{}\033[m.'
          .format(n1, n2))
elif n1 < n2:
    print('The first value is \033[1;31m{}\033[m and is less than the second'
          ' value which is \033[1;34m{}\033[m.'
          .format(n1, n2))
elif n1 == n2:                                   # or just write else:
    print('The first value is \033[1;32m{}\033[m and is equal to the second'
          ' value which is \033[1;32m{}\033[m.'
          .format(n1, n2))
