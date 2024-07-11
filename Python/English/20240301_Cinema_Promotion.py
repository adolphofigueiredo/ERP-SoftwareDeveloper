'''
Create a program that, after asking the user's age, indicates if that person can
take advantage of cinema promotion. The promotion is reserved for those who are older
than 64 or those between 5 and 18 years.
'''

AGE = int(input("Enter your age: "))
if (AGE>=64) or (AGE>=5 and AGE<=18):
    print("You can use it!")
else:
    print("You cannot use it!")
