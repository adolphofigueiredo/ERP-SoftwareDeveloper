'''
Author: Adolpho Silverio Figueiredo Neto
Date: 07/05/2024

Exercise 04

Read a list of integers of N positions, with N given as input. Determine if the values stored in the
list are in ascending order or not.
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
def isAscending(N, Lista):                                         #
    '''
Function: isAscending
Function created to check if the list is in ascending order.

Parameters:
N --> Number of elements in the list.
Lista --> Variable created to store the list. 

Return value:
Ascending --> Boolean variable that indicates if the list is in ascending order.
    '''
    Ascending = True
    #Parameters:
    for x in range (N-1):                                  #
        if Lista[x] > Lista[x+1]:
            Ascending = False
            break
    #Return value:
    return Ascending                                       #

# Variable Initializations

                                                           #

# Input Data Section

                                                           #
 
# Processing

N = getInput()                                   #
Lista = createList(N)
Ascending = isAscending(N, Lista)

# Any Sub-Processes of Processing

                                                           #

# Output Section

print("\n", Lista, "\n")                                          #
if Ascending:
    print("The list is in ascending order.\n")
else:
    print("The list is not in ascending order.\n")
