velocidade = float(input('What is the vehicle speed: '))

if velocidade > 80:
    print('You have exceeded the speed limit of 80 km/h and have been fined.\n'
          'The fine amount is R$ {:.2f}.'
          .format((velocidade - 80.00) * 7.00))
else:
    print('Congratulations! You are within the speed limit of 80 km/h.')
print('Have a nice day and drive safely!')
