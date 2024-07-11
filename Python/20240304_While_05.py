num = count = sum = 0
num = int(input('Enter a number [999 to stop]: '))
while num != 999:
    count += 1
    sum += num
    num = int(input('Enter a number [999 to stop]: '))
print('You entered {} numbers and the sum of them is {}.'.format(count, sum))
