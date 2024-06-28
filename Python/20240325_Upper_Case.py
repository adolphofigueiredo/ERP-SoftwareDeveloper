'''

Author: Adolpho Silverio Figueiredo Neto
Date: 25/03/2024

Third Exercise

Design a function that checks if the input character is an uppercase letter.
Create a program that allows the user to input three characters and prints which of them is
uppercase. Also, print the total number of uppercase characters.

'''

# Functions:

# Function: is_uppercase

def is_uppercase(char):                 # Definition created to check if the character is an uppercase letter.
    # Formal parameters:
    if char == char.upper():
        result = True                   # Variable created to indicate that the letter is uppercase.
    else:                           
        result = False                  # Variable created to indicate that the letter is not uppercase.
    # Return value:
    return result                       # Return the result.

# Data Input Section

# Variable Initialization

uppercase_count = 0                     # Responsible for counting how many times an uppercase character is entered.

# Processing

for _ in range(3):                      # Loop created to request the same data three times.
    letter = input("Enter a letter: ")  # Data request to check if the character is an uppercase letter.
    while not letter.isalpha():         # Loop created to verify if the entered data is a letter.
        letter = input("Error - The input is not a letter.\nEnter a letter: ")  # Error information and new input request.
    is_upper = is_uppercase(letter)     # Using the function that checks if the letter is uppercase.
    if is_upper:                        
        uppercase_count += 1           

# Any additional processing

# Output Section

if uppercase_count == 0:                # Result when there are no uppercase letters.
    print("None of the entered letters are uppercase.")
elif uppercase_count == 1:              # Result when there is one uppercase letter.
    print("Only one of the entered letters is uppercase.")
else:                                   # Result when there is more than one uppercase letter.
    print("There are {} uppercase letters entered.".format(uppercase_count))
