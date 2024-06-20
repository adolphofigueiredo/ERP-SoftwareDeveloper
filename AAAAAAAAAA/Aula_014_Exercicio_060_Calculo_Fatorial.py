from math import factorial
print('-' * 30)
print('{:^30}'.format('Cálculo de Fatorial'))
print('-' * 30)
numero = float(input('Digite um número: '))
resultado = factorial(numero)
multiplicacao = numero
print('O resultado de {:.0f}! é:'.format(numero))
while multiplicacao >= 1:
    print('{:.0f}'.format(multiplicacao),end='')
    print(' x ' if multiplicacao > 1 else ' = ', end='')
    multiplicacao -= 1
print('{}'.format(resultado))
