n1 = int(input('Insira um número: '))
n2 = int(input('Insira outro número: '))
if n1 > n2:
    print('O primeiro valor é \033[1;34m{}\033[m e é maior que o segundo'
          ' valor que é \033[1;31m{}\033[m.'
          .format(n1,n2))
elif n1 < n2:
    print('O primeiro valor é \033[1;31m{}\033[m e é menor que o segundo'
          ' valor que é \033[1;34m{}\033[m.'
          .format(n1,n2))
elif n1 == n2:                                   # ou escrever apenas else:
    print('O primeiro valor é \033[1;32m{}\033[m e é igual ao segundo'
          ' valor que é \033[1;32m{}\033[m.'
          .format(n1,n2))
