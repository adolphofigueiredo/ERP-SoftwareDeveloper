numero = int(input('Digite um número: '))
qtdivisao = 0
for c in range(1, numero + 1):
    if numero % c == 0:
        print('\033[1;34m', end='')
        qtdivisao += 1
    else:
        print('\033[1;31m', end='')
    print('{} '.format(c), end='')
print('\n\033[mO número {} foi divisível por {} números.'
      .format(numero, qtdivisao))
if qtdivisao == 2:
    print('Portanto este número\033[1;34m é primo\033[m.')
else:
    print('Portanto este número\033[1;31m não é primo\033[m.')
