print('-' * 70)
print('{:^70}'.format('Progressão Aritimpetica'))
print('-' * 70)
termo = float(input('Primeiro termo: '))
razao = float(input('Razão: '))
pa = termo
cont = 1
print('( ', end='')
while cont <= 10:
    print('{}'.format(pa), end='')
    print(' , ' if cont < 10 else ' )\n',end='')
    pa += razao
    cont += 1

print('-' * 70)
print('{:^70}'.format('Fim'))
print('-' * 70)
