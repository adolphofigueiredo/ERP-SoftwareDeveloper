teams = ('Corinthians', 'Palmeiras', 'Santos', 'Grêmio', 'Cruzeiro',
         'Flamengo', 'Vasco', 'Chapecoense', 'Atlético', 'Botafogo',
         'Atlético-PR', 'Bahia', 'São Paulo', 'Fluminense', 'Sport Recife',
         'EC Vitória', 'Coritiba', 'Avai', 'Ponte Preta', 'Atlético-GO')
print('-' * 80)
print(f'List of Brasileirão teams:\n{teams}')
print('-' * 80)
print(f'The top five teams are:\n{teams[0:5]}')
print('-' * 80)
print(f'The bottom four teams are:\n{teams[-4:]}')
print('-' * 80)
print(f'Teams in alphabetical order:\n{sorted(teams)}')
print('-' * 80)
print(f'Chapecoense is in:\n{teams.index("Chapecoense")+1}º position')
print('=' * 80)
print('{:-^80}'.format('End'))
print('=' * 80)
