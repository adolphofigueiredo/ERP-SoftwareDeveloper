nome = str(input('Enter the name: ')).strip()  # Prompting user to enter a name and stripping any extra whitespace
nomelower = nome.lower()  # Converting the input name to lowercase
print('Does your name have Silva? {}'.format('silva' in nome))  # Checking if 'silva' is in the original input name
