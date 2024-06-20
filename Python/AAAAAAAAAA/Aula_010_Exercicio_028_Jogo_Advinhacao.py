import random
import time
print('-=-' * 20)
print('{:^60}'.format('Estou pensando...'))
print('-=-' * 20)
time.sleep(5)
print('Pensei! Quer tentar adivinhar?')
numerordm = random.randint(0,5)
numero = int(input('Escolha um número de 0 até 5: '))
if numero == numerordm:
    print('Parabéns! Você acertou o número escolhido!')
else:
    print('Hahahahah! Você errou! Tente novamente...\n'
          'O número escolhido foi {}.'.format(numerordm))

