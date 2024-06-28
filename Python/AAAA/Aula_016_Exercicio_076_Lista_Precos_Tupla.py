listagem = ('Lápis', 1.75,
            'Borracha', 2,
            'Caderno', 15.9,
            'Estojo', 25,
            'Transferidor', 4.2,
            'Compasso', 9.99,
            'Mochila', 120.32,
            'Caneta', 22.3,
            'Livro', 34.9)
total = 0
print('-' * 40)
print(f'{"Listagem de Preços":^40}')
print('-' * 40)
for posicao in range(0, len(listagem)):
    if posicao % 2 == 0:
        print(f'{listagem[posicao]:.<28}', end='')
    elif posicao % 2 == 1:
        print(f'R$ {listagem[posicao]:>9.2f}')
        total += listagem[posicao]
print('=' * 40)
print(f'{"TOTAL":.<28}R$ {total:>9.2f}')
print('=' * 40)
