'''
Author: Adolpho Silverio Figueiredo Neto
Date: 07/05/2024

Exercise 03

Read a list of integers of N positions, with N given as input. Read an additional integer
M and determine how many numbers stored in the list are less than and how many are greater than M.
'''

# Global Variables:

                                                           #

# Functions:

    #Function:
def getInput():                                  #
    '''
Function: getInput
Function created to determine the number of elements in the list.

Parameters:

Return value:
N --> Number of elements in the list.
    '''
    #Parameters:
    N = -1                                                 #
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
N --> Number of elements in the list.

Return value:
List --> Variable created to store the list. 
    '''
    #Parameters:
    Lista = []
    for x in range (N):                                    #
        element = int(input(f"Enter element {x+1}: "))
        Lista += [element]
    
    #Return value:
    return Lista                                           #
                                                                                                        
    #Function:
def getLimit():                                  #
    '''
Function: getLimit
Function created to determine the limit number to be used in the calculation.
Parameters:

Return value:
NumLimit --> Variable created to store the limit number.   
    '''
    #Parameters:
    NumLimit = int(input("Enter the limit number: ")) #
    #Return value:
    return NumLimit                                       #
                                                                                                        
    #Function:
def classify(N, Lista, NumLimit):                                     #
    '''
Function: classify
Function created to count how many numbers are greater than, less than, and equal to the limit number.

Parameters:
N --> Number of elements in the list.
Lista --> Variable created to store the list. 
NumLimit --> Variable created to store the limit number.

Return value:
Greater --> Counter created to count how many numbers are greater than the limit number.
Lesser --> Counter created to count how many numbers are less than the limit number.
Equal --> Counter created to count how many numbers are equal to the limit number.
    '''
    #Parameters:
    Greater = 0
    Lesser = 0
    Equal = 0
    for x in range (N):                                    #
        if Lista[x] == NumLimit:                          #        
            Equal += 1
        elif Lista[x] < NumLimit:                         #        
            Lesser += 1
        else:                                              #
            Greater += 1
    #Return value:
    return Greater, Lesser, Equal                        #

# Variable Initializations

                                                           #

# Input Data Section

                                                           #
 
# Processing

N = getInput()                                   #
Lista = createList(N)                                  #
NumLimit = getLimit()                           #
Greater, Lesser, Equal = classify(N, Lista, NumLimit)    #

# Any Sub-Processes of Processing

                                                           #

# Output Section

print(f"\nThe numbers in the list are classified as follows:\n")
print(f"Greater than {NumLimit}: {Greater}")
print(f"Lesser than {NumLimit}: {Lesser}")
print(f"Equal to {NumLimit}: {Equal}\n")
print(f"Total numbers entered in the list: {N}\n")
