print('{:=^60}'.format('DODO'))
preco = float(input('Preço das compras: R$ '))
print('-=-' * 20)
print('{:^60}'.format('Formas de Pagamento'))
print('-=-' * 20)
print('[ 1 ] à vista em dinheiro ou cheque')
print('[ 2 ] à vista  no cartão')
print('[ 3 ] 2x no cartão')
print('[ 4 ] 3x ou mais no cartão')
opcao = int(input('Qual é a opção? '))
if opcao != 1 and opcao != 2 and opcao != 3 and opcao != 4:
    print('\033[1;31mPor favor selecione uma opçao váida!\033[m')
elif opcao == 1:
    print('A sua compra de R$ {:.2f} e custará R$ {:.2f} no final.'
          .format(preco,preco * 0.9))
elif opcao == 2:
    print('A sua compra de R$ {:.2f} e custará R$ {:.2f} no final.'
          .format(preco,preco * 0.95))
elif opcao == 3:
    print('A sua compra de R$ {:.2f} e custará R$ {:.2f} no final.'
          'Você pagará o valor final em 2x de R$ {:.2f}.'
          .format(preco,preco,preco / 2))
elif opcao == 4:
    print('A sua compra de R$ {:.2f} e custará R$ {:.2f} no final.'
          .format(preco,preco * 1.2))
    parcelas = int(input('Em quantas parcelas você pagará? '))
    print('Você pagará em {}x de R$ {:.2f}.'.format(parcelas,((preco * 1.2) / parcelas)))
