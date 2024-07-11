'''
Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: Date format
Enter a date in the format DDMMYYYY by inputting three numbers DD, MM, and YYYY.
Verify if the entered date is correct, that is, if it represents a real date.
'''

DD = int(input("Enter the day: "))
MM = int(input("Enter the month: "))
YYYY = int(input("Enter the year: "))

if MM <= 12 and DD <= 31 and YYYY >= 0:
    if MM == 1 or MM == 3 or MM == 5 or MM == 7 or MM == 8 or MM == 10 or MM == 12:
        print("It is a correct date!")
    elif MM == 4 or MM == 6 or MM == 9 or MM == 11:
        if DD <= 30:
            print("It is a correct date!")
        else:
            print("It is not a correct date!")
    elif MM == 2:
        if (YYYY % 4 == 0 and YYYY % 100 != 0) or (YYYY % 400 == 0):
            if DD <= 29:
                print("It is a correct date!")
            else:
                print("It is not a correct date!")
        else:
            if DD <= 28:
                print("It is a correct date!")
            else:
                print("It is not a correct date!")
else:
    print("It is not a correct date!")
