'''

Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: Lottery Ticket

Create a program that reads the position of the winning ticket and indicates the prize amount in the output.

➔ prize for position number 1 = 5,000,000€
➔ prize for position number 2 = 2,000,000€
➔ prize for position number 3 = 1,000,000€
➔ prize for position number 4 = 500,000€
➔ prize for position number 5 = 200,000€
➔ for all other positions there is no prize

'''

position = int(input("Enter the position of the winning ticket: "))

match position:
    case 1:
        print("The prize for the first position is 5,000,000€.")
    case 2:
        print("The prize for the second position is 2,000,000€.")
    case 3:
        print("The prize for the third position is 1,000,000€.")
    case 4:
        print("The prize for the fourth position is 500,000€.")
    case 5:
        print("The prize for the fifth position is 200,000€.")
    case _:
        print("There is no prize for this position.")
