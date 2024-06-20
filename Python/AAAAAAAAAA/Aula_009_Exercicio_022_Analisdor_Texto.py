nome = str(input('Digite o nome completo: ')).strip()
upper = nome.upper()
lower = nome.lower()
letrassemespaco = len(nome) - nome.count(' ')
dividido = nome.split()
letrasprimeironome = len(dividido[0])
print('O nome completo em letras maiúsculas fica conforme abaixo:'
      '\n{}\nO nome completo em letras minúsculas fica conforme'
      ' abaixo:\n{}\nSem considerar os espaços, o nome possui:\n{}'
      ' letras\nO primeiro nome possui:\n{} letras'
      .format(upper,lower,letrassemespaco,letrasprimeironome))