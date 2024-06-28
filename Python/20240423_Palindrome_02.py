'''
Author: Adolpho Silverio Figueiredo Neto
Date: 23/04/2024

Exercise 1
Given an input string, determine if it is a palindrome or not.
Example:
input: ANNA output: PALINDROME
input: CIAO output: NOT PALINDROME
'''

##
## Functions:
##

def getInputString() -> str:
    '''
    Function: getInputString
    Allows the user to input a string from standard input.
    Formal Parameters:
    None
    Return Value:
    str string -> string entered by the user
    '''

    # Initialization of out-of-domain string
    string = ""

    # Input loop and string check
    while string == "":
        string = input("Enter the string (non-empty): ")

    return string

def isPalindrome(string: str) -> bool:
    '''
    Function: isPalindrome
    Checks whether the given string passed as a formal argument
    is a palindrome or not.
    Formal Parameters:
    str string -> string to be checked
    Return Value:
    bool ret -> True if palindrome, otherwise False
    '''

    # Initialization of return value
    ret = True

    # Length of the string
    strLen = len(string)

    # Verification loop
    pos = 0
    while pos < strLen / 2 and ret:
        if string[pos] != string[strLen - pos - 1]:
            ret = False
        pos += 1

    return ret

"""
Main Program
The algorithm prints on the standard output
whether the string entered by the user is
a palindrome or not.
"""

# Input Section
string = getInputString()

# Processing and Output
if isPalindrome(string):
    print(string, "-> PALINDROME")
else:
    print(string, "-> NOT PALINDROME")
