velocidade = float(input('Qual a velocidade do veículo: '))

if velocidade > 80:
    print('Você excedeu o limite de velocidade que é de 80 Km/h e foi multado.\n'
          'O valor a ser pago é de R$ {:.2f}.'
          .format((velocidade - 80.00) * 7.00))
else:
    print('Parabéns! Você está dentro do limite de velocidade de 80 Km/h.')
print('Tenha um bom dia e dirija com segurança!')