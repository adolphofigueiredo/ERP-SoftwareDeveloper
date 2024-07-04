'''
Author: Adolpho Silverio Figueiredo Neto
Date: 07/05/2024

Exercise 02

After reading and storing N real numbers in a list, with N given as input, calculate the
sum of the negative ones and subsequently overwrite their values with zero.
Print the calculated sum and the modified list.
'''

# Global Variables:

                                                           #

# Functions:

    #Function:
def getInput() -> int:                           #
    '''
Function: getInput
Function created to determine the number of elements in the list.

Parameters:

Return value:
N --> Number of elements in the list.
    '''
    #Parameters:
    N = 0
    while N <= 0:
        N = int(input("Enter the number of elements in the list: "))
    #Return value:
    return N                                               #

    #Function:
def createList(N):                                     #
    '''
Function: createList
Function created to insert elements into the list.

Parameters:
element --> Variable created to insert each element into the list.

Return value:
List --> Variable created to store the list. 
    '''
    #Parameters:
    Lista = []
    for x in range (N):
        element = int(input(f"Enter element {x+1}: "))
        Lista += [element]

    #Return value:
    return Lista                                           #

    #Function:
def sumNegatives(N, Lista):                              #
    '''
Function: sumNegatives
Function created to sum negative numbers and replace them with zero.

Parameters:

Return value:
Sum --> Function created to sum the negative values.
    '''
    #Parameters:
    Sum = 0
    for x in range (N):                                    #
        if Lista[x] < 0:
            Sum += Lista[x]
            Lista[x] = 0

    #Return value:

    return Sum                                           #

# Variable Initializations

                                                           #

# Input Data Section

                                                           #

# Processing

N = getInput()                                   #
Lista = createList(N)                                  #
Sum = sumNegatives(N, Lista)                           #

# Any Sub-Processes of Processing

                                                           #

# Output Section

print(f"The modified list with {N} elements is {Lista} and the sum of the negative numbers is {Sum}")  #
