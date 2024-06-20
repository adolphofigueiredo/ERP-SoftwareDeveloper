from datetime import date
ano = int(input('Ano de nascimento: '))
anoatual = date.today().year
idade = anoatual - ano
print('O atleta tem {} anos.'.format(idade))
if idade <= 9:
    print('Para esta idade a classificação é Mirim')
elif 9 < idade <= 14:
    print('Para esta idade a classificação é Infantil')
elif 14 < idade <= 19:
    print('Para esta idade a classificação é Junior')
elif 19 < idade <= 25:
    print('Para esta idade a classificação é Sênior')
elif idade > 25:
    print('Para esta idade a classificação é Master')
