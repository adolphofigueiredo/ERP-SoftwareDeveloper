'''
Author: Adolpho Silverio Figueiredo Neto
Date: 04/03/2024

First Exercise
Input a positive integer N. The output should be the factorial of N.
Factorial of n: Definition: n! = n(n-1)(n-2)...2*1 ; 0! = 1
example:
0!=1 1!=1 2!=2*1 3!=3*2*1! 4!= 4*3*2*1= 24
'''

# Data Input Section

num = int(input("Enter the number: "))
result = 1
counter = 1

# Processing

if num == 0:
    print("The factorial of {} is 1.".format(num))
elif num > 0:
    while counter <= num:
        result = counter * result
        counter += 1  # Equivalent to counter = counter + 1
    print("The factorial of {} is {}.".format(num, result))
else:
    print("The number must be positive.")
