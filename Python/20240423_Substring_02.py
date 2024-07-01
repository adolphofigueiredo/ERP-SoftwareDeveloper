'''
Author: Adolpho Silverio Figueiredo Neto
Date: 23/04/2024

Exercise 3
Read two strings and check if one is a substring of the other (i.e., if it is contained in the other).
'''

##
## Functions:
##

def inserisciStringa(prompt: str) -> str:
    '''
    Function: inserisciStringa
    Allows the user to input a string from standard input
    Formal Parameters:
    str -> prompt to be displayed
    Return Value:
    str stringa -> string entered by the user
    '''

    # Initialization of the out-of-domain string
    stringa = ""

    # Input loop and string check
    while stringa == "":
        stringa = input(prompt)
    return stringa

def isContenuta(str2: str, str1: str) -> bool:
    '''
    Function: isContenuta
    Checks if the string str2 is contained within the string str1
    Formal Parameters:
    str str2 -> string to be checked
    str str1 -> container string
    Return Value:
    bool ret -> True if str2 is contained in str1, otherwise False
    '''

    # Initialization of return value
    ret = False

    # Main check loop
    i = 0 # Position of characters in str1
    j = 0 # Position of characters in str2

    # Loop over the characters of str1 and str2
    while i < len(str1) and j < len(str2):
        if str1[i] != str2[j]:
            j = 0
        else:
            j += 1
        i += 1

    # Check the reason for exiting the loop
    if j >= len(str2) and i <= len(str1): # Found an occurrence of str2 within str1
        ret = True
    elif j == 0 and i == len(str1): # str2 is at the end of str1
        ret = True
    elif j == len(str2) and i == len(str1): # str2 == str1
        ret = True

    return ret

# More compact function
"""
def isContenuta1(str2: str, str1: str) -> bool:
    return str2 in str1
"""

"""
Main program
The program allows the user to input two strings. Then it checks if the second string is contained within the first one.
"""

# Input Data Section
stringa1 = inserisciStringa("First string: ")
stringa2 = inserisciStringa("Second string: ")

# Processing and output
if isContenuta(stringa2, stringa1):
    print(f"{stringa1} CONTAINS {stringa2}")
else:
    print(f"{stringa1} DOES NOT CONTAIN {stringa2}")
