name = 'José'
age = 33
salary = 987.3

print('The {} is {} years old and earns R$ {}.'.format(name, age, salary))
print(f'The {name:^20} is {age} years old and earns R$ {salary:.2f}.')
print(f'The {name:-^20} is {age} years old and earns R$ {salary:.2f}.')
print(f'The {name:<20} is {age} years old and earns R$ {salary:.2f}.')
print(f'The {name:>20} is {age} years old and earns R$ {salary:.2f}.')
print(f'The {name:-<20} is {age} years old and earns R$ {salary:.2f}.')
print(f'The {name:->20} is {age} years old and earns R$ {salary:.2f}.')
