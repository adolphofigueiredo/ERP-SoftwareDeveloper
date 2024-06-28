from datetime import date
anonascimento = int(input('Ano de nascimento: '))
mesnascimento = int(input('Mês de nascimento: '))
dianascimento = int(input('Dia de nascimento: '))
anoatual = date.today().year
mesatual = date.today().month
diaatual = date.today().day
idade = anoatual - anonascimento
alistamento = anonascimento + 18
atraso = anoatual - alistamento
if idade == 18:
    print('\033[1;33mNeste ano você completa 18 anos, portanto você deve'
          ' se alistar ainda em {}.\033[m'.format(anoatual))
elif idade > 18:
    print('\033[1;31mVocê completou 18 anos em {}, portanto você já está '
          'atrasado {} anos para o alistamento.\033[m'.format(alistamento,
                                                          atraso))
elif idade < 18:
    print('\033[1;32mVocê completará 18 anos em {}, portanto você ainda tem '
          '{} anos para o alistamento.\033[m'.format(alistamento,(- atraso)))
print('Obrigado')