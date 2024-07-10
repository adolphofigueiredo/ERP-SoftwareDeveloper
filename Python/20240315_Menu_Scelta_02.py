print('{:=^60}'.format('DODO'))
price = float(input('Purchase price: $ '))
print('-=-' * 20)
print('{:^60}'.format('Payment Methods'))
print('-=-' * 20)
print('[ 1 ] cash or check')
print('[ 2 ] card payment')
print('[ 3 ] 2x on the card')
print('[ 4 ] 3x or more on the card')
option = int(input('What is the option? '))
if option != 1 and option != 2 and option != 3 and option != 4:
    print('\033[1;31mPlease select a valid option!\033[m')
elif option == 1:
    print('Your purchase of $ {:.2f} will cost $ {:.2f} in the end.'
          .format(price, price * 0.9))
elif option == 2:
    print('Your purchase of $ {:.2f} will cost $ {:.2f} in the end.'
          .format(price, price * 0.95))
elif option == 3:
    print('Your purchase of $ {:.2f} will cost $ {:.2f} in the end.'
          'You will pay the final amount in 2x of $ {:.2f}.'
          .format(price, price, price / 2))
elif option == 4:
    print('Your purchase of $ {:.2f} will cost $ {:.2f} in the end.'
          .format(price, price * 1.2))
    installments = int(input('In how many installments will you pay? '))
    print('You will pay in {}x of $ {:.2f}.'.format(installments, ((price * 1.2) / installments)))
