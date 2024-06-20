print('-' * 45)
print('{:^45}'.format('Tabuada'))
while True:
    print('-' * 45)
    num = int(input('Você deseja ver a tabuada de qual valor? '))
    print('-' * 45)
    if num < 0:
        break
    for f in range(0, 11):
        print(f'{num:^4} x {f:^2} = {num * f:^4}')
print('-' * 45)
print(f'{Programa Encerrado com Sucesso:^45}')
print('-' * 45)
