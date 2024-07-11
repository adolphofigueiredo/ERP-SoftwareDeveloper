gender = str(input('Enter your gender [M/F]: ')).strip().upper()[0]
while gender not in 'MF':
    gender = str(input('Invalid data! Please, enter your gender: [M/F]: ')).strip().upper()[0]
print('Gender {} has been successfully registered.'.format(gender))
