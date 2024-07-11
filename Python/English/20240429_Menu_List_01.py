'''
Author: Adolpho Silverio Figueiredo Neto
Date: 29/04/2024

Exercise 02

Given a list of N elements entered as input, print the average of all elements
greater than a value given as input.

'''

# Global Variables:
                                                           #
# Functions:

    # Function:
def NumeriInput():                                         #
    '''
Function: NumeriInput
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
def InserimentoLista(N):                                   #
    '''
Function: InserimentoLista
Allows the user to enter numeric elements into a list.
Formal parameters:
Cycle created to ensure that N numbers are entered into the list.
Return value:
List
    '''
    # Formal parameters:
    Lista = []
    for x in range(N):                                     #
        ListaTemp = float(input("Enter the numeric element: ")) #
        Lista += [ListaTemp]                               #
    # Return value:
    return Lista                                           #

# Function:
def ValoreMinimo():                                        #
    '''
Function: ValoreMinimo
Allows the user to enter the minimum value that each element in the list must have to be considered in the average.
Formal parameters:
Asks to enter the minimum value
Return value:
ValoreMin
    '''
# Formal parameters:
    ValoreMin = int(input("Enter the minimum value that each element in the list must have to be considered in the average: "))#
    # Return value:
    return ValoreMin                                       #

# Function:
def CalcoloMedia(N , Lista , ValoreMin):                   #
    '''
Function: CalcoloMedia
Calculates the average value based on the entered parameters.
Formal parameters:
Process the data
Return value:
ValoreMin
    '''
    Somma = 0
    NumElementi = 0

# Formal parameters:
    for x in range
