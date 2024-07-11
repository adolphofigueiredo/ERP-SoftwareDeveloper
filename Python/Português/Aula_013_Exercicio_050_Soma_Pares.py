soma = 0
cont = 0
for c in range(1, 7):
    numero = int(input('Digite o {}° número: '.format(c)))
    if numero % 2 == 0:
        soma += numero
        cont += 1
print('Você informou {} números pares e a soma é {}.'.format(cont,soma))
