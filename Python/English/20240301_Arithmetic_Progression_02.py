print('-' * 70)
print('{:^70}'.format('Arithmetic Progression'))
print('-' * 70)
term = float(input('First term: '))
ratio = float(input('Ratio: '))
ap = term
count = 1
print('( ', end='')
while count <= 10:
    print('{}'.format(ap), end='')
    print(' , ' if count < 10 else ' )\n', end='')
    ap += ratio
    count += 1

print('-' * 70)
print('{:^70}'.format('End'))
print('-' * 70)
