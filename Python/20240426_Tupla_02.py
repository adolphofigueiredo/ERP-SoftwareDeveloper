snack = ('Hamburger', 'Juice', 'Pizza', 'Pudding', 'French Fries')

# Loop through each item in the tuple and print a message
for food in snack:
    print(f'I am going to eat {food}.')
print('-' * 40)

# Loop through the indices of the tuple and print a message with the position
for count in range(0, len(snack)):
    print(f'I am going to eat {snack[count]} at position {count}.')
print('-' * 40)

# Loop through the tuple with both index and item and print a message with the position
for pos, food in enumerate(snack):
    print(f'I am going to eat {food} at position {pos}.')
print('-' * 40)
