from datetime import date

# Input birth year
ano = int(input('Year of birth: '))

# Get current year
anoatual = date.today().year

# Calculate age
idade = anoatual - ano

# Print athlete's age
print('The athlete is {} years old.'.format(idade))

# Determine classification based on age
if idade <= 9:
    print('For this age, the classification is Mirim')
elif 9 < idade <= 14:
    print('For this age, the classification is Infantil')
elif 14 < idade <= 19:
    print('For this age, the classification is Junior')
elif 19 < idade <= 25:
    print('For this age, the classification is Sênior')
elif idade > 25:
    print('For this age, the classification is Master')
