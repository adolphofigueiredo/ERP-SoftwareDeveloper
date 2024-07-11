from time import sleep

n1 = float(input('Enter the first number: '))
n2 = float(input('Enter the second number: '))
option = 6
larger = 0
smaller = 0

while option != 5:
    print('-' * 40)
    print('Please select an option:')
    print('-' * 40)
    print('''[1] Sum the numbers
[2] Multiply the numbers
[3] Largest number
[4] Enter new numbers
[5] Exit the program''')
    print('-' * 40)
    option = int(input('What is your option? '))
    print('-' * 40)

    if option == 1:
        sum_result = n1 + n2
        print('The sum of {} and {} is {}.'.format(n1, n2, sum_result))
    elif option == 2:
        multiplication_result = n1 * n2
        print('The multiplication of {} and {} is {}.'
              .format(n1, n2, multiplication_result))
    elif option == 3:
        if n1 < n2:
            larger = n2
            smaller = n1
        elif n1 > n2:
            larger = n1
            smaller = n2
        print('The larger number is {} and the smaller number is {}.'
              .format(larger, smaller))
    elif option == 4:
        n1 = float(input('Enter the first number: '))
        n2 = float(input('Enter the second number: '))
    elif option != 1 and option != 2 and option != 3 and option != 4 and option != 5:
        print('Invalid option!')
    
    sleep(2)

print('{:.^40}'.format('Finishing'))
sleep(1)
print('\n')
print('=' * 40)
print('{:^40}'.format('Successfully completed!'))
print('=' * 40)
