salary = float(input('What is the employee\'s salary? R$ '))

# Determine the increase based on salary
if salary > 1250:
    increase = salary * (1 + 0.10)
else:
    increase = salary * (1 + 0.15)

# Calculate the increase amount and new salary
increase_amount = increase - salary
new_salary = increase

print ('The employee will receive a raise of R$ {:.2f}, totaling\n'
       'a new salary of R$ {:.2f}.'.format(increase_amount, new_salary))
