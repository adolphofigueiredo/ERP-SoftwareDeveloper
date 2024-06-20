lanche = ('Hamburguer', 'Suco', 'Pizza', 'Pudim', 'Batata Frita')
for comida in lanche:
    print(f'Eu vou comer {comida}.')
print('-' * 40)
for cont in range(0, len(lanche)):
    print(f'Eu vou comer {lanche[cont]} na posição {cont}.')
print('-' * 40)
for pos, comida in enumerate(lanche):
    print(f'Eu vou comer {comida} na posição {pos}.')
print('-' * 40)
