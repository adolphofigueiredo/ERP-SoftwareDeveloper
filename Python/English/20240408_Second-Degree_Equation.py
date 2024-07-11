'''

Author: Adolpho Silverio Figueiredo Neto
Date: 08/04/2024

Third Exercise

Write a program that calculates the solutions of a second-degree equation in the form ax2 + bx + c = 0. The program should display the following menu:

1. Enter coefficients (a, b, c)

2. Calculate the discriminant (delta = b*b - 4*a*c)

3. Calculate the solutions

4. Exit

When a calculation option is selected, print the calculated result. Each option should be handled by a function. The functions should use global variables.

'''


# Functions:


# Function: Menu
def Menu():                                                # Function that prints the menu.
    # Formal parameters:
    global choice                                          # Declare the variable as global.
    choice = input('''
Select one of the options:
    
    1. Enter coefficients (a, b, c)

    2. Calculate the discriminant (delta = b*b - 4*a*c)

    3. Calculate the solutions

    4. Exit\n
''')


# Function: EnterCoefficients
def EnterCoefficients():                                   # Function that requests the coefficients.
    # Formal parameters:
    global a, b, c, HasCoef                                # Declare the variable as global.
    a = int(input("\nEnter coefficient A: "))              # Request variable A.   
    b = int(input("\nEnter coefficient B: "))              # Request variable B.   
    c = int(input("\nEnter coefficient C: "))              # Request variable C.
    HasCoef = True                                         # Change the global variable HasCoef to indicate that coefficients have been entered.


# Function: CalculateDiscriminant
def CalculateDiscriminant():                               # Function that calculates the discriminant.
    # Formal parameters:
    global HasDiscr, delta                                 # Declare the variable as global.
    if not HasCoef:                                        # Condition to check if the discriminant can be calculated.
        print("\nError! - You must enter the coefficients before selecting this option.")
    else:
        delta = (b * b) - (4 * a * c)                      # Calculate the delta.
        print("\nThe delta is {}.".format(delta))          # Print the result.
        HasDiscr = True                                    # Change the global variable HasDiscr to indicate that the discriminant has been calculated.


# Function: CalculateSolutions
def CalculateSolutions():                                  # Function that calculates the solutions.
    # Formal parameters:
    global x, x1, x2                                       # Declare the variable as global.
    if not HasCoef:                                        # Condition to check if the solutions can be calculated.
        print("\nError! - You must enter the coefficients before selecting this option.")
    elif not HasDiscr:                                     # Condition to check if the solutions can be calculated.
        print("\nError! - You must calculate the discriminant before selecting this option.")        
    else:
        if delta < 0:                                      # Condition to determine how to calculate the solutions.
            print("The delta is less than zero, so the result is impossible.")
        elif delta == 0:
            x = - b / (2 * a)
            print("The solution is: ", x)
        else:
            x1 = (-b + (delta ** 0.5)) / (2 * a)
            x2 = (-b - (delta ** 0.5)) / (2 * a)
            print("The possible solutions are: {} and {}.".format(x1, x2))


# Function: Exit
def Exit():                                                # Function that confirms exit.
    # Formal parameters:
    global loop                                            # Declare the variable as global.
    confirm = "x"                                          # Initialize the variable to confirm exit.
    while confirm != "S" and confirm != "s" and confirm != "N" and confirm != "n":  # Loop to ensure the user chooses one of the options.
        confirm = input("\nAre you sure you want to exit?\nS - Yes\nN - No\n\n")    # Confirmation prompt.
        if confirm == "S" or confirm == "s":                                       # Condition to confirm exit.
            loop = False                                 # Change the global variable loop so the loop can exit.


# Function: Error
def Error():                                               # Function that informs about the error that occurred.
    # Formal parameters:
    print("\nError - You must choose one of the mentioned options!!")


# Variable initializations

loop = True                                                # Variable created to keep the menu loop active.
HasCoef = False                                            # Variable created to indicate that coefficients have been entered.
HasDiscr = False                                           # Variable created to indicate that the discriminant has been calculated.


# Processing

while loop == True:
    Menu()                                                 # Activate the Menu function.
    match choice:
        case "1":                                          # Start actions to be executed when the user selects this value.
            EnterCoefficients()                            # Activate the EnterCoefficients function.
        case "2":                                          # Start actions to be executed when the user selects this value.
            CalculateDiscriminant()                        # Activate the CalculateDiscriminant function.
        case "3":                                          # Start actions to be executed when the user selects this value.
            CalculateSolutions()                           # Activate the CalculateSolutions function.
        case "4":                                          # Start actions to be executed when the user selects this value.
            Exit()                                         # Activate the Exit function.
        case _:                                            # Start actions to be executed when the user selects a value other than those above.
            Error()                                        # Activate the Error function.
