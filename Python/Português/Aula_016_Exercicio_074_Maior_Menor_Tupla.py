from random import randint

lista = (randint(0, 10), randint(0, 10), randint(0, 10),
         randint(0, 10), randint(0, 10))
menormaior = sorted(lista)
print(f'A lista é:')
for c in lista:
    print(c, end=' ')
print(f'\nA lista ordenada é:')
print(menormaior)
print(f'O maior valor sorteado foi {max(lista)}.')
print(f'O menor valor sorteado foi {min(lista)}.')
