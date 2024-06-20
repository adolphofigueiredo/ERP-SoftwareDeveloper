'''
Author: Adolpho Silverio Figueiredo Neto
Date: 19/03/2024

Exercise: Choice Menu (Random Numbers)
Write a program that shows the following choice menu:

1. Enter N, A, and B (integers)
2. Arithmetic mean of N rolls of a six-sided die
3. Draw and print 10 random numbers between A and B
4. Arithmetic mean of N random numbers drawn between A and B
5. Exit (with confirmation)

'''

# Data Input Section

import random as rd  # Import and rename for convenience later.

# Variable Initializations

exit = False  # Create a variable to keep the menu active.
hasA = False  # Variable created to know if variable A exists
hasB = False  # Variable created to know if variable B exists
hasN = False  # Variable created to know if variable N exists

# Processing

while not exit:  # Add comments
    choice = input('''\n
Select one of the options:\n
    1. Enter N, A, and B
    2. Arithmetic mean of N rolls of a six-sided die
    3. Draw and print 10 random numbers between A and B
    4. Arithmetic mean of N random numbers drawn between A and B
    5. Exit\n\n''')
    match choice:
        case "1":
            N = int(input("Enter the number of data to be inserted: "))  # Number of data to be inserted
            while N <= 0:  # Loop created to ensure the number of data to be inserted is positive.
                N = int(input("\nError - The number must be positive!\n\nEnter the number of data to be inserted: "))
            hasN = True  # Argument that informs that variable N has a value
            A = int(input("Enter the first number (A): "))
            B = int(input("Enter the second number (B): "))
            while A >= B:  # Loop created to ensure that A is less than B
                A = int(input("\nError - The first number must be less than the second number!\n\nEnter the first number (A): "))
                B = int(input("Enter the second number (B): "))
            hasA = True  # Argument that informs that variable A has a value
            hasB = True  # Argument that informs that variable B has a value
        case "2":
            if hasN:  # Condition created to check if N has a value
                roll_accumulator = 0  # This accumulator is declared here to prevent option 2 from starting with a full accumulator
                for i in range(1, N + 1):  # Loop created to roll the die
                    roll = rd.randrange(1, 7)
                    print(roll, end=" | ")
                    roll_accumulator += roll  # Accumulator created to calculate the mean
                mean_roll = roll_accumulator / N  # Calculate the mean
                print("\nThe arithmetic mean of {} rolls is {}.".format(N, mean_roll))
            else:  # Condition created to signal the error
                print("\nBefore selecting this option, you need to set a value for N.")
        case "3":
            if hasA and hasB:  # Condition created to check if A and B have values
                for i in range(1, 10 + 1):  # Print 10 random numbers between A and B
                    print(rd.randrange(A, B + 1), end=" | ")
            else:  # Condition created to signal the error
                print("\nBefore selecting this option, you need to set values for A and B.")
        case "4":
            if hasA and hasB and hasN:  # Condition created to check if N, A, and B have values
                random_accumulator = 0  # This accumulator is declared here to prevent option 4 from starting with a full accumulator
                for i in range(1, N + 1):  # Loop created to generate the numbers
                    random_num = rd.randrange(A, B + 1)
                    print(random_num, end=" | ")
                    random_accumulator += random_num  # Accumulator created to calculate the mean.
                mean_random = random_accumulator / N  # Calculate the mean.
                print("\nThe arithmetic mean of {} numbers is {}.".format(N, mean_random))                
            else:  # Condition created to signal the error
                print("\nBefore selecting this option, you need to set values for N, A, and B.")
        case "5":
            confirm = input("\nConfirm exit?\nY - Yes\nN - No\n")
            if confirm == "Y" or confirm == "y":  # Condition created to confirm exit.
                exit = True
        case _:
            print("\nError - Select a valid option!")

# Any subprocesses for processing

# Output Section
