n = s = 0
while True:
    n = int(input('Digite um número: '))
    if n == 999:
        break
    s += n
print('A soma de todos os números é {}.'.format(s))
print(f'A soma de todos os números é {s}.')
