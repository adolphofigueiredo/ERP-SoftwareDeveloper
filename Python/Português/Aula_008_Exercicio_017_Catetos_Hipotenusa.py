import math
catetooposto = float(input('Digite o cateto oposto: '))
catetoadjacente = float(input('Digite o cateto adjacente: '))
hipotenusa = math.hypot(catetooposto,catetoadjacente)
print('O triângulo retângulo com o cateto oposto de {} e o cateto adjacente de {} tem a hipotenusa com {:.2f}.'.format(catetooposto,catetoadjacente,hipotenusa))
