'''
Author: Adolpho Silverio Figueiredo Neto
Date: 23/04/2024

Exercise 2
Read a string and determine how many vowels it contains.
'''

# Variable Initializations

word = input("\nEnter the string: ").lower()  # Request input and convert to lowercase.
counter = 0                                  # Counter responsible for tracking each letter.
vowel_count = 0                              # Counter responsible for counting each vowel found.

# Processing

for x in range(1, len(word) + 1):             # Loop to check each letter in the input string.
    check = word[counter]                    # Select a letter based on the counter.
    counter += 1                             # Increment the counter to move to the next letter.
    if check in "aeiou":                     # Condition to test if the letter is a vowel.
        vowel_count += 1                     # Increment the vowel counter if a vowel is found.

# Output Section

if vowel_count == 0:
    print("This string contains no vowels.\n")  # Condition to determine which response model to use.
elif vowel_count == 1:
    print(f"This string contains {vowel_count} vowel.\n")
else:
    print(f"This string contains {vowel_count} vowels.\n")
