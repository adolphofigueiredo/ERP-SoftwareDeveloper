# Tuples are immutable, once declared their values cannot be changed!
snack = ('Hamburger', 'Juice', 'Pizza', 'Pudding')
print('snack        -->', snack)
print('snack[1]     -->', snack[1])
print('snack[-1]    -->', snack[-1])
print('snack[-2]    -->', snack[-2])
print('snack[1:3]   -->', snack[1:3])
print('snack[:2]    -->', snack[:2])
print('snack[2:]    -->', snack[2:])
print('snack[-2:]   -->', snack[-2:])
print('snack[-3:]   -->', snack[-3:])
for food in snack:
    print(f'I am going to eat {food}.')
print('I ate a lot!')
