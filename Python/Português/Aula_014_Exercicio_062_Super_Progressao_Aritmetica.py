print('-' * 70)
print('{:^70}'.format('Progressão Aritimpetica'))
print('-' * 70)
termo = float(input('Primeiro termo: '))
razao = float(input('Razão: '))
pa = termo
cont = 1
tamanho = 0
adicao = 10
while adicao != 0:
    tamanho = tamanho + adicao
    while cont <= tamanho:
        print('{}'.format(pa), end='')
        if cont < tamanho:
            print(' , ', end='')
        elif cont == tamanho:
            print('')
        pa += razao
        cont += 1
    adicao = int(input('Quantos termos você deseja adicionar? '))
print('Progressão encerrada com {} termos apresentados.'.format(tamanho))
print('-' * 70)
print('{:^70}'.format('Fim'))
print('-' * 70)
