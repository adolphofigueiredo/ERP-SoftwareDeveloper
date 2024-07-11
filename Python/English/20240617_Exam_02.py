'''
Author: Adolpho Silverio Figueiredo Neto
Category: Student - Fundamentals of Programming
Date: 17/06/2024

You want to manage a phone book by building a Python application. Contacts are defined by the following information:
first name, last name, phone number, email, and category. Create a program that prints a choice menu with the following options:

1. Insert N contacts
2. Print the total number of contacts
3. Print the last name, first name, phone number, and email of all contacts
4. Print all contacts sorted by last name (print last name, first name, and phone number)
5. Search for a contact given the last name and first name (print last name, first name, and all contact fields)
6. Print contacts of a particular category entered as input, sorted by last name and first name
7. Exit

'''

from dataclasses import dataclass # Import the dataclasses library and use dataclass to combine a new type of data structure.

# Data Structure Definition

@dataclass  # Class created to store all necessary information.
class Contact:  # Determination of the class name.
    First_Name: str  # Field belonging to the contact class.
    Last_Name: str  # Field belonging to the contact class.
    Phone: str  # Field belonging to the contact class.
    email: str  # Field belonging to the contact class.
    Category: str  # Field belonging to the contact class.

# Functions:

# Function:

def MenuChoice() -> str:
    '''
Function: MenuChoice
Function created to print the menu and receive the selected input.

Return value:
Choice --> Variable created to choose the menu option.
    '''
    # Formal parameters:  # Print the menu options and their respective codes
    Choice = input('''-----------------------------------------------------------------------------------------------------------------------------------
                                                               MENU
-----------------------------------------------------------------------------------------------------------------------------------
1. Insert N contacts
2. Print the total number of contacts
3. Print the last name, first name, phone number, and email of all contacts
4. Print all contacts sorted by last name and first name (print last name, first name, and phone number)
5. Search for a contact given the last name and first name (print last name, first name, and all contact fields)
6. Print contacts of a particular category entered as input, sorted by last name and first name
7. Exit
-----------------------------------------------------------------------------------------------------------------------------------
Select one of the options: ''')
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    
    # Return value:
    
    return Choice  # Return the variable that determines which option will be selected

# Function:

def ConfirmExit(Exit) -> bool:
    '''
Function: ConfirmExit
Function created to confirm the exit from the program.

Formal parameters:
Confirm --> Input required to confirm the exit from the program.

Return value:
Exit --> Variable that activates the exit confirmation from the program.
    '''
    # Formal parameters:
    
    Confirm = input("Do you confirm the exit?\n\nY - Yes\nN - No\n")  # Input confirmation of program exit.
    if (Confirm == "Y") or (Confirm == "y"):  # Condition that understands if the exit confirmation can be triggered.
        Exit = True  # Change the variable that confirms the exit from the program.

    # Return value:

    return Exit  # Return the variable that authorizes the closure and exit from the program.

# Function:
def EmptyContact():
    '''
Function: EmptyContact
Function created to print the reason for the error caused when this menu option is selected.

Formal parameters:
Only the error message informing what happened has been entered.
    '''

# Formal parameters:

    print("                       *****   Error - It is necessary to insert at least one contact in the list first.   *****")

# Function:
def ExitInsertion(Insertion: bool) -> bool:
    '''
Function: ExitInsertion
Function created to keep the contact insertion loop active.

Formal parameters:
ConfirmContact --> Input required to confirm the exit from the loop to register a new contact.

Return value:
Insertion --> Variable that keeps the loop active to register a new contact.
    '''

# Formal parameters:

    print("-----------------------------------------------------------------------------------------------------------------------------------")    
    ConfirmContact = input("Do you want to insert a new contact?\n\nY - Yes\nN - No\n")  # Input confirmation to register a new contact.
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    if (ConfirmContact == "N") or (ConfirmContact == "n"):  # Condition that understands if the exit confirmation can be triggered.
        Insertion = False  # Change the variable that controls the continuation of new contact registrations.

# Return value:

    return Insertion

# Function:
def InsertContact(Contacts: list, ThereIsAContact: bool):
    '''
Function: InsertContact
Function created to insert the desired contacts as many times as the user wants, this option can also be used as many times as desired without the need to determine the number of contacts that will be initially registered.

Formal parameters:
Insertion --> Variable that keeps the loop active to register a new contact.
First_Name --> Variable that receives the first name.
Last_Name --> Variable that receives the last name.
Phone --> Variable that receives the phone number.
email --> Variable that receives the email.
Category --> Variable that receives the category. 

Return value:
Contacts --> List that will store information about all contacts.
ThereIsABook  --> Variable that informs if a contact has already been registered or not.
    '''

