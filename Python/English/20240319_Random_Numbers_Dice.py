'''

Author: Adolpho Silverio Figueiredo Neto
Date: 19/03/2024

Exercise: Dice Rolls (Random Numbers)
Write a program that rolls a six-sided die N times. N should be chosen by the user.
In the output, print the face that came up for each roll and the number of times the face 6 was rolled.

'''

# Data Input Section

import random as rd  # Import and modify the names for convenience later.

N = int(input("\nEnter the number of rolls: "))
while N <= 0:  # Loop created to ensure the number of rolls is positive.
    N = int(input("\nThe number of rolls must be greater than 0!\n\nEnter the number of rolls: "))

# Variable Initializations

face6 = 0  # Counter created to count the number of times face 6 came up.

# Processing

for roll in range(1, N + 1):  # Loop created to roll the die.
    result = rd.randrange(1, 7)  # Number of faces on the die.
    print("\nRoll {}: {}".format(roll, result))
    if result == 6:  # Condition created to count the number of times face 6 came up.
        face6 += 1

# Any subprocesses for processing

# Output Section

if face6 == 0:
    print("\nThe face 6 did not come up.\n")  # Condition created to check if face 6 came up zero times.
elif face6 == 1:
    print("\nThe face 6 came up {} time.\n".format(face6))  # Singular form for one time.
else:
    print("\nThe face 6 came up {} times.\n".format(face6))  # Plural form for multiple times.
