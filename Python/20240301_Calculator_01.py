'''

Author: Adolpho Silverio Figueiredo Neto
Date: 03/01/2024

Exercise: Calculator [OPTIONAL]

Create a program that asks the user to enter two real numbers and allows
the user to choose which operation to perform with the two numbers.

➔ If the user enters the character '+', the addition of the two numbers will be performed.
➔ If the user enters the character '-', the subtraction of the two numbers will be performed.
➔ If the user enters the character '*', the multiplication of the two numbers will be performed.
➔ If the user enters the character '/', the division of the two numbers will be performed.

Example: input: 3 + 4 output: 7 input: 4 z 2 output: error!

'''

num1 = int(input("Enter the first number for the calculation: "))
operator = str(input("Enter the calculation operator: "))
num2 = int(input("Enter the second number for the calculation: "))

match operator:
    case "+":
        print(num1 + num2)
    case "-":
        print(num1 - num2)
    case "*":
        print(num1 * num2)
    case "/":
        print(num1 / num2)
    case _:
        print("This operator is not valid.")
