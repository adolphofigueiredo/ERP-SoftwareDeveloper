'''
Author: Adolpho Silverio Figueiredo Neto
Date: 29/04/2024

Exercise 01

Given N as input, insert N numerical elements into a list. Then print the list.

'''

# Global Variables:
                                                           #
# Functions:

    # Function:
def InputNumbers():                                         #
    '''
Function: InputNumbers
Allows the user to enter the number of inputs.
Formal parameters:
Loop created to ensure the number is positive.
Return value:
N --> int
    '''
    # Formal parameters:
    N = -1                                                 #
    while N <= 0:                                          #
        N = int(input("Enter the number of inputs: "))     #
    # Return value:
    return N                                               #

    # Function:
def InsertIntoList(N):                                     #
    '''
Function: InsertIntoList
Allows the user to enter numerical elements into a list.
Formal parameters:
Loop created to ensure that N numbers are inserted into the list.
Return value:
List
    '''
    # Formal parameters:
    List = []
    for x in range(N):                                     #
        TempList = float(input("Enter the numerical element: ")) #
        List += [TempList]                                 #
    # Return value:
    return List                                            #

# Variable Initializations
                                                           #
# Input Data Section
                                                           #
# Processing

N = InputNumbers()                                         #
List = InsertIntoList(N)                                   #
# Any Sub Processing
                                                           #
# Output Section
print("\n", List, "\n")                                    #
