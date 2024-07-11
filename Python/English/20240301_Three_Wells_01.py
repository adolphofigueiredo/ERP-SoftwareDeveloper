'''

Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: The three wells
Input the depths of three different wells. Print if there are at least two wells with the same depth.

'''
A = int(input("Enter the depth of the first well: "))
B = int(input("Enter the depth of the second well: "))
C = int(input("Enter the depth of the third well: "))
count = 0

if A == B:
    count = count + 1
if B == C:
    count = count + 1
if A == C:
    count = count + 1
if count == 0:
    print("All depths are different.")
elif count == 1:
    print("Two wells have the same depth.")
else:
    print("All wells have the same depth.")
