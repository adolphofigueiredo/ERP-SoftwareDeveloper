print('-' * 45)
print('{:^45}'.format('Multiplication Table'))
while True:
    print('-' * 45)
    num = int(input('Which value would you like to see the multiplication table for? '))
    print('-' * 45)
    if num < 0:
        break
    for f in range(0, 11):
        print(f'{num:^4} x {f:^2} = {num * f:^4}')
print('-' * 45)
print(f'{"Program Successfully Ended":^45}')
print('-' * 45)
