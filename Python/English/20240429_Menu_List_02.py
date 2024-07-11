'''
Author: Adolpho Silverio Figueiredo Neto
Date: 05/14/2024

Exercise 01

Write a program that allows the user to insert two lists (integer elements) and perform arithmetic operations with them. The operations are chosen by the user using the following menu:
1. Enter N (number of elements of the first list)
2. Enter M (number of elements of the second list)
3. Enter the N elements of the first list
4. Enter the M elements of the second list
5. Print the first list
6. Print the second list
7. Print the sum of the elements of the first list with the respective elements of the second list
8. Enter the number K, then search how many times K is present in the first list and indicate the positions
9. Exit (with confirmation)
Print an error message if the user tries to perform operations that require inputs that have not been entered.
'''

# Functions:

def show_menu():
    '''
    Function: show_menu
    Function to display the menu and get the selected input.

    Parameters:

    Return value:
    choice --> Variable created to choose the menu option.
    '''
    # Parameters:
    choice = input('''-----------------------------------------------------------------------------------------------------------------------
                                                    MENU
-----------------------------------------------------------------------------------------------------------------------
1. Enter N (number of elements of the first list)
2. Enter M (number of elements of the second list)
3. Enter the N elements of the first list
4. Enter the M elements of the second list
5. Print the first list
6. Print the second list
7. Print the sum of the elements of the first list with the respective elements of the second list
8. Enter the number K, then search how many times K is present in the first list and indicate the positions
9. Exit (with confirmation)
-----------------------------------------------------------------------------------------------------------------------
Select an option: ''')
    print("-----------------------------------------------------------------------------------------------------------------------")
    # Return value:
    return choice

def confirm_exit(should_exit):
    '''
    Function: confirm_exit
    Function to confirm exiting the program.

    Parameters:
    confirm --> Input required to confirm exiting the program.

    Return value:
    should_exit --> Variable that activates the confirmation to exit the program.
    '''
    # Parameters:
    confirm = input("Confirm exit?\nY - Yes\nN - No\n")
    if confirm in ["Y", "y"]:
        should_exit = True

    # Return value:
    return should_exit

def is_positive_number(num):
    '''
    Function: is_positive_number
    Function to check if the input is a positive number.

    Parameters:
    num --> Variable to be tested
    is_num --> Variable indicating if the tested number is a number or not.

    Return value:
    is_num --> bool
    '''
    # Parameters:
    is_num = True
    filter = "0123456789"  # Variable containing the characters that keep the control true.
    for x in num:  # Loop to test each digit of the variable num.
        if x not in filter:  # Condition to execute instructions after finding an unacceptable digit.
            is_num = False  # The variable becomes false because an unacceptable character was found.
            break  # After the loop encounters an unacceptable character, the loop ends.
    # Return value:
    return is_num

def is_number(num):
    '''
    Function: is_number
    Function to check if the input is a number.

    Parameters:
    num --> Variable to be tested
    is_num --> Variable indicating if the tested number is a number or not.

    Return value:
    is_num --> bool
    '''
    # Parameters:
    is_num = True
    filter = "-.0123456789"  # Variable containing the characters that keep the control true.
    for x in num:  # Loop to test each digit of the variable num.
        if x not in filter:  # Condition to execute instructions after finding an unacceptable digit.
            is_num = False  # The variable becomes false because an unacceptable character was found.
            break  # After the loop encounters an unacceptable character, the loop ends.
    # Return value:
    return is_num

def number_of_elements():
    '''
    Function: number_of_elements
    Function to determine the number of elements in the list.

    Parameters:

    Return value:
    num --> Number of elements in the list.
    '''
    # Parameters:
    is_num_positive = False

    while not is_num_positive:
        num = input("Enter the number of elements in the list: ")
        is_num_positive = is_positive_number(num)
    num = int(num)

    # Return value:
    return num

def insert_list(count):
    '''
    Function: insert_list
    Function to insert the elements of the list.

    Parameters:
    element --> Variable created to insert each element into the list.

    Return value:
    lst --> Variable created to store the list.
    '''
    # Parameters:
    lst = []
    for x in range(count):
        is_num = False
        while not is_num:
            element = input(f"Enter element {x+1}: ")
            is_num = is_number(element)
        element = float(element)
        lst += [element]

    # Return value:
    return lst

