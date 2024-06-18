'''

Author: Adolpho Silverio Figueiredo Neto
Date: 25/03/2024

Second Exercise

Create a function that receives a time quantity in hours, minutes, and seconds, and returns it expressed only in seconds.
Create a main program that asks the user for two time quantities in input and outputs which time quantity is greater.

'''

# Functions:

# Function: time_in_seconds
def time_in_seconds(hours, minutes, seconds):  # Definition created to convert time into seconds.
    # Formal parameters:
    total_seconds = (hours * 60 * 60) + (minutes * 60) + seconds  # Calculation
    # Return value:
    return total_seconds

# Data input section

hour1 = int(input("Enter the hours (24h) for time 1: "))  # Request data to calculate the greater time quantity.
while hour1 < 0:  # Loop created to check if the entered number is positive.
    hour1 = int(input("Error - The number must be positive!\nEnter the hours (24h) for time 1: "))  # Error information and request for new input.

minute1 = int(input("Enter the minutes for time 1: "))  # Request data to calculate the greater time quantity.
while minute1 < 0:  # Loop created to check if the entered number is positive.
    minute1 = int(input("Error - The number must be positive!\nEnter the minutes for time 1: "))  # Error information and request for new input.

second1 = int(input("Enter the seconds for time 1: "))  # Request data to calculate the greater time quantity.
while second1 < 0:  # Loop created to check if the entered number is positive.
    second1 = int(input("Error - The number must be positive!\nEnter the seconds for time 1: "))  # Error information and request for new input.

hour2 = int(input("Enter the hours (24h) for time 2: "))  # Request data to calculate the greater time quantity.
while hour2 < 0:  # Loop created to check if the entered number is positive.
    hour2 = int(input("Error - The number must be positive!\nEnter the hours (24h) for time 2: "))  # Error information and request for new input.

minute2 = int(input("Enter the minutes for time 2: "))  # Request data to calculate the greater time quantity.
while minute2 < 0:  # Loop created to check if the entered number is positive.
    minute2 = int(input("Error - The number must be positive!\nEnter the minutes for time 2: "))  # Error information and request for new input.

second2 = int(input("Enter the seconds for time 2: "))  # Request data to calculate the greater time quantity.
while second2 < 0:  # Loop created to check if the entered number is positive.
    second2 = int(input("Error - The number must be positive!\nEnter the seconds for time 2: "))  # Error information and request for new input.

# Variable initializations

# Processing

time1 = time_in_seconds(hour1, minute1, second1)  # Using the definition that converts time into seconds.
time2 = time_in_seconds(hour2, minute2, second2)  # Using the definition that converts time into seconds.

if time1 < time2:  # Condition that defines which time is greater
    print("The first entered time {}:{}:{} is less than the second entered time {}:{}:{}.".format(hour1, minute1, second1, hour2, minute2, second2))
elif time1 > time2:  # Condition that defines which time is greater
    print("The first entered time {}:{}:{} is greater than the second entered time {}:{}:{}.".format(hour1, minute1, second1, hour2, minute2, second2))
else:  # Condition that defines if the times are equal.
    print("The first entered time {}:{}:{} is equal to the second entered time {}:{}:{}.".format(hour1, minute1, second1, hour2, minute2, second2))

# Any subprocesses of Processing

# Output section
