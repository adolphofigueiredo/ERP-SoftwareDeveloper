from datetime import date
birth_year = int(input('Year of birth: '))
birth_month = int(input('Month of birth: '))
birth_day = int(input('Day of birth: '))
current_year = date.today().year
current_month = date.today().month
current_day = date.today().day
age = current_year - birth_year
enlistment_year = birth_year + 18
delay = current_year - enlistment_year

if age == 18:
    print('\033[1;33mThis year you turn 18, therefore you must enlist still in {}.\033[m'.format(current_year))
elif age > 18:
    print('\033[1;31mYou turned 18 in {}, therefore you are already {} years late for enlistment.\033[m'.format(enlistment_year, delay))
elif age < 18:
    print('\033[1;32mYou will turn 18 in {}, therefore you still have {} years for enlistment.\033[m'.format(enlistment_year, (-delay)))
print('Thank you')
