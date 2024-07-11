option = 'S'
average = total = count = highest = lowest = 0
while option != 'N':
    num = float(input('Enter a number: '))
    total += num
    count += 1
    if count == 1:
        highest = lowest = num
    else:
        if num > highest:
            highest = num
        if num < lowest:
            lowest = num
    option = str(input('Do you want to continue? [S/N] ')).upper().strip()[0]
average = total / count
print('You entered {} numbers and the average is {}.'.format(count, average))
print('The highest value entered is {} and the lowest is {}.'.format(highest, lowest))
