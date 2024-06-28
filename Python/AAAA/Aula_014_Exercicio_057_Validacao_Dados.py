sexo = str(input('Informe seu sexo [M/F]: ')).strip().upper()[0]
while sexo not in 'FfMm':
    sexo = str(input('Dados inválidos! Por favor, informe seu sexo: '
                     '[M/F]: ')).strip().upper()[0]
print('O sexo {} foi registrado com sucesso.'.format(sexo))
