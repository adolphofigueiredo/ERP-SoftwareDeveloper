from time import sleep
n1 = float(input('Insira o primeiro número: '))
n2 = float(input('Insira o segundo número: '))
opcao = 6
maior = 0
menor = 0
while opcao != 5:
    print('-' * 40)
    print('Por favor selecione a opção desejada:')
    print('-' * 40)
    print('''[1] Somar os números
[2] Multiplicar os números
[3] Maior número
[4] Inserir novos números
[5] Sair do programa''')
    print('-' * 40)
    opcao = int(input('Qual a sua opção? '))
    print('-' * 40)
    if opcao == 1:
        soma = n1 + n2
        print('A soma dos números {} e {} é {}.'.format(n1, n2, soma))
    elif opcao == 2:
        multiplicacao = n1 * n2
        print('A multiplicação entre os números {} e {} é {}.'
              .format(n1, n2, multiplicacao))
    elif opcao == 3:
        if n1 < n2:
            maior = n2
            menor = n1
        elif n1 > n2:
            maior = n1
            menor = n2
        print('O maior número é {} e o menor número é {}.'.format(maior, menor))
    elif opcao == 4:
        n1 = float(input('Insira o primeiro número: '))
        n2 = float(input('Insira o segundo número: '))
    elif opcao != 1 and opcao != 2 and opcao != 3 and opcao != 4 and opcao != 5:
        print('Opção inválida!')
    sleep(2)
print('{:.^40}'.format('Finalizando'))
sleep(1)
print('\n')
print('=' * 40)
print('{:^40}'.format('Finalizado com sucesso!'))
print('=' * 40)
