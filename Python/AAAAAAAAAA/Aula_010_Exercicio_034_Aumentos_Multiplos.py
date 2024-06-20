salario = float(input('Qual é o salário do funcionário? R$ '))
if salario > 1250:
    aumento = salario * (1 + 0.10)
if salario <= 1250:
    aumento = salario * (1 + 0.15)
print ('O funcionário terá um aumento de R$ {:.2f}, o que totalizará\n'
       'um valor de R$ {:.2f}.'.format((aumento - salario),aumento))