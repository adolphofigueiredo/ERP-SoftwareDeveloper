soma = 0
cont = 0
for c in range(1, 7):
    numero = int(input('Enter the {}th number: '.format(c)))
    if numero % 2 == 0:
        soma += numero
        cont += 1
print('You entered {} even numbers and their sum is {}.'.format(cont, soma))
