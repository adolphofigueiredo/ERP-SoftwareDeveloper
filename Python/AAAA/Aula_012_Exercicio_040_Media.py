n1 = float(input('Insira a primeira nota: '))
n2 = float(input('Insira a segunda nota: '))
media = ( n1 + n2 ) / 2
print('Se a primeira nota é {:.2f} e a segunda nota é {:.2f}, a sua média '
      'é {:.2f}.'.format(n1,n2,media))
if media < 5:
    print('Voce está \033[1;31mreprovado\033[m.'.format())
elif 7 > media >= 5:
    print('Voce está de \033[1;33mrecuperação\033[m.'.format())
elif media >= 7:
    print('Voce está \033[1;34maprovado\033[m.'.format())
