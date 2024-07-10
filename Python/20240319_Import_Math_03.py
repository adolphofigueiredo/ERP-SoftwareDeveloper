import math

catetooposto = float(input('Enter the opposite side: '))
catetoadjacente = float(input('Enter the adjacent side: '))
hipotenusa = math.hypot(catetooposto, catetoadjacente)
print('A right triangle with an opposite side of {} and an adjacent side of {} has a hypotenuse of {:.2f}.'.format(catetooposto, catetoadjacente, hipotenusa))
