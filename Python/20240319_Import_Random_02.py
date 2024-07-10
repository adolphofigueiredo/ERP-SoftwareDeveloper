from random import choice

a1 = str(input('Enter the name of the first student: '))
a2 = str(input('Enter the name of the second student: '))
a3 = str(input('Enter the name of the third student: '))
a4 = str(input('Enter the name of the fourth student: '))

students = [a1, a2, a3, a4]

print('The chosen student is: {}'.format(choice(students)))
