import datetime
year = int(input('Enter 0 to analyze the current year or enter the year you want to analyze: '))
if year == 0:
    year = datetime.date.today().year
if year % 4 == 0 and year % 100 != 0 or year % 400 == 0:
    print('The year {} is a leap year.'.format(year))
else:
    print('The year {} is not a leap year.'.format(year))
