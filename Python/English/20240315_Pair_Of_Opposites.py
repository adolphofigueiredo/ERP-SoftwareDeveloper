'''

Author: Adolpho Silverio Figueiredo Neto
Date: 15/03/2024

Exercise: Pairs of Opposites
Given N pairs of numbers, count and print those that have values that are opposites of each other.

'''

# Input Section

n = int(input("\nEnter the number of pairs to input: "))
while n <= 0:
    n = int(input("\nThe number must be positive!\n\nEnter the number of pairs to input: "))
        
# Variable Initialization
    
counter = 0
opposite_count = 0

# Processing

while counter < n:
    counter += 1
    pair1 = int(input("\nEnter the first number of pair {}: ".format(counter)))
    while pair1 == 0:
        pair1 = int(input("\nThe number must be different from 0!\n\nEnter the first number of pair {}: ".format(counter)))
    pair2 = int(input("\nEnter the second number of pair {}: ".format(counter)))
    while pair2 == 0:
        pair2 = int(input("\nThe number must be different from 0!\n\nEnter the second number of pair {}: ".format(counter)))
    if (pair1 * -1) == pair2:
        opposite_count += 1
        print("\nThis pair has opposite values.\n")
    else:
        print("\nThis pair does not have opposite values.\n")

# Any Additional Processing

# Output Section

if opposite_count == 1:
    print("\n{} pair has opposite values.\n".format(opposite_count))
else:
    print("\n{} pairs have opposite values.\n".format(opposite_count))
