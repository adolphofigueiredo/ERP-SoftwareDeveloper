'''
Author: Adolpho Silverio Figueiredo Neto
Date: 07/05/2024

Exercise 05
Read a list of N positions, with N given as input. Determine if each value stored in the
list is less than the square of the number in the previous position.
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
    List = []
    for x in range(N):                                    #
        element = int(input(f"Enter element {x+1}: "))
        List += [element]
    
    #Return value:
    return List                                           #
                                                                                                        
    #Function:
def isLessThanSquareOfPrevious(N, List):                    #
    '''
Function: isLessThanSquareOfPrevious
Function that checks if each value stored in the
list is less than the square of the number in the
previous position.

Parameters:
N --> Number of elements in the list.
List --> Variable created to store the list.

Return value:
CountSquarePrevious --> Variable created to count how many times
the condition is satisfied.
    '''
    #Parameters:
    CountSquarePrevious = 0
    for x in range(N):                                    #
        if x == 0:
            print(f"Element {x+1}: The first element cannot be tested.")
        elif List[x] < (List[x-1] * List[x-1]):
            print(f"Element {x+1}: {List[x]} is less than {List[x-1]} x {List[x-1]} = {List[x-1] * List[x-1]}.")
            CountSquarePrevious += 1
        else:
            print(f"Element {x+1}: {List[x]} is not less than {List[x-1]} x {List[x-1]} = {List[x-1] * List[x-1]}.")
    #Return value:
    return CountSquarePrevious                                    #

# Variable Initializations

                                                           #

# Input Data Section

                                                           #
 
# Processing

N = getInput()                                   #
List = createList(N)
print("\n", List, "\n")
CountSquarePrevious = isLessThanSquareOfPrevious(N, List)

# Any Sub-Processes of Processing

                                                           #

# Output Section

print(f"\nThe condition could have been satisfied {N-1} times and it was satisfied {CountSquarePrevious} times.\n") #
