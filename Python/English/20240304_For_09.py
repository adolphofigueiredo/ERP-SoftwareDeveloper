print('=' * 75)
print('{:^75}'.format('10 Terms of an Arithmetic Progression'))
print('=' * 75)
first_term = int(input('First term: '))
difference = int(input('Difference: '))
tenth = first_term + (10 * difference)
for c in range(first_term, tenth, difference):
    print('{} -> '.format(c), end='')
print('Done')
