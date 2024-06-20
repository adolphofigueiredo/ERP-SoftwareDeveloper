from math import sin,cos,radians
angulo = float(input('Digite o ângulo: '))
seno = sin(radians(angulo))
cosseno = cos(radians(angulo))
print('Para o ângulo de {}° temos o sendo de {} e o cosseno de {}.'.format(angulo,seno,cosseno))
