'''
Author: Adolpho Silverio Figueiredo Neto
Date: 23/04/2024

Exercise 1
Given an input string, indicate in the output whether the string is a palindrome or not.
Example:
input: ANNA output: PALINDROME
input: CIAO output: NOT PALINDROME
'''

# Variable Initializations

counter = -1                                                # Counter created to reverse the word.
reverse_word = ""                                           # Initialization of the variable that will hold the reversed word.

# Data Input Section

word = input("Enter the word: ")                            # Request for input, the word.

# Processing

word = word.lower()                                         # Convert all letters to lowercase.

for x in range(1, len(word)+1):                             # Loop created to reverse the word.
    reverse_word += word[counter]                            # Variable created to receive the values of the reversed word.
    counter -= 1                                             # Counter that changes the letter that will be assigned each time it passes through the loop.

# Output Section

if word == reverse_word:                                    # Check if the reversed word is equal to the input word.
    print(f"The word {word} is a palindrome.")              # Output when the word is a palindrome.
else:
    print(f"The word {word} is NOT a palindrome.")          # Output when the word is not a palindrome.
