d  = int(input('Quantos dias o carro ficou alugado? '))
km = float(input('Quantos km foram rodados? '))
pd  = d  *  60
pkm = km *   0.15
v   = pd + pkm
print('Para alugar o carro por {} dias o custo é de R$ {:.2f}.\nPara rodar {} Km o custo é de {:.2f}.\nO que totaliza um valor de R$ {:.2f}.'.format(d, pd, km, pkm, v))
