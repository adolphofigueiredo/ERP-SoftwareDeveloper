items = ('Pencil', 1.75,
         'Eraser', 2,
         'Notebook', 15.9,
         'Pencil Case', 25,
         'Protractor', 4.2,
         'Compass', 9.99,
         'Backpack', 120.32,
         'Pen', 22.3,
         'Book', 34.9)
total = 0

print('-' * 40)
print(f'{"Price List":^40}')
print('-' * 40)

for position in range(0, len(items)):
    if position % 2 == 0:
        print(f'{items[position]:.<28}', end='')
    else:
        print(f'$ {items[position]:>9.2f}')
        total += items[position]

print('=' * 40)
print(f'{"TOTAL":.<28}$ {total:>9.2f}')
print('=' * 40)
