import datetime
ano = int(input('Digite 0 para analisar o ano atual ou digite o ano que deseja analisar: '))
if ano == 0:
    ano = datetime.date.today().year
if ano % 4 == 0 and ano % 100 != 0 or ano % 400 == 0:
    print('O ano de {} é bissexto.'.format(ano))
else:
    print('O ano de {} não é bissexto.'.format(ano))