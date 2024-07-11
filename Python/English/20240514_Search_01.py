'''
Author: Adolpho Silverio Figueiredo Neto
Date: 05/14/2024

Exercise 03

Write two functions that implement linear search and binary search.
Test the two functions through a main program.

'''

# Functions:


def BinarySearch(List, Key):
    '''
    Function: BinarySearch
    Compares the key "Key" with the element in the middle of the list. If the identified element
    is not the one being searched for, the search continues in the lower or upper half of the list, depending
    on whether the key is smaller or larger than the middle element.

    Formal parameters:
    N --> Number of elements in the list
    List --> List that will be used for the search
    Key --> The search key
    MaxAttempts --> Maximum number of attempts still possible

    Return value:
    Found --> Boolean variable indicating if the key was found in the list
    Position --> Position where the test is performed in the sorted list.
    '''
    # Formal parameters:
    Found =  False
    List = sorted(List)
    Attempt = 0
    N = len(List)
    Possibility = N - 1
    Position = int((Attempt + Possibility) / 2)
    while (Attempt < Possibility) and (List[Position] != Key):
        if List[Position] > Key:
            Possibility = Position - 1
        else:
            Attempt = Position + 1
        Position = int((Attempt + Possibility) / 2)
    if List[Position] == Key:
        Found = True
    if not Found:
        Position = "-----"
    # Return value:
    return Found, Position


def LinearSearch(List, Key):
    '''
    Function: LinearSearch
    Searches for the key "Key" by comparing it with each element in the list.
    The algorithm terminates successfully if the key is found. If it reaches the last
    element without finding the key, the algorithm exits unsuccessfully.

    Formal parameters:
    N --> Number of elements in the list
    List --> List that will be used for the search
    Key --> The search key

    Return value:
    Found --> Boolean variable indicating if the key was found in the list
    Counter --> Counter that records the number of search attempts for the key in the list
    '''
    # Formal parameters:
    Found = False
    N = len(List)
    Counter = 0
    while (Counter < N) and (List[Counter] != Key):
        Counter += 1
    if Counter < N:
        Found = True
    # Return value:
    return Found, Counter


# Processing

List = [312, 203, 310, 30, 273, 168, 187, 463, 332, 179, 365, 87, 135, 430, 375, 290, 95, 242, 489, 270, 190, 152, 13, 154, 123, 302, 308, 190, 376, 447, 161, 281, 140, 129, 184, 249, 298, 360, 83, 381, 234, 419, 158, 113, 294, 465, 280, 427, 54, 206]
Key = 95

Found, Counter = LinearSearch(List, Key)
print("\n----- Linear Search -----", "\n\nFound:  ", Found, "\nPosition:", Counter)

Found, Position = BinarySearch(List, Key)
print("\n----- Binary Search -----", "\n\nFound:  ", Found, "\nPosition:", Position, "(Sorted List)")

print("\n---------------------------")

print(sorted(List))