# Formal parameters:

    Insertion = True  # Variable that confirms entry into the loop to register a new contact.
            
    while Insertion:  # Loop created to register a new contact.

        First_Name = ""
        while not First_Name:  # Loop created to check if the entered information can be registered.
            First_Name = input("Enter the contact's first name: ")
        
        Last_Name = ""
        while not Last_Name:  # Loop created to check if the entered information can be registered.
            Last_Name = input("Enter the contact's last name: ")
        
        Phone = ""
        while not Phone:  # Loop created to check if the entered information can be registered.
            Phone = input("Enter the contact's phone number: ")

        email = ""
        while not email:  # Loop created to check if the entered information can be registered.
            email = input("Enter the contact's email: ")

        Category = ""
        while not Category:  # Loop created to check if the entered information can be registered.
            Category = input("Enter the contact's category: ")

        Contacts.append(Contact(First_Name, Last_Name, Phone, email, Category))          
        
        Insertion = ExitInsertion(Insertion)
            
    ThereIsAContact = True  # Activation of the variable that informs that a contact has already been registered.

# Return value:

    return Contacts, ThereIsAContact

# Function:
def TotalNumberOfContacts(Contacts: list) -> int:
    '''
Function: TotalNumberOfContacts
Function created to count the total number of contacts entered.

Return value:
Contacts --> List that will store information about all contacts.
    '''

# Return value:

    return len(Contacts)  # Function that counts how many contacts have been added to the list.

# Function:
def PrintAll(Contacts: list):
    '''
Function: PrintAll
Function created to print all contacts entered in the list.
    '''
# Formal parameters:

    print("      Last Name       ", "      First Name      ", "      Phone Number      ", "               email               ", "      Category     ")
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    for Contact in Contacts:  # Loop created to print all contacts in the contacts list.
        print(f"{Contact.Last_Name:<20} {Contact.First_Name:<16} {Contact.Phone:<20} {Contact.email:<35} {Contact.Category:<20}")

# Function:
def PrintAllWithoutCategory(Contacts: list):
    '''
Function: PrintAllWithoutCategory
Function created to print all contacts entered in the list without the category field.
    '''
# Formal parameters:

    print("      Last Name       ", "      First Name      ", "      Phone Number      ", "               email               ")
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    for Contact in Contacts:  # Loop created to print all contacts in the contacts list.
        print(f"{Contact.Last_Name:<20} {Contact.First_Name:<16} {Contact.Phone:<20} {Contact.email:<35}")

# Function:
def SortByFirstName(Contacts: list) -> list:
    '''
Function: SortByFirstName
Function created to sort all contacts by first name.

Return value:
Contacts --> List that will store information about all contacts.
    '''
# Formal parameters:
      
    for i in range(len(Contacts)):
        for j in range(i, len(Contacts)):
            if Contacts[i].First_Name > Contacts[j].First_Name:
                Contacts[i], Contacts[j] = Contacts[j], Contacts[i]

# Return value:

    return Contacts

# Function:
def SortByLastName(Contacts: list) -> list:
    '''
Function: SortByLastName
Function created to sort all contacts by last name.

Return value:
Contacts --> List that will store information about all contacts.
    '''
# Formal parameters:
      
    for i in range(len(Contacts)):
        for j in range(i, len(Contacts)):
            if Contacts[i].Last_Name > Contacts[j].Last_Name:
                Contacts[i], Contacts[j] = Contacts[j], Contacts[i]

# Return value:

    return Contacts

# Function:
def PrintLastNameFirstNamePhone(Contacts: list):
    '''
Function: PrintLastNameFirstNamePhone
Function created to print the last name, first name, and phone number of all contacts in the list.
    '''
# Formal parameters:

    Contacts = SortByLastName(Contacts)  # Function that sorts contacts by last name.
    
    print("      Last Name       ", "      First Name      ", "      Phone Number      ")
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    for Contact in Contacts:  # Loop created to print all contacts in the contacts list.
        print(f"{Contact.Last_Name:<20} {Contact.First_Name:<16} {Contact.Phone:<20}")

