'''

Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: Intervals [OPTIONAL]

Create a program that asks the user to enter an integer. The program
must recognize if that number is within one of the following intervals:

➔ [15,18] --> from 15 to 18 inclusive.
➔ [39,45) --> from 39 to 45 with 39 included and 45 excluded.
➔ (91,103) --> from 91 to 103 with 91 and 103 excluded.

Examples:

User enters 42 --> "The number 42 is valid."
User enters 32 --> "The number 32 entered is not valid."

'''

number = int(input("Enter an integer: "))

if (number >= 15 and number <= 18) or (number >= 39 and number < 45) or (number > 91 and number < 103):
    print("The number {} entered is valid.".format(number))
else:
    print("The number {} entered is not valid.".format(number))
