distancia = float(input('What is the distance of your trip, in km? '))
if distancia <= 200:
    preco = distancia * 0.50
else:
    preco = distancia * 0.45
print('The ticket price will be R$ {:.2f}.'.format(preco))