# Function:
def SearchContact(Contacts: list):
    '''
Function: SearchContact
Function created to search for a specific contact and print their information.

Formal parameters:
last_name --> Variable that receives the last name.
first_name --> Variable that receives the first name.
Contacts --> List that will store information about all contacts.
    '''

# Formal parameters:

    last_name = input("Enter the contact's last name to search: ")
    first_name = input("Enter the contact's first name to search: ")
    
    found = False  # Variable created to return the result of the search.
    
    for Contact in Contacts:  # Loop created to search for contacts in the contacts list.
        if (Contact.Last_Name == last_name) and (Contact.First_Name == first_name):
            print("-----------------------------------------------------------------------------------------------------------------------------------")
            print(f"\nLast Name: {Contact.Last_Name}\nFirst Name: {Contact.First_Name}\nPhone: {Contact.Phone}\nEmail: {Contact.email}\nCategory: {Contact.Category}\n")
            found = True  # Activation of the variable that informs if the contact was found or not.
    if not found:
        print("-----------------------------------------------------------------------------------------------------------------------------------")
        print("Contact not found.")

# Function:
def PrintContactsByCategory(Contacts: list):
    '''
Function: PrintContactsByCategory
Function created to print the list of contacts by category.

Formal parameters:
category --> Variable that receives the contact's category.
    '''

# Formal parameters:

    category = input("Enter the category of the contacts to be printed: ")
    print("-----------------------------------------------------------------------------------------------------------------------------------")
    
    Contacts = SortByLastName(Contacts)  # Function that sorts contacts by last name.
    
    found = False  # Variable created to return the result of the search.
    
    for Contact in Contacts:  # Loop created to print all contacts in the contacts list.
        if Contact.Category == category:
            print("-----------------------------------------------------------------------------------------------------------------------------------")
            print(f"{Contact.Last_Name:<20} {Contact.First_Name:<16} {Contact.Phone:<20} {Contact.email:<35} {Contact.Category:<20}")
            found = True  # Activation of the variable that informs if the contact was found or not.
    if not found:
        print("-----------------------------------------------------------------------------------------------------------------------------------")
        print("Category not found.")

# Main Code:
'''
Variable Initializations:
Exit --> Variable created to control the program execution loop.
ThereIsAContact --> Variable that informs if a contact has already been registered or not.
Contacts --> List that will store information about all contacts.
'''
Exit = False  # Initial value that informs that the program is running and has not been exited yet.
ThereIsAContact = False  # Initial value that informs if a contact has already been registered or not.
Contacts = []  # Creation of the list that will store the registered contacts.

'''
Processing:
'''
while not Exit:
    Choice = MenuChoice()  # Activation of the function that prints the menu.
    
    match Choice:  # Structure created to control the option selection and execution.
        
        case "1":
            Contacts, ThereIsAContact = InsertContact(Contacts, ThereIsAContact)  # Activation of the function that inserts the contacts.
        
        case "2":
            if not ThereIsAContact:
                EmptyContact()  # Activation of the function that prints the error message.
            else:
                NumberOfContacts = TotalNumberOfContacts(Contacts)  # Activation of the function that counts the number of registered contacts.
                if NumberOfContacts == 1:
                    print(f"So far, {NumberOfContacts} contact has been registered.")
                else:
                    print(f"So far, {NumberOfContacts} contacts have been registered.")
        
        case "3":
            if not ThereIsAContact:
                EmptyContact()  # Activation of the function that prints the error message.
            else:
                PrintAll(Contacts)  # Activation of the function that prints all contacts.
        
        case "4":
            if not ThereIsAContact:
                EmptyContact()  # Activation of the function that prints the error message.
            else:
                PrintLastNameFirstNamePhone(Contacts)  # Activation of the function that prints contacts sorted by last name.
        
        case "5":
            if not ThereIsAContact:
                EmptyContact()  # Activation of the function that prints the error message.
            else:
                SearchContact(Contacts)  # Activation of the function that searches for a specific contact.
        
        case "6":
            if not ThereIsAContact:
                EmptyContact()  # Activation of the function that prints the error message.
            else:
                PrintContactsByCategory(Contacts)  # Activation of the function that prints contacts by category.
        
        case "7":
            Exit = ConfirmExit(Exit)  # Activation of the function that confirms the exit from the program.
        
        case _:
            print("                              *****   Error - It is necessary to select one of the valid options.   *****")

print('''-----------------------------------------------------------------------------------------------------------------------------------
                                                               END
-----------------------------------------------------------------------------------------------------------------------------------''')
