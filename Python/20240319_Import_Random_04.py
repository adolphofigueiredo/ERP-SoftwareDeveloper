from random import randint
from time import sleep

item = ('Rock', 'Paper', 'Scissors')
cpu = randint(0, 2)
print('''Your options are:
[ 0 ] Rock
[ 1 ] Paper
[ 2 ] Scissors''')
opcao = int(input('What is your move? '))
print('I am thinking...')
sleep(1)
print('Rock')
sleep(1)
print('Paper')
sleep(1)
print('Scissors')
sleep(1)
print('-=-' * 10)
print('The computer played {}'.format(item[cpu]))
print('You played {}'.format(item[opcao]))
print('-=-' * 10)

if cpu == 0:
    if opcao == 0:
        print('\033[1;30mDraw!\033[m Try again!')
    elif opcao == 1:
        print('\033[1;32mYou win!\033[m Want to play again?')
    elif opcao == 2:
        print('\033[1;31mYou lose!\033[m Try again!')
elif cpu == 1:
    if opcao == 0:
        print('\033[1;31mYou lose!\033[m Try again!')
    elif opcao == 1:
        print('\033[1;30mDraw!\033[m Try again!')
    elif opcao == 2:
        print('\033[1;32mYou win!\033[m Want to play again?')
elif cpu == 2:
    if opcao == 0:
        print('\033[1;32mYou win!\033[m Want to play again?')
    elif opcao == 1:
        print('\033[1;31mYou lose!\033[m Try again!')
    elif opcao == 2:
        print('\033[1;30mDraw!\033[m Try again!')
