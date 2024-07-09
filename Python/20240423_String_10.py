# The phrase to be analyzed
phrase = '    Adolpho Silverio Figueiredo Neto'

# Print the length of the phrase
print(len(phrase))

# Print the length of the phrase after stripping leading and trailing whitespace
print(len(phrase.strip()))

# Print the count of the letter 'o' in the phrase
print(phrase.count('o'))

# Print the count of the letter 'o' in the phrase from index 0 to 13
print(phrase.count('o', 0, 13))

# Print the starting index of the substring 'ph'
print(phrase.find('ph'))

# Print the starting index of the substring 'z' (returns -1 if not found)
print(phrase.find('z'))

# Check if the substring 'Neto' is in the phrase
print('Neto' in phrase)
