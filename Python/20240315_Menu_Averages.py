'''
Author: Adolpho Silverio Figueiredo Neto
Date: 15/03/2024

Exercise: Averages (choice menu)
Create a program that presents the following menu:
1. Enter N (integer)
2. Enter the numbers A and B
3. Enter N values and print the maximum
4. Enter N values and print the arithmetic mean of the values between A and B
5. Exit
Exit with confirmation.

'''

# Data Input Section

# Variable Initializations

running = True
n = 0
sum_values = 0
count_values = 0

# Processing

while running:
    choice = input('''
                    1. Enter N (integer)
                    2. Enter the numbers A and B
                    3. Enter N values and print the maximum
                    4. Enter N values and print the arithmetic mean of the values between A and B
                    5. Exit\n
                   ''')
    match choice:
        case "1":
            n = int(input("\nEnter the number of values to input: "))
            while n <= 0:
                n = int(input("\nThe number must be positive!\n\nEnter the number of values to input: "))
        case "2":
            a = int(input("\nEnter the first number (A): "))
            b = int(input("\nEnter the second number (B): "))
        case "3":
            counter = 1
            value = int(input("\nEnter value {}: ".format(counter)))
            max_value = value
            for i in range(1, n):
                counter += 1
                value = int(input("\nEnter value {}: ".format(counter)))
                if value > max_value:
                    max_value = value
            print("\nThe maximum value entered is {}.".format(max_value))
        case "4":
            counter = 1
            for i in range(1, n + 1):
                value = int(input("\nEnter value {}: ".format(counter)))
                counter += 1
                if (a >= value >= b) or (a <= value <= b):
                    sum_values += value
                    count_values += 1
            if count_values > 0:
                print("\n\nThe arithmetic mean of the values between {} and {} is {}.".format(a, b, sum_values / count_values))
            else:
                print("\n\nNo values between {} and {} were entered.".format(a, b))
        case "5":
            confirm = input("Confirm exit?\nS - Yes\nN - No\n")
            if confirm.lower() == "s":
                running = False
        case _:
            print("\nSelect a valid option!\n")

# Any sub-processes of Processing

# Output Section
