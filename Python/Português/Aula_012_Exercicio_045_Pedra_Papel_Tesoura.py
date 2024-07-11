from random import randint
from time import sleep
item = ('Pedra', 'Papel', 'Tesoura')
cpu = randint(0,2)
print('''Suas opções são:
[ 0 ] Pedra
[ 1 ] Papel
[ 2 ] Tesoura''')
opcao = int(input('Qual é a sua jogada? '))
print('Estou pensando...')
sleep(1)
print('Jo')
sleep(1)
print('Ken')
sleep(1)
print('Po')
sleep(1)
print('-=-' * 10)
print('O computador jogou {}'.format(item[cpu]))
print('Você jogou {}'.format(item[opcao]))
print('-=-' * 10)
if cpu == 0:
    if opcao == 0:
        print('\033[1;30mEmpate!\033[m! Tente novamente!')
    elif opcao == 1:
        print('\033[1;32mGanho!\033[m! Vamos jogar novamente?')
    elif opcao == 2:
        print('\033[1;31mPerdeu!\033[m! Tente Novamente!')
elif cpu == 1:
    if opcao == 0:
        print('\033[1;31mPerdeu!\033[m! Tente Novamente!')
    elif opcao == 1:
        print('\033[1;30mEmpate!\033[m! Tente novamente!')
    elif opcao == 2:
        print('\033[1;32mGanho!\033[m! Vamos jogar novamente?')
elif cpu ==2:
    if opcao == 0:
        print('\033[1;32mGanho!\033[m! Vamos jogar novamente?')
    elif opcao == 1:
        print('\033[1;31mPerdeu!\033[m! Tente Novamente!')
    elif opcao == 2:
        print('\033[1;30mEmpate!\033[m! Tente novamente!')