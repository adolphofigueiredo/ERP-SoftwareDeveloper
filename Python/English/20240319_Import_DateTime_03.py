from datetime import date

adults = 0
minors = 0

for n in range(1, 8):
    year = int(input('Enter the year of birth for person {}: '.format(n)))
    if (date.today().year - 18) >= year:
        adults += 1
    else:
        minors += 1

print('In total, we have {} adults\nand {} minors.'.format(adults, minors))
