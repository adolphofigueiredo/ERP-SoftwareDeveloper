print('=' * 50)
print('{:^50}'.format('DODO Bank'))
print('=' * 50)
saque = int(input('Qual o valor do saque? R$ '))
print('-' * 50)
print(f'Para sacar R$ {saque:.2f} serão necessárias:')
saldo = saque
cedula = 100
cont = 0
while True:
    if saldo >= cedula:
        saldo -= cedula
        cont += 1
    else:
        if cont > 0:
            print(f'{cont:>4} cédulas de R$ {cedula:.2f}.')
        if cedula == 100:
            cedula = 50
        elif cedula == 50:
            cedula = 20
        elif cedula == 20:
            cedula = 10
        elif cedula == 10:
            cedula = 5
        elif cedula == 5:
            cedula = 2
        cont = 0
        if saldo == 0:
            break
print('=' * 50)
print('{:^50}'.format('Agradecemos a preferência!'))
print('=' * 50)
