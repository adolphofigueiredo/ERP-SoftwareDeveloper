'''

Author: Adolpho Silverio Figueiredo Neto
Date: 25/03/2024

First Exercise

Reorganize the program code of: "Managing number triplets" using functions.
For each menu option, call a different function.

'''

# Functions:

# Function: insert_triplet
def insert_triplet():
    # Formal parameters:
    A = int(input("\nEnter the first number: "))  # Input the first number.
    while A <= 0:  # Loop created to ensure the number is positive.
        A = int(input("\nError - The number must be positive!\nEnter the first number: "))
    B = int(input("\nEnter the second number: "))  # Input the second number.
    while B <= 0:  # Loop created to ensure the number is positive.
        B = int(input("\nError - The number must be positive!\nEnter the second number: "))
    C = int(input("\nEnter the third number: "))  # Input the third number.
    while C <= 0:  # Loop created to ensure the number is positive.
        C = int(input("\nError - The number must be positive!\nEnter the third number: "))
    # Return value:
    return A, B, C


# Function: print_triplet
def print_triplet(A, B, C):  # Definition created to print the numbers.
    # Formal parameters:
    print("The three entered numbers are: {} | {} | {}.".format(A, B, C))


# Function: max_number
def max_number(A, B, C):  # Definition created to find the largest number.
    # Formal parameters:
    max_num = A
    if max_num < B:
        max_num = B
    if max_num < C:
        max_num = C
    print("The largest number is {}.".format(max_num))
    # Return value:
    return max_num


# Function: min_number
def min_number(A, B, C):  # Definition created to find the smallest number.
    # Formal parameters:
    min_num = A
    if min_num > B:
        min_num = B
    if min_num > C:
        min_num = C
    print("The smallest number is {}.".format(min_num))
    # Return value:
    return min_num


# Function: average
def average(A, B, C):  # Definition created to calculate the arithmetic mean.
    # Formal parameters:
    sum_numbers = A + B + C
    avg = sum_numbers / 3
    print("\nThe arithmetic mean is {}.".format(avg))
    # Return value:
    return avg


# Function: ascending
def ascending(A, B, C):  # Definition created to arrange the numbers in ascending order.
    # Formal parameters:
    if A < B:
        if A < C:
            if B < C:
                print(A, B, C, sep=" | ")
                return A, B, C
            else:
                print(A, C, B, sep=" | ")
                return A, C, B
        else:
            print(C, A, B, sep=" | ")
            return C, A, B
    else:
        if A < C:
            print(B, A, C, sep=" | ")
            return B, A, C
        elif B < C:
            print(B, C, A, sep=" | ")
            return B, C, A
        else:
            print(C, B, A, sep=" | ")
            return C, B, A


# Function: descending
def descending(A, B, C):  # Definition created to arrange the numbers in descending order.
    # Formal parameters:
    if A < B:
        if A < C:
            if B < C:
                print(C, B, A, sep=" | ")
                return C, B, A
            else:
                print(B, C, A, sep=" | ")
                return B, C, A
        else:
            print(B, A, C, sep=" | ")
            return B, A, C
    else:
        if A < C:
            print(C, A, B, sep=" | ")
            return C, A, B
        elif B < C:
            print(A, C, B, sep=" | ")
            return A, C, B
        else:
            print(A, B, C, sep=" | ")
            return A, B, C


# Function: confirm_exit
def confirm_exit(exit_program):  # Definition created to confirm the exit.
    # Formal parameters:
    confirm = input("\nConfirm exit?\nY - Yes\nN - No\n")
    if confirm == "Y" or confirm == "y":
        exit_program = True
    # Return value:
        return exit_program

# Data input section

exit_program = False  # Variable that keeps the menu active.
has_num = False  # Variable created to check if the numbers have already been entered.

# Variable initializations

# Processing

while not exit_program:
    choice = input('''
Select one of the options:\n
    1. Enter number triplet
    2. Print triplet
    3. Print maximum
    4. Print minimum
    5. Print average
    6. Print in ascending order
    7. Print in descending order
    8. Exit\n''')
    match choice:
        case "1":
            num1, num2, num3 = insert_triplet()
            has_num = True  # Confirm that the numbers have been entered.
        case "2":
            if not has_num:  # Condition created to check the entry of the triplet.
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                print_triplet(num1, num2, num3)
        case "3":
            if not has_num:  # Condition created to check the entry of the triplet.
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                max_num = max_number(num1, num2, num3)  # I included the information about the maximum number in case I want to use it.
        case "4":
            if not has_num:  # Condition created to check the entry of the triplet.
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                min_num = min_number(num1, num2, num3)  # I included the information about the minimum number in case I want to use it.
        case "5":
            if not has_num:  # Condition created to check the entry of the triplet.
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                avg_num = average(num1, num2, num3)  # The average was calculated in the definition, but was included here so it can be used.
        case "6":
            if not has_num:  # Condition created to check the entry of the triplet.
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                asc_num1, asc_num2, asc_num3 = ascending(num1, num2, num3)  # The definition was created to arrange the numbers in ascending order.
                                                                             # I included the numbers here to understand how it works.
        case "7":
            if not has_num:  # Condition created to check the entry of the triplet.
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                desc_num1, desc_num2, desc_num3 = descending(num1, num2, num3)  # The definition was created to arrange the numbers in descending order.
                                                                              # I included the numbers here to understand how it works.
        case "8":
            exit_program = confirm_exit(exit_program)
        case _:
            print("\nError - Select one of the valid options!")

# Any subprocesses of Processing

# Output section
