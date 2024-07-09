nome = str(input('Digite o nome completo: ')).title().strip().split()
print('muito prazer em te conhecer, {}!\n'
      'O primeiro nome é {}.\n'
      'O último nome é {}.'
.format(nome,nome[0],nome[len(nome)-1]))
name = str(input('Enter your full name: ')).title().strip().split()

print('Nice to meet you, {}!\n'
      'The first name is {}.\n'
      'The last name is {}.'
      .format(' '.join(name), name[0], name[-1]))
