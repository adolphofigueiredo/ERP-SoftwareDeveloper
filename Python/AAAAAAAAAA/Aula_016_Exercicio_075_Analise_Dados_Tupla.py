lista = (int(input('Digite um número: ')),
         int(input('Digite outro número: ')),
         int(input('Digite mais um número: ')),
         int(input('Digite o último número: ')))
print(f'Você digitou os números: {lista}')
if lista.count(9) > 0:
    print(f'O valor 9 apareceu {lista.count(9)} vezes.')
if 3 in lista:
    print(f'O valor 3 apareceu na {lista.index(3) + 1}° posição.')
else:
    print('O número 3 não foi digitado em nenhuma posição.')
print('Os números pares são: ', end="")
for num in lista:
    if num % 2 == 0:
        print(num, end=' ')
