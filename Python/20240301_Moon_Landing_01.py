'''

Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: Moon Landing
The first time man went to the Moon was in 1969, create a program that
asks the user for their year of birth and tells them if they were born in the year man went
to the Moon or how many years before or how many years after.

'''

year = int(input("When were you born? "))

if year == 1969:
    print("You were born the same year man went to the moon.")
else:
    if year > 1969:
        x = year - 1969
        print("You were born {} years after man went to the moon.".format(x))
    else:
        x = 1969 - year
        print("You were born {} years before man went to the moon.".format(x))
