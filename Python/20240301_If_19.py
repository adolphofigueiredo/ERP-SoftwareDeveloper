print('=' * 50)
print('{:^50}'.format('DODO Bank'))
print('=' * 50)
withdrawal = int(input('What is the withdrawal amount? $ '))
print('-' * 50)
print(f'To withdraw $ {withdrawal:.2f}, you will need:')
balance = withdrawal
bill = 100
count = 0
while True:
    if balance >= bill:
        balance -= bill
        count += 1
    else:
        if count > 0:
            print(f'{count:>4} bills of $ {bill:.2f}.')
        if bill == 100:
            bill = 50
        elif bill == 50:
            bill = 20
        elif bill == 20:
            bill = 10
        elif bill == 10:
            bill = 5
        elif bill == 5:
            bill = 2
        count = 0
        if balance == 0:
            break
print('=' * 50)
print('{:^50}'.format('Thank you for choosing us!'))
print('=' * 50)
