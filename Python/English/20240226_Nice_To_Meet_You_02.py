name = str(input('What is your name? '))

if name == 'Gustavo':
    print('What a beautiful name!')
elif name == 'Pedro' or name == 'Maria' or name == 'Paulo':
    print('Your name is quite popular in Brazil!')
elif name in 'Ana Cláudia Jéssica Juliana':
    print('Lovely female name!')
else:
    print('Your name is quite normal!')
    
print('Have a nice day, {}!'.format(name))
