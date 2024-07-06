'''
Author: Adolpho Silverio Figueiredo Neto
Date: 05/14/2024

Exercise 02

Write a function that implements selection sort as seen in class.
Test the function through a main program.

'''

# Functions:

def selection_sort(lst):
    '''
    Function: selection_sort
    The function finds the smallest element and moves it to the first position. Then, among the remaining
    elements, it again finds the smallest one and moves it to the second position and so on until the last one,
    which will be the largest of all.

    Parameters:
    lst --> List of elements to be sorted

    Return value:
    lst --> Sorted list
    '''
    # Parameters:
    n = len(lst)
    for i in range(n):
        # Find the minimum element in remaining unsorted array
        min_idx = i
        for j in range(i+1, n):
            if lst[min_idx] > lst[j]:
                min_idx = j
        # Swap the found minimum element with the first element
        lst[i], lst[min_idx] = lst[min_idx], lst[i]
    # Return value:
    return lst

# Main program

lst = [312, 203, 310, 30, 273, 168, 187, 463, 332, 179, 365, 87, 135, 430, 375, 290, 95, 242, 489, 270, 190, 152, 13, 154, 123, 302, 308, 190, 376, 447, 161, 281, 140, 129, 184, 249, 298, 360, 83, 381, 234, 419, 158, 113, 294, 465, 280, 427, 54, 206]

sorted_lst = selection_sort(lst)

# Output section

print(sorted_lst)
