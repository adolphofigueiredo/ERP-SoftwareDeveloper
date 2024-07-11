homemvelho = homemnovo = mulhervelha = mulhernova = pessoanova = pessoavelha = 0
while True:
    opcao = ' '
    print('-' * 30)
    print('{:^30}'.format('Cadastre uma Pessoa'))
    print('-' * 30)
    idade = int(input('Idade: '))
    sexo = ' '
    while sexo not in 'MmFf':
        sexo = str(input('Sexo: [M/F] ')).upper().strip()[0]
    if sexo == 'M':
        if idade >= 18:
            homemvelho += 1
        if idade < 18:
            homemnovo += 1
    if sexo == 'F':
        if idade >= 18:
            mulhervelha += 1
        if idade < 18:
            mulhernova += 1
    if idade <= 18:
        pessoanova += 1
    elif idade > 18:
        pessoavelha += 1
    print('-' * 30)
    while opcao not in 'SsNn':
        opcao = str(input('Deseja continuar? [S/N] ')).upper().strip()[0]
    if opcao == 'N':
        break
print('-' * 30)
print(f'Total de pessoas com mais de 18 anos: {pessoavelha}')
print(f'Total de pessoas com menos de 18 anos: {pessoanova}')
print(f'Total de homens com mais de 18 anos: {homemvelho}')
print(f'Total de homens com menos de 18 anos: {homemnovo}')
print(f'Total de mulheres com mais de 18 anos: {mulhervelha}')
print(f'Total de mulheres com menos de 18 anos: {mulhernova}')
print('-' * 30)
print('{:^30}'.format('Programa Encerrado com Sucesso'))
print('-' * 30)
