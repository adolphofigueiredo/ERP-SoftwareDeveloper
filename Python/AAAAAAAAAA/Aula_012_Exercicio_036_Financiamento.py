imovel = float(input('Qual o valor do imóvel? R$ '))
salario = float(input('Qual o valor do salário do comprador? R$ '))
anos = int(input('Em quantos anos deseja pagar o financiamento? '))
parcela = (imovel/(anos * 12))
limite = salario * 0.3
if parcela <= limite:
    print('\033[1;32mParabéns! Seu financiamento foi aprovado!\n'
          'O valor da parcela será de R$ {:.2f}.\033[m'.format(parcela))
else:
    print('\033[1;31mInflezimente o seu financiamento não foi aprvoado.\n'
          'O valor financiado excede o limite possibilitado pela sua renda.'
          '\033[m')
print('Obrigado!')