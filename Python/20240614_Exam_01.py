'''
Author: Adolpho Silverio Figueiredo Neto
Date: 14/06/2024

A library has identified all the books in its collection using a numerical code.
The peculiar information of the book is as follows: the numerical code, the title, the author,
the year of publication, the publishing house, the username that uses the loan, the number of
days left until the loan expires.

Create a program that prints a selection menu with the following options:

1 - Insertion of N books in the library
2 - Print the total number of books present
3 - Print all the books present
4 - Print all books sorted by author
5 - Print books that are not on loan sorted by code
6 - Print all books expiring (less than 2 days until the expiration date)
7 - Exit
'''

from dataclasses import dataclass

@dataclass
class Collection:
    NumericalCode: int
    Title: str
    Author: str
    Publication: int
    Publisher: str
    UserLoan: str
    DaysExpiration: int

def MenuChoice():
    '''
Function: MenuChoice
Function created to print the menu and receive the selected input.

Return value:
Choice --> Variable created to choose the menu option.
    '''
    Choice = input('''-------------------------------------------------------------------------------------
                                        MENU
-------------------------------------------------------------------------------------
1. Insertion of N books in the library
2. Print the total number of books present
3. Print all the books present
4. Print all books sorted by author
5. Print books that are not on loan sorted by code
6. Print all books expiring (less than 2 days until the expiration date)
7. Exit (with confirmation)
-------------------------------------------------------------------------------------
Select one of the options: ''')
    print("-------------------------------------------------------------------------------------")
    return Choice

def ConfirmExit(Exit) -> bool:
    '''
Function: ConfirmExit
Function created to confirm the exit from the program.

Formal parameters:
Confirm --> Input requested to confirm the exit from the program.

Return value:
Exit --> Variable that activates the confirmation of the exit from the program.
    '''
    Confirm = input("Do you confirm the exit?\n\nY - Yes\nN - No\n")
    if (Confirm == "Y") or (Confirm == "y"):
        Exit = True

    return Exit

def InsertBook(Library: list, ThereIsABook: bool):
    '''
Function: InsertBook
Function created to receive the book registration for as long as the user wants and then
send information about all the books and confirmation that it is now possible to use the other functions.

Formal parameters:
Insertion --> Variable that keeps the cycle active to register a new book.
NumericalCode --> Variable that receives the book code.
Title --> Variable that receives the book title.
Author --> Variable that receives the book author.
Publication --> Variable that receives the year of publication of the book.
Publisher --> Variable that receives the book publisher.
UserLoan --> Variable that receives the name of the person who loaned the book.
DaysExpiration --> Variable that receives the number of days left until the expiration.

Return value:
Library --> List that will store information about all the books.
ThereIsABook  --> Variable that informs if a book has already been registered or not.
    '''
    Insertion = True

    while Insertion:

        NumericalCode = -1
        while NumericalCode < 0:
            NumericalCode = int(input("Enter the book code: "))

        Title = ""
        while not Title:
            Title = input("Enter the book title: ")

        Author = ""
        while not Author:
            Author = input("Enter the book author: ")

        Publication = 0
        while Publication <= 0:
            Publication = int(input("Enter the year of publication of the book: "))

        Publisher = ""
        while not Publisher:
            Publisher = input("Enter the book publisher: ")

        UserLoan = input("Enter the name of the person who loaned the book (Leave blank if not on loan): ")

        DaysExpiration = 0
        if UserLoan != "":
            while DaysExpiration <= 0:
                DaysExpiration = int(input("Enter the number of days left until the expiration: "))

        Library.append(Collection(NumericalCode , Title , Author , Publication , Publisher , UserLoan , DaysExpiration))

        print("-------------------------------------------------------------------------------------")
        ConfirmBook = input("Do you want to insert a new book??\n\nY - Yes\nN - No\n")
        print("-------------------------------------------------------------------------------------")
        if (ConfirmBook == "N") or (ConfirmBook == "n"):
            Insertion = False

    ThereIsABook = True

    return Library , ThereIsABook

def TotalNumberOfBooks(Library: list) -> int:
    '''
Function: TotalNumberOfBooks
Function created to count the total number of books entered.

Return value:
Library --> List that will store information about all the books.
    '''
    return len(Library)

