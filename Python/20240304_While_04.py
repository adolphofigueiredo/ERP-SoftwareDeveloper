n = 1
even_count = odd_count = 0

while n != 0:
    n = int(input('Enter a number: '))
    if n != 0:
        if n % 2 == 0:
            even_count += 1
        else:
            odd_count += 1

print('You entered {} even numbers and {} odd numbers.'.format(even_count, odd_count))
