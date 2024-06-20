# Tuplas são imutáveis, depois do valor declarado ele não pode ser alterado!
lanche = ('Hamburguer', 'Suco', 'Pizza', 'Pudim')
print('lanche       -->', lanche)
print('lanche[1]    -->', lanche[1])
print('lanche[-1]   -->', lanche[-1])
print('lanche[-2]   -->', lanche[-2])
print('lanche[1:3]  -->', lanche[1:3])
print('lanche[:2]   -->', lanche[:2])
print('lanche[2:]   -->', lanche[2:])
print('lanche[-2:]  -->', lanche[-2:])
print('lanche[-3:]  -->', lanche[-3:])
for comida in lanche:
    print(f'Eu vou comer {comida}.')
print('Comi para caramba!')
