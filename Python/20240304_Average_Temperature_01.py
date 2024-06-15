'''

Author: Adolpho Silverio Figueiredo Neto
Date: 04/03/2024

Second Exercise
Input a number N of temperature measurements, the output should be the arithmetic
average of these temperatures.
example:
Input: N = 3 temperatures: 19.5 20.3 21.0
Output: average = (19.5 + 20.3 + 21.0) / 3 = 20.267

'''

# Data Input Section

n = int(input("Enter the number of measurements: "))
sum_temps = 0
counter = 1
average = 0

# Processing
if n <= 0:
    print("The number of measurements must be positive!")
else:
    for i in range(1, n + 1):
        temperature = float(input("Enter temperature {}: ".format(counter)))
        sum_temps += temperature
        counter += 1
    average = sum_temps / n
    print("The arithmetic average is {}.".format(average))
