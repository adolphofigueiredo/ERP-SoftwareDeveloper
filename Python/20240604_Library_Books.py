'''
Author: Adolpho Silverio Figueiredo Neto
Date: 04/06/2024

First Exercise

A used book resale store describes its products according to the following characteristics:

● Numeric code (integer)
● Number of pages
● Cost

For business purposes, there is a need to collect all the books for sale in an archive and print them in ascending order of cost per page.
'''
from dataclasses import dataclass

# Definition of Data Structures

@dataclass
class Book:
    Code: int
    Pages: int
    Cost: float

# Functions:

# Function:
def InsertBook(library: list) -> list:
    '''
Function: InsertBook
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Formal Parameters:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Return Value:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    '''
    
# Formal Parameters:

    while True:
        Code = -1
        while Code < 0:
            Code = int(input("\nEnter the code: "))
    
        Pages = 0
        while Pages <= 0:
            Pages = int(input("Enter the number of pages: "))

        Cost = 0
        while Cost <= 0:
            Cost = float(input("Enter the cost of the book: "))
    
        library.append(Book(Code, Pages, Cost))

        Confirm = input("\nDo you want to insert another book?\n\nS - Yes\nN - No\n")
        if Confirm.lower() == "n":
            break
    
# Return Value:

    return library

# Function:
def OrderCostPerPage(library: list) -> list:
    '''
Function: OrderCostPerPage
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Formal Parameters:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Return Value:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    '''
    
# Formal Parameters:

    for i in range(len(library)):
        for j in range(i, len(library)):
            if (library[i].Cost / library[i].Pages) > (library[j].Cost / library[j].Pages):
                library[i], library[j] = library[j], library[i]

# Return Value:

    return library

# Variable Initializations

library = []

# Input Section

# Processing

library = InsertBook(library)
library = OrderCostPerPage(library)

# Any Sub-Processing

# Output Section

print("   Code   ", "   Pages   ", "   Cost    ", " Cost / Pages ")
for book in library:
    print(f"{book.Code:<8} {book.Pages:<10} {book.Cost:<10} {(book.Cost / book.Pages):<14}")

