'''

Using these quotation marks you can make comments before starting the program!

'''

a = int(input("Enter the first number: "))
b = int(input("Enter the second number: "))
if (a>0):
    if (b>0):
        print("Both are positives!")
    else:
        print("There is one positive number and a negative number!")
else:
    if (b<0):
        print("Both are negatives!")
    else:
        print("There is one positive number and a negative number!")
