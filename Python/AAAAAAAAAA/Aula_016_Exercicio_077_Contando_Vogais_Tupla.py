palavras = ('aprender', 'programar', 'linguagem', 'python', 'curso',
            'gratis', 'estudar', 'praticar', 'trabalhar', 'mercado',
            'programador', 'futuro', 'corona', 'pandemia', 'velha')
for palavra in palavras:
    print(f'\nNa palavra {palavra.upper()} temos: ', end='')
    for letra in palavra:
        if letra.lower() in 'aeiou':
            print(f'{letra}', end=' ')
