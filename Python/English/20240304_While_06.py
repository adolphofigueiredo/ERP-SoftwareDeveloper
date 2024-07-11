count = sum = 0
while True:
    num = float(input('Enter a value [999 to stop]: '))
    if num == 999:
        break
    sum += num
    count += 1
print(f'The sum of the {count} values is {sum}.')
