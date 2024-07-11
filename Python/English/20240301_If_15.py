number = int(input('Enter the number you want to convert: '))
option = int(input('Select the desired conversion option:\n'
                   '1 - Binary\n2 - Octal\n3 - Hexadecimal\n'))
binary = bin(number)[2:]
octal = oct(number)[2:]
hexadecimal = hex(number)[2:]

if option not in [1, 2, 3]:
    print('\033[1;31mYou did not select a valid option. Please try again!\033[m')
elif option == 1:
    print('Your number {} converted to binary is {}.'.format(number, binary))
elif option == 2:
    print('Your number {} converted to octal is {}.'.format(number, octal))
elif option == 3:
    print('Your number {} converted to hexadecimal is {}.'.format(number, hexadecimal))
print('Thank you!')
