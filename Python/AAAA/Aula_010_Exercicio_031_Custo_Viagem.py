distancia = float(input('Qual a dstância, em km, da sua viagem? '))
if distancia <= 200:
    preco = distancia * 0.50
else:
    preco = distancia * 0.45
print('O valor da passagem será de R$ {:.2f}.'.format(preco))