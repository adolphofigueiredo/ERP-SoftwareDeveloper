print('-' * 70)
print('{:^70}'.format('Sequência de Fibonacci'))
print('-' * 70)
n = 0
adicao = float(input('Quantos termos você deseja mostrar? '))
cont = 2
f1 = 0
f2 = 1
print('{} {} '.format(f1, f2), end="")
while adicao != 0:
    n = n + adicao
    while cont < n:
        f3 = f1 + f2
        cont += 1
        print('{} '.format(f3), end="")
        f1 = f2
        f2 = f3
    adicao = int(input('\nQuantos termos você deseja adicionar? '))
print('A sequência foi encerrada depois de apresentar {:.0f} termos.'.format(n))
print('-' * 70)
print('{:^70}'.format('Fim'))
print('-' * 70)
