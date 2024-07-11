print('-' * 70)
print('{:^70}'.format('Arithmetic Progression'))
print('-' * 70)
term = float(input('First term: '))
ratio = float(input('Ratio: '))
ap = term
count = 1
size = 0
addition = 10
while addition != 0:
    size = size + addition
    while count <= size:
        print('{}'.format(ap), end='')
        if count < size:
            print(' , ', end='')
        elif count == size:
            print('')
        ap += ratio
        count += 1
    addition = int(input('How many terms do you want to add? '))
print('Progression ended with {} terms presented.'.format(size))
print('-' * 70)
print('{:^70}'.format('End'))
print('-' * 70)
