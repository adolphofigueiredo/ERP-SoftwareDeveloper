print('-=-' * 10)
print('{:^30}'.format('Analisador de Triângulos'))
print('-=-' * 10)
r1 = float(input('Primeiro segmento: '))
r2 = float(input('Segundo segmento: '))
r3 = float(input('Terceiro segmento: '))
if r1 < r2 + r3 and r2 < r1 + r3 and r3 < r1 + r2:
    print('Os segmentos acima podem formar um triângulo.')
    if r1 == r2 == r3:
        print('Por ter todos os lados iguais este triângulo é '
        'enquadrado como equilátero.')
    elif r1 == r2 or r1 == r3 or r2 == r3:
        print('Por ter dois lados iguais este triângulo é '
        'enquadrado como isósceles.')
    elif r1 != r2 != r3 != r1:
        print('Por ter todos os lados difertes este triângulo é '
        'enquadrado como escaleno.')
else:
    print('Os segmentos acima não podem formar um triângulo.')
