'''

Author: Adolpho Silverio Figueiredo Neto
Date: 15/03/2024

Macro-Flow

'''

# Data input section



# Variable initializations
    
exit_program = False

# Processing

while exit_program == False:
    choice = input("Select one of the options:\n1 - XXXXXXXXX\n2 - XXXXXXXXXX\n3 - Exit\n")
    match choice:
        case "1":
            print("Choice 1")
        case "2":
            print("Choice 2")
        case "3":
            print("Choice 3")
            confirm = input("Confirm exit?\nY - Yes\nN - No\n")
            if confirm == "y" or confirm == "Y":
                exit_program = True
        case _:
            print("\nError\n")

# Any subprocesses of Processing



# Output section



