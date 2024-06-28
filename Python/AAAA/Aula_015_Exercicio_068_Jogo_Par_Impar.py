from random import randint

print('-' * 50)
print('{:^50}'.format('Jogo do Par ou Ímpar'))
print('-' * 50)
vitoria = 0
while True:
    opcao = ' '
    jogador = int(input('Digite um número: '))
    computador = randint(0, 10)
    total = jogador + computador
    resultado = total % 2
    while opcao not in 'PpIi':
        opcao = str(input('Par ou Ímpar? [P/I] ')).strip().upper()[0]
    print('-' * 50)
    print(f'Você jogou {jogador} e o computador jogou {computador},'
          f' totalizando {total}.')
    if opcao == 'P':
        if resultado == 0:
            print('O total deu par, você venceu!')
            vitoria += 1
        elif resultado == 1:
            print('O total deu ímpar, você perdeu!')
            print('-' * 50)
            break
    elif opcao == 'I':
        if resultado == 0:
            print('O total deu par, você perdeu!')
            print('-' * 50)
            break
        elif resultado == 1:
            print('O total deu ímpar, você venceu!')
            vitoria += 1
    print('-' * 50)
print(f'Game Over! Você venceu {vitoria} vezes!')
print('-' * 50)
