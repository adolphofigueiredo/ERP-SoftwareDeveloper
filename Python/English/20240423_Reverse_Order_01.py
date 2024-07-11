'''
Author: Adolpho Silverio Figueiredo Neto
Date: 23/04/2024

Exercise 4 
Read a sentence and print it in reverse order.
Example:
input: HELLO HOW ARE YOU? output: ?UOY ERA WOH OLLEH
'''

# Variable Initialization

phrase = input("\nEnter the sentence: ")                   # Request for the string.
reversed_phrase = ""                                       # Variable created to store the reversed string.

# Input Data Section

counter = -1                                               # Counter responsible for controlling each letter.

# Processing

for x in range(1, len(phrase) + 1):                        # Loop created to reverse the input string.
    reversed_phrase += phrase[counter]                     # Accumulator for each letter taken from the original string.
    counter -= 1                                           # Counter responsible for controlling each letter.

# Output Section

print(f"\nThe reversed sentence is '{reversed_phrase}'.\n") # Print the reversed string.