name = str(input('Enter the full name: ')).strip()

# Convert to uppercase
upper = name.upper()

# Convert to lowercase
lower = name.lower()

# Count the number of letters excluding spaces
letters_without_spaces = len(name) - name.count(' ')

# Split the name into individual words
split_name = name.split()

# Count the number of letters in the first name
first_name_letters = len(split_name[0])

# Print the results
print('The full name in uppercase is as follows:\n{}\n'
      'The full name in lowercase is as follows:\n{}\n'
      'Excluding spaces, the name has:\n{} letters\n'
      'The first name has:\n{} letters'
      .format(upper, lower, letters_without_spaces, first_name_letters))
