soma = 0
cont = 0
for c in range(1, 501, 2):
    if c % 3 == 0:
        soma += c  # É a mesma coisa que escrever isso soma = soma + c
        cont += 1  # É a mesma coisa que escrever isso cont = cont + 1
        print('{} '.format(c), end='')
print('\nA soma de todos os {} valores é {}'.format(cont, soma))
