'''
Author: Adolpho Silverio Figueiredo Neto
Date: 23/04/2024

Exercise 2
Read a string and determine how many vowels it contains.
'''

##
## Functions:
##

def inserisciStringa() -> str:
    '''
    Function: inserisciStringa
    Allows the user to input a string
    from the standard input.
    Parameters:
    None
    Return Value:
    str stringa -> string entered by the user
    '''

    # Initialize empty string
    stringa = ""

    # Input loop to ensure non-empty string
    while stringa == "":
        stringa = input("Enter a non-empty string: ")
    return stringa

def isVocale(carattere: str) -> bool:
    '''
    Function: isVocale
    Checks if the input character is
    a vowel or not.
    Parameters:
    str carattere -> character to be checked
    Return Value:
    bool ret -> True if vowel, otherwise False
    '''

    # Initialize return value
    ret = False
    filtroVocali = "aeiouAEIOU"
    if carattere != "":  # if character is not null
        car = carattere[0]
        if car in filtroVocali:
            ret = True
    return ret

# More compact function version
'''
def isVocale1(carattere:str) -> bool:
    return carattere in "aeiouAEIOU"
'''

def contaVocali(stringa: str) -> int:
    '''
    Function: contaVocali
    Counts the number of vowels
    in the given string.
    Parameters:
    str stringa -> string to be checked
    Return Value:
    int cont -> number of vowels in the string
    '''

    # Initialize vowel count
    cont = 0

    # Count loop
    for carattere in stringa:
        if isVocale(carattere):
            cont += 1
    return cont

# Main program
# User inputs a string from the standard input.
# Then the vowels are counted and printed to the standard output.

# Input Section
stringa = inserisciStringa()

# Processing
numVocali = contaVocali(stringa)

# Output
print(f"{stringa} -> {numVocali} vowels")
