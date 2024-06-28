print('='*75)
print('{:^75}'.format('10 Termos de uma Progressão Aritimética'))
print('='*75)
termo = int(input('Primeiro termo: '))
razao = int(input('Razão: '))
decimo = termo + ( 10 * razao )
for c in range(termo, decimo, razao):
    print('{} -> '.format(c),end='')
print('Acabou')
