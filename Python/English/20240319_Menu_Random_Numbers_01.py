'''
Author: Adolpho Silverio Figueiredo Neto
Date: 19/03/2024

Exercise: Choice Menu (Random Numbers)
Write a program that displays the following choice menu:

1. Enter N, A, and B (integers)
2. Arithmetic mean of N rolls of a six-sided die
3. Draw and print 10 random numbers between A and B
4. Arithmetic mean of N random numbers drawn between A and B
5. Exit (with confirmation)

'''

# Input Data Section

import random as rd  # Import and rename for convenience later.

# Variable initializations

exit_menu = False  # Variable to keep the menu active.
hasA = False  # Variable to check if variable A exists
hasB = False  # Variable to check if variable B exists
hasN = False  # Variable to check if variable N exists

# Processing

while exit_menu == False:  # Add comments
    choice = input('''\n
Select one of the options:\n
    1. Enter N, A, and B
    2. Arithmetic mean of N rolls of a six-sided die
    3. Draw and print 10 random numbers between A and B
    4. Arithmetic mean of N random numbers drawn between A and B
    5. Exit\n\n''')
    match choice:
        case "1":
            N = int(input("Enter the number of data points to insert: "))  # Number of data points to insert
            while N <= 0:  # Loop to ensure the number of data points to insert is positive.
                N = int(input("\nError - The number must be positive!\n\nEnter the number of data points to insert: "))
            hasN = True  # Variable to indicate that N has a value
            A = int(input("Enter the first number (A): "))
            B = int(input("Enter the second number (B): "))
            while A >= B:  # Loop to ensure that A is less than B
                A = int(input("\nError - The first number must be less than the second number!\n\nEnter the first number (A): "))
                B = int(input("Enter the second number (B): "))
            hasA = True  # Variable to indicate that A has a value
            hasB = True  # Variable to indicate that B has a value
        case "2":
            if hasN:  # Condition to check if N has a value
                roll_accumulator = 0  # This accumulator is declared here to avoid starting option 2 with a full accumulator
                for i in range(1, N + 1):  # Loop to roll the die
                    roll = rd.randrange(1, 7)
                    print(roll, end=" | ")
                    roll_accumulator += roll  # Accumulator to calculate the mean
                roll_mean = roll_accumulator / N  # Calculate the mean
                print("\nThe arithmetic mean of {} rolls is {}.".format(N, roll_mean))
            else:  # Condition to indicate an error
                print("\nBefore selecting this option, you must determine a value for N.")
        case "3":
            if hasA and hasB:  # Condition to check if A and B have values
                for i in range(1, 11):  # Print 10 random numbers between A and B
                    print(rd.randrange(A, B + 1), end=" | ")
            else:  # Condition to indicate an error
                print("\nBefore selecting this option, you must determine values for A and B.")
        case "4":
            if hasA and hasB and hasN:  # Condition to check if N, A, and B have values
                random_accumulator = 0  # This accumulator is declared here to avoid starting option 4 with a full accumulator
                for i in range(1, N + 1):  # Loop to generate numbers
                    random_num = rd.randrange(A, B + 1)
                    print(random_num, end=" | ")
                    random_accumulator += random_num  # Accumulator to calculate the mean
                random_mean = random_accumulator / N  # Calculate the mean
                print("\nThe arithmetic mean of {} random numbers is {}.".format(N, random_mean))
            else:  # Condition to indicate an error
                print("\nBefore selecting this option, you must determine values for N, A, and B.")
        case "5":
            confirm = input("\nConfirm exit?\nY - Yes\nN - No\n")
            if confirm == "Y" or confirm == "y":  # Condition to confirm exit.
                exit_menu = True
        case _:
            print("\nError - Select one of the valid options!")

# Any additional processing

# Output Section
