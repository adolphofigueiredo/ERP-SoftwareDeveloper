'''

Author: Adolpho Silverio Figueiredo Neto
Date: 25/03/2024

Second Exercise

Create a function that receives a quantity of time in hours, minutes, and seconds format and
returns it expressed only in seconds.
Create a main program that asks the user for two quantities of time in input and
prints which quantity of time is greater.

'''

# Functions:

# Function: time_in_seconds
def time_in_seconds(hours, minutes, seconds):                 # Function definition to convert time into seconds.
    # Formal parameters:
    total_seconds = (hours * 60 * 60) + (minutes * 60) + seconds  # Calculation 
    # Return value:
    return total_seconds

# Data Input Section

hours1 = int(input("Enter the hours (24h) for time 1: "))                         # Data request to calculate the larger time quantity.
while hours1 < 0:                                                                 # Loop created to verify if the entered number is positive.
    hours1 = int(input("Error - The number must be positive!\nEnter the hours (24h) for time 1: "))  # Error information and new input request.

minutes1 = int(input("Enter the minutes for time 1: "))                           # Data request to calculate the larger time quantity.
while minutes1 <= 0:                                                              # Loop created to verify if the entered number is positive.
    minutes1 = int(input("Error - The number must be positive!\nEnter the minutes for time 1: "))  # Error information and new input request.

seconds1 = int(input("Enter the seconds for time 1: "))                           # Data request to calculate the larger time quantity.
while seconds1 <= 0:                                                              # Loop created to verify if the entered number is positive.
    seconds1 = int(input("Error - The number must be positive!\nEnter the seconds for time 1: "))  # Error information and new input request.

hours2 = int(input("Enter the hours (24h) for time 2: "))                         # Data request to calculate the larger time quantity.
while hours2 < 0:                                                                 # Loop created to verify if the entered number is positive.
    hours2 = int(input("Error - The number must be positive!\nEnter the hours (24h) for time 2: "))  # Error information and new input request.

minutes2 = int(input("Enter the minutes for time 2: "))                           # Data request to calculate the larger time quantity.
while minutes2 <= 0:                                                              # Loop created to verify if the entered number is positive.
    minutes2 = int(input("Error - The number must be positive!\nEnter the minutes for time 2: "))  # Error information and new input request.

seconds2 = int(input("Enter the seconds for time 2: "))                           # Data request to calculate the larger time quantity.
while seconds2 <= 0:                                                              # Loop created to verify if the entered number is positive.
    seconds2 = int(input("Error - The number must be positive!\nEnter the seconds for time 2: "))  # Error information and new input request.

# Variable Initialization

# Processing

time1 = time_in_seconds(hours1, minutes1, seconds1)   # Using the function that converts time into seconds.
time2 = time_in_seconds(hours2, minutes2, seconds2)   # Using the function that converts time into seconds.

if time1 < time2:   # Condition to determine which time is greater.
    print("The first time entered {}:{}:{} is less than the second time entered {}:{}:{}.".format(hours1, minutes1, seconds1, hours2, minutes2, seconds2))
elif time1 > time2:  # Condition to determine which time is greater.
    print("The first time entered {}:{}:{} is greater than the second time entered {}:{}:{}.".format(hours1, minutes1, seconds1, hours2, minutes2, seconds2))
else:  # Condition to determine if the times are equal.
    print("The first time entered {}:{}:{} is equal to the second time entered {}:{}:{}.".format(hours1, minutes1, seconds1, hours2, minutes2, seconds2))

# Any additional processing

# Output Section
