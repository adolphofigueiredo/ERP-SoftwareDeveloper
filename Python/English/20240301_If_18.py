total_age = 0
average_age = 0
oldest_man_age = 0
oldest_man_name = ''
women_under_20_count = 0
for c in range(1, 5):
    print('====== {}° Person ======'.format(c))
    name = str(input('Name: ')).strip()
    age = int(input('Age: '))
    gender = str(input('Gender [M/F]: ')).strip()
    total_age += age
    if gender in 'Mm' and c == 1:
        oldest_man_age = age
        oldest_man_name = name
    if gender in 'Mm' and age > oldest_man_age:
        oldest_man_age = age
        oldest_man_name = name
    if gender in 'Ff' and age < 20:
        women_under_20_count += 1
average_age = total_age / 4
print('The average age of the group is {} years.'.format(average_age))
print('The oldest man is {} years old and his name is {}.'.format(oldest_man_age, oldest_man_name))
print('There are {} women under 20 years old.'.format(women_under_20_count))
