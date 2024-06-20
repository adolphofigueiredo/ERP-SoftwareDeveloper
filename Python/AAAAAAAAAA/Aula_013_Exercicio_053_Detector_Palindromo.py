frase = str(input('Digite uma frase: ')).strip().upper()
palavras = frase.split()
junto = ''.join(palavras)
invertido = ''
for letra in range(len(junto) - 1, -1, -1): #Existe outra opção em fatimento.
    invertido += junto[letra]
print('O inverso de {} é {}.'.format(junto, invertido))
if invertido == junto:
    print('Temos um palíndromo.')
else:
    print('Não é um palíndromo.')

