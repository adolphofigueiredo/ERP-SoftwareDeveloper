n1 = float(input('Digite a primeira nota: '))
n2 = float(input('Digite a segunda nota: '))
n = (n1 + n2) / 2
print('A sua média é {:.1f}.'.format(n))
if n >= 6.0:
    print(('Sua média foi boa! Parabéns!'))
else:
    print('Cuidado! Você precisa estudar mais!')
