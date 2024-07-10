from random import randint

print('-' * 50)
print('{:^50}'.format('Even or Odd Game'))
print('-' * 50)

victory_count = 0

while True:
    choice = ' '
    player_number = int(input('Enter a number: '))
    computer_number = randint(0, 10)
    total = player_number + computer_number
    result = total % 2
    
    while choice not in 'EO':
        choice = str(input('Even or Odd? [E/O] ')).strip().upper()[0]
    
    print('-' * 50)
    print(f'You played {player_number} and the computer played {computer_number}, '
          f'totaling {total}.')
    
    if choice == 'E':  # Even
        if result == 0:
            print('The total is even, you win!')
            victory_count += 1
        elif result == 1:
            print('The total is odd, you lose!')
            print('-' * 50)
            break
    elif choice == 'O':  # Odd
        if result == 0:
            print('The total is even, you lose!')
            print('-' * 50)
            break
        elif result == 1:
            print('The total is odd, you win!')
            victory_count += 1
    
    print('-' * 50)

print(f'Game Over! You won {victory_count} times!')
print('-' * 50)
