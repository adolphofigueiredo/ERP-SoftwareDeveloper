somaidade = 0
mediaidade = 0
maioridadehomem = 0
nomehomemvelho = ''
idademulher20 = 0
for c in range(1, 5):
    print('====== {}° Pessoa ======'.format(c))
    nome = str(input('Nome: ')).strip()
    idade = int(input('Idade: '))
    sexo = str(input('Sexo [M/F]: ')).strip()
    somaidade += idade
    if sexo in 'Mm' and c == 1:
        maioridadehomem = idade
        nomehomemvelho = nome
    if sexo in 'Mm' and idade > maioridadehomem:
        maioridadehomem = idade
        nomehomemvelho = nome
    if sexo in 'Ff' and idade < 20:
        idademulher20 += 1
mediaidade = somaidade / 4
print('A média de idade do grupo é de {} anos.'.format(mediaidade))
print('O homem mais velho tem {} anos e se chama {}.'.format(maioridadehomem, nomehomemvelho))
print('Ao todo são {} mulheres com menos de 20 anos.'.format(idademulher20))
