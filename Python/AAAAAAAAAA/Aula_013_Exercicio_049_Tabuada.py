numero = int(input('Digite o número da tabuada: '))
contador = -1
print('A tabuada de {} é:'.format(numero))
for tabuada in range(0, numero * 11, numero):
    if tabuada <= numero * 10:
        contador += 1
        print('{:^3} x  {:^3} = {:^3}'.format(numero, contador, tabuada))

# ou

print('A tabuada de {} é:'.format(numero))
for c in range(0, 11):
    print('{:^3} x  {:^3} = {:^3}'.format(numero, c, numero * c))


