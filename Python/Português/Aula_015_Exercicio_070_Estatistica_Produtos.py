print('-' * 60)
print('{:^60}'.format('Loja DODO'))
print('-' * 60)
total = cont = menor = maior = 0
produtomaior = produtomenor = ' '
while True:
    opcao = ' '
    produto = str(input('Produto: '))
    preco = float(input('Preço: R$ '))
    total += preco
    cont += 1
    if cont == 1:
        maior = menor = preco
        produtomaior = produtomenor = produto
    elif cont > 1:
        if preco > maior:
            maior = preco
            produtomaior = produto
        elif preco < menor:
            menor = preco
            produtomenor = produto
    while opcao not in 'SsNn':
        opcao = str(input('Quer continuar? [S/N] ')).upper().strip()[0]
        print('-' * 60)
    if opcao == 'N':
        break
print(f'Você comprou {cont} produtos e o total da compra foi R$ {total:.2f}.')
print(f'O produto mais caro é o {produtomaior} e custou R$ {maior:.2f}.')
print(f'O produto mais barato é o {produtomenor} e custou R$ {menor:.2f}.')
print('-' * 60)
print('{:^60}'.format('Programa Encerrado com Sucesso'))
print('-' * 60)
