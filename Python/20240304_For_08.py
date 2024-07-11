number = int(input('Enter the number for the multiplication table: '))
counter = -1
print('The multiplication table of {} is:'.format(number))
for multiple in range(0, number * 11, number):
    if multiple <= number * 10:
        counter += 1
        print('{:^3} x  {:^3} = {:^3}'.format(number, counter, multiple))

# or

print('The multiplication table of {} is:'.format(number))
for c in range(0, 11):
    print('{:^3} x  {:^3} = {:^3}'.format(number, c, number * c))
