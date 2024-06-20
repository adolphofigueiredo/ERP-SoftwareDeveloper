numero = int(input('Digite o número que deseja converter: '))
opcao = int(input('Selecione a opção desejada para conversão:\n'
                  '1 - Binário\n2 - Octal\n3 - Hexadecimal\n'))
binario = bin(numero)[2:]
octal = oct(numero) [2:]
hexadecimal = hex(numero)[2:]
if opcao != 1 and opcao != 2 and opcao != 3:
    print('\033[1;31mVocê não selecionou uma opção existente.'
          ' Tente novamente!\033[m')
elif opcao == 1:
    print('O seu número {} convertido para binário é {}.'
          .format(numero,binario))
elif opcao == 2:
    print('O seu número {} convertido para octal é {}.'
          .format(numero,octal))
elif opcao == 3:
    print('O seu número {} convertido para hexadecimal é {}.'
          .format(numero,hexadecimal))
print('Obrigado!')