print('-' * 70)
print('{:^70}'.format('Fibonacci Sequence'))
print('-' * 70)

n = 0
addition = float(input('How many terms do you want to display? '))
count = 2
f1 = 0
f2 = 1

print('{} {} '.format(f1, f2), end="")

while addition != 0:
    n = n + addition
    while count < n:
        f3 = f1 + f2
        count += 1
        print('{} '.format(f3), end="")
        f1 = f2
        f2 = f3
    addition = int(input('\nHow many terms do you want to add? '))

print('The sequence was terminated after displaying {:.0f} terms.'.format(n))

print('-' * 70)
print('{:^70}'.format('End'))
print('-' * 70)
