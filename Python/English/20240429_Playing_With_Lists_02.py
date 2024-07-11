'''
Author: Adolpho Silverio Figueiredo Neto
Date: 29/04/2024

Exercise 04

Given two lists LISTA1 and LISTA2 of N and M float numbers entered as input,
create a third list whose elements are the sum of the respective elements of LISTA1 and LISTA2.
Note that, generally, M != N, in this case, take the size of the sum list as the smaller value.

Example:

N=4 LISTA1=[-3.4, 10.0, -5.0, 1.0]
M=6 LISTA2=[0.0, 1.0, 3.0, 0.5, 0.6, 4.0]
Output LISTASUM = [-3.4, 11.0, -2.0, 1.5]

'''

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
def SumLists(N , M , List1 , List2):                        
    '''
    Function: SumLists
    Function created to sum the elements of the lists based on the list with the fewer values.
    Formal parameters:
    First identify which list has fewer values, then sum the values of the lists and finally create a third list with the results.
    Return value:
    ListSum
    '''
    # Formal parameters:
    ListSum = []
    if N == M or N < M:
        cycles = N
    else:
        cycles = M
    for x in range(cycles):
        ListSum += [(List1[x] + List2[x])]
    # Return value:
    return ListSum                                           

# Initialization of Variables

# Input Section

# Processing

N = InputNumbers()                                          
M = InputNumbers()
List1 = InsertIntoList(N)
List2 = InsertIntoList(M)
ListSum = SumLists(N , M , List1 , List2)

# Any Sub-Processes of Processing

# Output Section

print("\nList 01:   ", List1, "\nList 02:   ", List2, "\nList Sum:", ListSum, "\n")
