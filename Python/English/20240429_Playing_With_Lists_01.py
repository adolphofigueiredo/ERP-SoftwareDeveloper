'''
Author: Adolpho Silverio Figueiredo Neto
Date: 29/04/2024

Exercise 03

Given a list of N elements entered as input, print the maximum and minimum value.

'''

# Global Variables:

# Functions:

# Function:
def InputNumbers():                                         
    '''
    Function: InputNumbers
    Allows the user to enter the number of inputs.
    Formal parameters:
    Loop created to ensure the number is positive.
    Return value:
    N --> int
    '''
    # Formal parameters:
    N = -1                                                 
    while N <= 0:                                          
        N = int(input("Enter the number of inputs: "))     
    # Return value:
    return N                                               

# Function:
def InsertIntoList(N):                                       
    '''
    Function: InsertIntoList
    Allows the user to enter numeric elements into a list.
    Formal parameters:
    Cycle created to ensure that N numbers are entered into the list.
    Return value:
    List
    '''
    # Formal parameters:
    List = []
    for x in range(N):                                      
        TempElement = float(input("Enter the numeric element: ")) 
        List += [TempElement]                               
    # Return value:
    return List                                            

# Function:
def MinMax(N , List):                                     
    '''
    Function: MinMax
    Function created to identify the minimum and maximum value of the list
    Formal parameters:
    Condition that assumes a certain value each time it is greater or lesser than a previously assumed value
    Return value:
    Min , Max
    '''
    Max = List[0]
    Min = List[0]
    # Formal parameters:
    for x in range(N):
        if List[x] > Max:
            Max = List[x]
        elif List[x] < Min:
            Min = List[x]

    # Return value:
    return Min , Max                                       
                                                                                                          
# Initialization of Variables

# Input Section

# Processing

N = InputNumbers()                                          
List = InsertIntoList(N)
Min , Max = MinMax(N, List)

# Any Sub-Processes of Processing

# Output Section

print(f"\nThe minimum value is {Min} and the maximum value is {Max}.\n")
