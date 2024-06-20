from datetime import date
maior = 0
menor = 0
for n in range(1, 8):
    ano = int(input('Digite o ano do {}° nascimento: '.format(n)))
    if (date.today().year - 18) >= ano:
        maior += 1
    elif (date.today().year - 18) < ano:
        menor += 1
print('Ao todo tivemos {} pessoas maiores de idade\n'
      'e {} pessoas menores de idade.'.format(maior, menor))
