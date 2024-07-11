'''
Author: Adolpho Silverio Figueiredo Neto
Date: 25/03/2024

First Exercise

Reorganize the code of the "Management of Triplets of Numbers" program using functions. For each menu option, call a different function.

'''

# Functions:

# Function: input_triplet
def input_triplet():
    A = int(input("\nEnter the first number: "))
    while A <= 0:
        A = int(input("\nError - The number must be positive!\nEnter the first number: "))
        
    B = int(input("\nEnter the second number: "))
    while B <= 0:
        B = int(input("\nError - The number must be positive!\nEnter the second number: "))
        
    C = int(input("\nEnter the third number: "))
    while C <= 0:
        C = int(input("\nError - The number must be positive!\nEnter the third number: "))
        
    return A, B, C

# Function: print_triplet
def print_triplet(A, B, C):
    print("The three numbers entered are: {} | {} | {}.".format(A, B, C))

# Function: maximum
def maximum(A, B, C):
    max_value = A
    if max_value < B:
        max_value = B
    if max_value < C:
        max_value = C
    print("The largest number is {}.".format(max_value))
    return max_value

# Function: minimum
def minimum(A, B, C):
    min_value = A
    if min_value > B:
        min_value = B
    if min_value > C:
        min_value = C
    print("The smallest number is {}.".format(min_value))
    return min_value

# Function: average
def average(A, B, C):
    sum_values = A + B + C
    avg_value = sum_values / 3
    print("\nThe arithmetic mean is {}.".format(avg_value))
    return avg_value

# Function: ascending_order
def ascending_order(A, B, C):
    if A <= B <= C:
        print(A, B, C, sep=" | ")
        return A, B, C
    elif A <= C <= B:
        print(A, C, B, sep=" | ")
        return A, C, B
    elif B <= A <= C:
        print(B, A, C, sep=" | ")
        return B, A, C
    elif B <= C <= A:
        print(B, C, A, sep=" | ")
        return B, C, A
    elif C <= A <= B:
        print(C, A, B, sep=" | ")
        return C, A, B
    else:
        print(C, B, A, sep=" | ")
        return C, B, A

# Function: descending_order
def descending_order(A, B, C):
    if A >= B >= C:
        print(A, B, C, sep=" | ")
        return A, B, C
    elif A >= C >= B:
        print(A, C, B, sep=" | ")
        return A, C, B
    elif B >= A >= C:
        print(B, A, C, sep=" | ")
        return B, A, C
    elif B >= C >= A:
        print(B, C, A, sep=" | ")
        return B, C, A
    elif C >= A >= B:
        print(C, A, B, sep=" | ")
        return C, A, B
    else:
        print(C, B, A, sep=" | ")
        return C, B, A

# Function: Confirm Exit
def confirm_exit(exit_flag):
    confirm = input("\nConfirm exit?\nY - Yes\nN - No\n")
    if confirm == "Y" or confirm == "y":
        exit_flag = True
    return exit_flag

# Data Input Section

exit = False  # Variable to keep the menu active.
has_numbers = False  # Variable to track if numbers have been entered.

# Processing

while not exit:
    choice = input('''
Select one of the options:\n
    1. Input triplet of numbers
    2. Print triplet
    3. Print maximum
    4. Print minimum
    5. Print average
    6. Print ascending order
    7. Print descending order
    8. Exit\n''')
    
    match choice:
        case "1":
            num1, num2, num3 = input_triplet()
            has_numbers = True
        case "2":
            if not has_numbers:
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                print_triplet(num1, num2, num3)
        case "3":
            if not has_numbers:
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                max_num = maximum(num1, num2, num3)
        case "4":
            if not has_numbers:
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                min_num = minimum(num1, num2, num3)
        case "5":
            if not has_numbers:
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                avg_num = average(num1, num2, num3)
        case "6":
            if not has_numbers:
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                num1_asc, num2_asc, num3_asc = ascending_order(num1, num2, num3)
        case "7":
            if not has_numbers:
                print("Before selecting this option, you need to select option 1 and enter the triplet of numbers.")
            else:
                num1_desc, num2_desc, num3_desc = descending_order(num1, num2, num3)
        case "8":
            exit = confirm_exit(exit)
        case _:
            print("\nError - Select a valid option!")

# Output Section
