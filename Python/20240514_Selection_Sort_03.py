'''
Author: Adolpho Silverio Figueiredo Neto
Date: 05/14/2024

Exercise 02

Write a function that implements the selection sort seen in class.
Test the function through a main program.

'''

# Functions:

def SelectionSort(List):
    '''
    Function: SelectionSort
    The function searches for the smallest element and moves it to the first position. Then, among the remaining elements,
    it searches again for the smallest one and moves it to the second position, and so on until the last one, which will be the largest of all.

    Formal parameters:
    List --> List that will be sorted

    Return value:
    List --> Sorted list
    '''
    N = len(List)
    for i in range(N):
        for j in range(i, N):
            if List[i] > List[j]:
                List[i], List[j] = List[j], List[i]
    return List

# Processing

List = [312, 203, 310, 30, 273, 168, 187, 463, 332, 179, 365, 87, 135, 430, 375, 290, 95, 242, 489, 270, 190, 152, 13, 154, 123, 302, 308, 190, 376, 447, 161, 281, 140, 129, 184, 249, 298, 360, 83, 381, 234, 419, 158, 113, 294, 465, 280, 427, 54, 206]

SortedList = SelectionSort(List)

# Output section

print(SortedList)
