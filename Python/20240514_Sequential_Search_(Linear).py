# Function:
def LinearSearch(List , Search):
    '''
Function: LinearSearch
Searches for the key "Search" by comparing it with each element in the list.
The algorithm terminates successfully if the key is found. If it reaches the last
element without finding the key, the algorithm exits unsuccessfully.

Formal parameters:
N --> Number of elements in the list
List --> List used for searching
Search --> The search key

Return value:
Found --> Boolean variable indicating whether the key was found in the list
Counter --> Counter that records the number of search attempts for the key in the list
    '''
    # Formal parameters:
    Found = False
    N = len(List)
    Counter = 0
    while (Counter < N) and (List[Counter] != Search):
        Counter += 1
    if Counter < N:
        Found = True
    # Return value:
    return Found , Counter


List = [312,203,310,30,273,168,187,463,332,179,365,87,135,430,375,290,95,242,489,270,190,152,13,154,123,302,308,190,376,447,161,281,140,129,184,249,298,360,83,381,234,419,158,113,294,465,280,427,54,206]
Search = 95

Found , Counter = LinearSearch(List, Search)
print("Found: " , Found , "\nAttempts: " , Counter)
