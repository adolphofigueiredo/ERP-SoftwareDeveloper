times = ('Corinthians', 'Palmeiras', 'Santos', 'Grêmio', 'Cruzeiro',
         'Flamengo', 'Vasco', 'Chapecoense', 'Atlético', 'Botafogo',
         'Atlético-PR', 'Bahia', 'São Paulo', 'Fluminense', 'Sport Recife',
         'EC Vitória', 'Coritiba', 'Avai', 'Ponte Preta', 'Atlético-GO')
print('-' * 80)
print(f'Lista de times do Brasileirão:\n{times}')
print('-' * 80)
print(f'Os cinco primeiros colocados são:\n{times[0:5]}')
print('-' * 80)
print(f'Os quatro últimos colocados são:\n{times[-4:]}')
print('-' * 80)
print(f'Os times em ordem alfabética são:\n{sorted(times)}')
print('-' * 80)
print(f'O Chapecoense está na:\n{times.index("Chapecoense")+1}º Posição')
print('=' * 80)
print('{:-^80}'.format('Fim'))
print('=' * 80)
