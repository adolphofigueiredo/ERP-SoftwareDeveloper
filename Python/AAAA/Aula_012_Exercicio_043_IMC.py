altura = float(input('Qual a sua altura em metros? '))
peso = float(input('Qual o seu peso em quilogramas? '))
imc = peso / altura ** 2
print('O IMC desta pessoa é {:.2f}.'.format(imc))
if imc < 18.5:
    print('Você está abixo do peso.')
elif 18.5 <= imc < 25:
    print('Parabéns! Você está no seu peso ideal.')
elif 25 <= imc < 30:
    print('Cuidado! Isto já é considerado sobrepeso.')
elif 30 <= imc < 40:
    print('Cuidado! Seu peso é perigoso para a sua saúde.')
elif imc >= 40:
    print('Cuidado! Isto é obesidade mórbida.')
