from random import shuffle

# Collect the names of the students
a1 = str(input('Enter the name of the student: '))
a2 = str(input('Enter the name of the student: '))
a3 = str(input('Enter the name of the student: '))
a4 = str(input('Enter the name of the student '))

# Create a list with the names
lista = [a1, a2, a3, a4]

# Shuffle the list randomly
shuffle(lista)

# Print the order of presentation
print('The presentation order is:\n{}'.format(lista))
