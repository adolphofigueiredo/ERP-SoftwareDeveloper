d  = int(input('How many days was the car rented? '))
km = float(input('How many kilometers were driven? '))
pd  = d  *  60
pkm = km *   0.15
v   = pd + pkm
print('For renting the car for {} days, the cost is R$ {:.2f}.\nFor driving {} km, the cost is R$ {:.2f}.\nThis totals to R$ {:.2f}.'.format(d, pd, km, pkm, v))
