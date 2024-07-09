sum_values = 0
count = 0
for c in range(1, 501, 2):
    if c % 3 == 0:
        sum_values += c  # This is the same as writing sum_values = sum_values + c
        count += 1  # This is the same as writing count = count + 1
        print('{} '.format(c), end='')
print('\nThe sum of all {} values is {}'.format(count, sum_values))
