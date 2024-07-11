# The phrase to be analyzed
phrase = '    Adolpho Silverio Figueiredo Neto   '

# Print the original phrase
print(phrase)

# Replace 'Neto' with 'Junior' in the phrase
print(phrase.replace('Neto', 'Junior'))

# Convert the phrase to uppercase and count occurrences of 'o'
print(phrase.upper().count('o'))

# Convert the phrase to uppercase and count occurrences of 'o' again (to show case insensitivity)
print(phrase.upper().count('o'))

# Convert the phrase to uppercase
print(phrase.upper())

# Convert the phrase to lowercase and count occurrences of 'o'
print(phrase.lower().count('o'))

# Convert the phrase to lowercase
print(phrase.lower())

# Capitalize the phrase (first letter uppercase, rest lowercase)
print(phrase.capitalize())

# Convert the phrase to title case (first letter of each word uppercase)
print(phrase.title())

# Strip leading and trailing whitespace
print(phrase.strip())

# Strip trailing whitespace
print(phrase.rstrip())

# Strip leading whitespace
print(phrase.lstrip())