def PrintAll(Library: list):
    '''
Function: PrintAll
Function created to print all the books entered in the list.
    '''
    print("  Code  " , "       Title       " , "       Author       " , " Publication " , "    Publisher   " , "       User       " , " Expiration ")
    print("--------------------------------------------------------------------------------------------------------------------------")
    for Collection in Library:
        print(f"{Collection.NumericalCode:<10} {Collection.Title:<20} {Collection.Author:<20} {Collection.Publication:<15} {Collection.Publisher:<20} {Collection.UserLoan:<20} {Collection.DaysExpiration:<10}")

def PrintSortedByAuthor(Library: list):
    '''
Function: PrintSortedByAuthor
Function created to print all books sorted by author.
    '''
    for i in range ( len(Library) ):
        for j in range ( i , len(Library) ):
            if Library[i].Author > Library[j].Author:
                Library[i] , Library[j] = Library[j] , Library[i]

    print("  Code  " , "       Title       " , "       Author       " , " Publication " , "    Publisher   " , "       User       " , " Expiration ")
    print("--------------------------------------------------------------------------------------------------------------------------")
    for Collection in Library:
        print(f"{Collection.NumericalCode:<10} {Collection.Title:<20} {Collection.Author:<20} {Collection.Publication:<15} {Collection.Publisher:<20} {Collection.UserLoan:<20} {Collection.DaysExpiration:<10}")

def PrintNotOnLoanSortedByCode(Library: list):
    '''
Function: PrintNotOnLoanSortedByCode
Function created to print books that are not on loan sorted by code.
    '''
    for i in range ( len(Library) ):
        for j in range ( i , len(Library) ):
            if Library[i].NumericalCode > Library[j].NumericalCode:
                Library[i] , Library[j] = Library[j] , Library[i]

    print("  Code  " , "       Title       " , "       Author       " , " Publication " , "    Publisher   " , "       User       " , " Expiration ")
    print("--------------------------------------------------------------------------------------------------------------------------")
    for Collection in Library:
        if Collection.UserLoan == "":
            print(f"{Collection.NumericalCode:<10} {Collection.Title:<20} {Collection.Author:<20} {Collection.Publication:<15} {Collection.Publisher:<20} {Collection.UserLoan:<20} {Collection.DaysExpiration:<10}")

def ExpiringIn2Days(Library: list):
    '''
Function: ExpiringIn2Days
Function created to print all books expiring in less than 2 days.
    '''
    print("  Code  " , "       Title       " , "       Author       " , " Publication " , "    Publisher   " , "       User       " , " Expiration ")
    print("--------------------------------------------------------------------------------------------------------------------------")
    for Collection in Library:
        if Collection.DaysExpiration <= 2:
            print(f"{Collection.NumericalCode:<10} {Collection.Title:<20} {Collection.Author:<20} {Collection.Publication:<15} {Collection.Publisher:<20} {Collection.UserLoan:<20} {Collection.DaysExpiration:<10}")

# Execution starts here
Library = []
ThereIsABook = False
Exit = False

while not Exit:
    Choice = MenuChoice()

    if Choice == "1":
        Library , ThereIsABook = InsertBook(Library , ThereIsABook)

    elif Choice == "2":
        if ThereIsABook:
            print(f"The total number of books is: {TotalNumberOfBooks(Library)}")
        else:
            print("No books have been registered yet.")

    elif Choice == "3":
        if ThereIsABook:
            PrintAll(Library)
        else:
            print("No books have been registered yet.")

    elif Choice == "4":
        if ThereIsABook:
            PrintSortedByAuthor(Library)
        else:
            print("No books have been registered yet.")

    elif Choice == "5":
        if ThereIsABook:
            PrintNotOnLoanSortedByCode(Library)
        else:
            print("No books have been registered yet.")

    elif Choice == "6":
        if ThereIsABook:
            ExpiringIn2Days(Library)
        else:
            print("No books have been registered yet.")

    elif Choice == "7":
        Exit = ConfirmExit(Exit)

    else:
        print("Invalid option! Please choose a valid option.")
