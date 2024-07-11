frase = str(input('Digite a frase: ')).lower().strip()
vezes    = frase.count('a')
primeira = frase.find('a')  + 1
ultima   = frase.rfind('a') + 1
print('A letra "A" aparece {} vezes.\nA primeira aparição '
      'ocorre na posição {}.\nA segunda aparição ocorre'
      ' na posição {}.'.format(vezes,primeira,ultima) )
