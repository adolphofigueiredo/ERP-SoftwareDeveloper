opcao = 'S'
media = soma = cont = maior = menor = 0
while opcao != 'N':
    num = float(input('Digite um número: '))
    soma += num
    cont += 1
    if cont == 1:
        maior = menor = num
    else:
        if num > maior:
            maior = num
        if num < menor:
            menor = num
    opcao = str(input('Deseja continuar? [S/N] ')).upper().strip()[0]
media = soma / cont
print('Você digitou {} números e a média entre eles é {}.'.format(cont, media))
print('O maior valor digitado é {} e o menor é {}.'.format(maior, menor))
