# Questo è un commento

'''

Posso scrivere piu
linee di commento

'''

a = int(input("Insert the first number: "))
b = int(input("Insert the second number: "))
if a>0 and b>0:
    print("Both are positives!")
else:
    if a<0 and b<0:
        print("Both are negatives!")
    else:
        print("There is one positive number and a negative number!")