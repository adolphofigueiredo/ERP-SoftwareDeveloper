old_men = young_men = old_women = young_women = young_people = old_people = 0
while True:
    option = ' '
    print('-' * 30)
    print('{:^30}'.format('Register a Person'))
    print('-' * 30)
    age = int(input('Age: '))
    gender = ' '
    while gender not in 'MmFf':
        gender = str(input('Gender: [M/F] ')).upper().strip()[0]
    if gender == 'M':
        if age >= 18:
            old_men += 1
        if age < 18:
            young_men += 1
    if gender == 'F':
        if age >= 18:
            old_women += 1
        if age < 18:
            young_women += 1
    if age < 18:
        young_people += 1
    else:
        old_people += 1
    print('-' * 30)
    while option not in 'SsNn':
        option = str(input('Do you want to continue? [S/N] ')).upper().strip()[0]
    if option == 'N':
        break
print('-' * 30)
print(f'Total people over 18 years old: {old_people}')
print(f'Total people under 18 years old: {young_people}')
print(f'Total men over 18 years old: {old_men}')
print(f'Total men under 18 years old: {young_men}')
print(f'Total women over 18 years old: {old_women}')
print(f'Total women under 18 years old: {young_women}')
print('-' * 30)
print('{:^30}'.format('Program Successfully Ended'))
print('-' * 30)
