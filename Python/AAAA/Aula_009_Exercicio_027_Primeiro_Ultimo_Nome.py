nome = str(input('Digite o nome completo: ')).title().strip().split()
print('muito prazer em te conhecer, {}!\n'
      'O primeiro nome é {}.\n'
      'O último nome é {}.'
.format(nome,nome[0],nome[len(nome)-1]))
