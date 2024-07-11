print('-' * 60)
print('{:^60}'.format('DODO Store'))
print('-' * 60)
total = count = lowest = highest = 0
highest_product = lowest_product = ''
while True:
    option = ' '
    product = str(input('Product: '))
    price = float(input('Price: $ '))
    total += price
    count += 1
    if count == 1:
        highest = lowest = price
        highest_product = lowest_product = product
    else:
        if price > highest:
            highest = price
            highest_product = product
        if price < lowest:
            lowest = price
            lowest_product = product
    while option not in 'SsNn':
        option = str(input('Do you want to continue? [Y/N] ')).upper().strip()[0]
        print('-' * 60)
    if option == 'N':
        break
print(f'You bought {count} products and the total purchase was $ {total:.2f}.')
print(f'The most expensive product is {highest_product} and it cost $ {highest:.2f}.')
print(f'The cheapest product is {lowest_product} and it cost $ {lowest:.2f}.')
print('-' * 60)
print('{:^60}'.format('Program Successfully Ended'))
print('-' * 60)