def sum_lists(n, m, lst1, lst2):
    '''
    Function: sum_lists
    Function to sum the elements of the lists based on the list with the smaller number of values.

    Parameters:
    n --> Number of elements in list 01.
    m --> Number of elements in list 02.
    lst1 --> List with N elements.
    lst2 --> List with M elements.
    loops --> Number of elements in the smaller list.

    Return value:
    lst_sum --> List with the sum of the two lists.
    '''
    # Parameters:
    lst_sum = []
    if n == m or n < m:
        loops = n
    else:
        loops = m
    for x in range(loops):
        lst_sum += [(lst1[x] + lst2[x])]
    # Return value:
    return lst_sum

def search_position(n, lst1):
    '''
    Function: search_position
    Function to search for a value, counting how many times it was found and where.

    Parameters:
    n --> Number of elements in list 01.
    k --> Value to be searched.

    Return value:
    search_count --> Counter created to count how many times the searched value was found
    positions --> List created to indicate in which positions the searched value was found
    '''
    # Parameters:
    positions = []
    search_count = 0
    is_num = False

    while not is_num:
        k = input("Enter the value to be searched: ")
        is_num = is_number(k)
    k = float(k)

    for x in range(n):
        if lst1[x] == k:
            search_count += 1
            positions += [x]
    # Return value:
    return search_count, positions, k

# Variable Initializations
should_exit = False
n_inserted = False
m_inserted = False
lst1_inserted = False
lst2_inserted = False

# Processing
while not should_exit:
    choice = show_menu()
    match choice:
        case "1":
            n = number_of_elements()
            n_inserted = True
            lst1_inserted = False
        case "2":
            m = number_of_elements()
            m_inserted = True
            lst2_inserted = False
        case "3":
            if not n_inserted:
                print("\n*****   Error - You need to enter N first.   *****")
            else:
                lst1 = insert_list(n)
                lst1_inserted = True
        case "4":
            if not m_inserted:
                print("\n*****   Error - You need to enter M first.   *****")
            else:
                lst2 = insert_list(m)
                lst2_inserted = True
        case "5":
            if not n_inserted:
                print("\n*****   Error - You need to enter N first.   *****")
            if not lst1_inserted:
                print("\n*****   Error - You need to enter the first list first.   *****")
            if n_inserted and lst1_inserted:
                print(lst1)
        case "6":
            if not m_inserted:
                print("\n*****   Error - You need to enter M first.   *****")
            if not lst2_inserted:
                print("\n*****   Error - You need to enter the second list first.   *****")
            if m_inserted and lst2_inserted:
                print(lst2)
        case "7":
            if not n_inserted:
                print("\n*****   Error - You need to enter N first.   *****")
            if not lst1_inserted:
                print("\n*****   Error - You need to enter the first list first.   *****")
            if not m_inserted:
                print("\n*****   Error - You need to enter M first.   *****")
            if not lst2_inserted:
                print("\n*****   Error - You need to enter the second list first.   *****")
            if n_inserted and m_inserted and lst1 and lst2:
                lst_sum = sum_lists(n, m, lst1, lst2)
                print("List 01: ", lst1)                
                print("List 02: ", lst2)
                print("Sum:    ", lst_sum)
        case "8":
            if not n_inserted:
                print("\n*****   Error - You need to enter N first.   *****")
            if not lst1_inserted:
                print("\n*****   Error - You need to enter the first list first.   *****")
            if n_inserted and lst1_inserted:
                search_count, positions, k = search_position(n, lst1)
                if search_count == 0:
                    print(f"\nThe number {k} was not found.")
                elif search_count == 1:
                    print(f"\nThe number {k} was found {search_count} time at position {positions}.")
                else:
                    print(f"\nThe number {k} was found {search_count} times at positions {positions}.")
        case "9":
            should_exit = confirm_exit(should_exit)
        case _:
            print("\n*****   Error - You need to select one of the valid options.   *****")