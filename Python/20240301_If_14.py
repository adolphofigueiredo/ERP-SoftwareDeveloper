property_value = float(input('What is the value of the property? R$ '))
salary = float(input('What is the buyer\'s salary? R$ '))
years = int(input('In how many years do you wish to pay off the financing? '))
monthly_payment = property_value / (years * 12)
limit = salary * 0.3

if monthly_payment <= limit:
    print('\033[1;32mCongratulations! Your financing has been approved!\n'
          'The monthly payment will be R$ {:.2f}.\033[m'.format(monthly_payment))
else:
    print('\033[1;31mUnfortunately, your financing has not been approved.\n'
          'The financed amount exceeds the limit allowed by your income.\033[m')
print('Thank you!')
