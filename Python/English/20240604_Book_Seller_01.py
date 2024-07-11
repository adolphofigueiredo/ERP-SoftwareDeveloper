from dataclasses import dataclass

# Data Structure Definition

@dataclass
class Book:
    Code: int
    Pages: int
    Cost: float

# Functions:

def InsertBook(Library: list) -> list:
    '''
    Function: InsertBook
    Allows the insertion of books into the library.
    Formal parameters:
    Library --> list containing Book objects.
    Return value:
    Library --> the updated list containing all inserted books.
    '''
    
    Inserting = True

    while Inserting:
        
        Code = -1
        while Code < 0:
            Code = int(input("\nEnter the code (positive integer): "))
    
        Pages = 0
        while Pages <= 0:
            Pages = int(input("Enter the number of pages (positive integer): "))

        Cost = 0.0
        while Cost <= 0:
            Cost = float(input("Enter the cost of the book (positive number): "))
    
        Library.append(Book(Code, Pages, Cost))

        Confirm = input("\nDo you want to enter a new book?\n\nY - Yes\nN - No\n")
        if Confirm.lower() == 'n':
            Inserting = False
    
    return Library

def SortByCostPerPage(Library: list) -> list:
    '''
    Function: SortByCostPerPage
    Sorts the books in the library by cost per page in ascending order.
    Formal parameters: 
    Library --> list containing Book objects.
    Return value:
    Library --> the sorted list of books.
    '''
    
    return sorted(Library, key=lambda book: book.Cost / book.Pages)

# Variable Initializations

Library = []

# Data Input Section
# Processing

Library = InsertBook(Library)
Library = SortByCostPerPage(Library)

# Output Section
print("\n   Code      Pages     Cost      Cost per Page")
for book in Library:
    print(f"{book.Code:<10} {book.Pages:<10} {book.Cost:<10.2f} {book.Cost / book.Pages:<10.4f}")
