'''
Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: Students

Create a program that asks the user to input their age and field of study. The
field of study is represented using the following table:

➔ 1 -> Computer Science
➔ 2 -> Physics
➔ 3 -> Mathematics

The output should display a message similar to the following:

➔ "Hello, you are 20 years old and study Computer Science."
➔ "Hello, you are 22 years old and study Mathematics."
'''

age = int(input("How old are you? "))
choice = int(input("\nSelect your field of study:\n➔ 1 -> Computer Science\n➔ 2 -> Physics\n➔ 3 -> Mathematics\n"))

match choice:
    case 1:
        print("Hello, you are {} years old and study Computer Science.".format(age))
    case 2:
        print("Hello, you are {} years old and study Physics.".format(age))
    case 3:
        print("Hello, you are {} years old and study Mathematics.".format(age))
    case _:
        print("Please select a valid option!")
