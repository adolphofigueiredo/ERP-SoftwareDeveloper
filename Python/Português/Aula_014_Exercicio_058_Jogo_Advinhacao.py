import random
import time
print('-=-' * 20)
print('{:^60}'.format('Estou pensando...'))
print('-=-' * 20)
print('Sou seu computador...')
time.sleep(1)
print('Pensei! Quer tentar adivinhar?')
computador = random.randint(0, 10)
jogador = int(input('Escolha um número de 0 até 10: '))
palpites = 1
while jogador != computador:
    palpites += 1
    if jogador < computador:
        jogador = int(input('Hahahahah! Você errou! O número é maior,'
                            ' tente novamente... '))
    elif jogador > computador:
        jogador = int(input('Hahahahah! Você errou! O número é menor,'
                            ' tente novamente... '))
if palpites > 3:
    print('Parabéns! Você demorou {} jogadas, mas finalmente acertou!!'
          .format(palpites))
elif palpites <= 3:
    print('Parabéns! Você só precisou de {} jogadas para acertar!!'
          .format(palpites))
