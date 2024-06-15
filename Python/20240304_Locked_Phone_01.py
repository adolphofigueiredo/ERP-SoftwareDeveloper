'''

Author: Adolpho Silverio Figueiredo Neto
Date: 04/03/2024

Fifth Exercise
Write a program that simulates unlocking a cellphone. The program reads a 4-digit PIN
entered by the user and sets it as the PIN. The program then asks to re-enter the PIN,
if the correct one is entered it prints "phone unlocked", otherwise it asks again and on the third wrong attempt displays "phone locked".
example:
PIN Setting: 1 2 3 4
PIN Entry : 1 2 3 5 -> Error! Re-enter PIN
2 PIN Entry : 1 2 3 8 -> Error! Re-enter PIN
3 PIN Entry : 1 2 3 1 -> Error! PIN LOCKED!
PIN Setting: 2 1 3 4
PIN Entry : 2 1 5 3 -> Error! Re-enter PIN
2 PIN Entry : 2 1 3 4 -> CORRECT! CELL PHONE UNLOCKED!

'''

# Data Input Section

pin = input("Set PIN (4 numerical digits): ")
attempt = 0

# Processing

while len(pin) != 4 or not pin.isdigit():
    pin = input("\nSet PIN (4 numerical digits): ")

entry = input("\nEnter PIN (4 numerical digits): ")
attempt += 1

while entry != pin and attempt < 3:
    print("Error! Re-enter PIN!")
    entry = input("\nEnter PIN (4 numerical digits): ")
    attempt += 1

# Output Section

if entry == pin:
    print("\nCorrect! Phone Unlocked!")
else:
    print("\nError! PIN LOCKED!")
