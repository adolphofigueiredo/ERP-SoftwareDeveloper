'''
Author: Adolpho Silverio Figueiredo Neto
Date: 23/04/2024

Exercise 4 
Read a sentence and print it in reverse order.
Example:
input: CIAO COME STAI? output: ?IAST EMOC OAIC
'''

##
## Functions:
##

def insertString(prompt: str) -> str:
    """
    Function: insertString
    Allows the user to enter a string
    from standard input
    Formal parameters:
    str -> prompt that is displayed
    Return value:
    str string -> string entered by the user
    """
    string = ""
    while string == "":
        string = input(prompt)
    return string

def reverseString(string: str) -> str:
    """
    Function: reverseString
    Returns the string passed as a formal parameter in reverse order
    (first character in last position and so on)
    Formal parameters:
    str string -> string to be reversed
    Return value:
    str strOutput -> reversed string
    """
    strOutput = ""
    for pos in range(len(string)-1, -1, -1):
        strOutput += string[pos]
    return strOutput

    # More compact function
    # def reverseString1(string: str) -> str:
    #     return string[::-1]

"""
Main program
The program allows the user to enter
a string which is then printed starting from the last character
to the first.
"""

# Data input section
string = insertString("Enter the string: ")

# Processing and output
print(reverseString(string))
