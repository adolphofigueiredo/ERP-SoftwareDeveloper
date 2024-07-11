'''
Author: Adolpho Silverio Figueiredo Neto
Date: 15/04/2024

Second Exercise
Create a function that accepts three formal parameters: DD -> day of the month, MM: month of the year, and YYYY: year. 
This function should return whether the given parameters can represent a valid date. 
Use named parameters.
Test the function by entering at least two dates. Input should be implemented using a function.

Example:

INPUT: date 12 01 1450 OUTPUT: TRUE
INPUT: date 30 02 2024 OUTPUT: FALSE
'''

def EnterDate():
    YYYY = int(input("Enter the year: "))       # Prompts for the year
    MM = int(input("Enter the month: "))        # Prompts for the month
    DD = int(input("Enter the day: "))          # Prompts for the day
    return DD, MM, YYYY                         # Returns the date components as a tuple

def isValidDate(DD, MM, YYYY):
    '''
    Function: isValidDate
    Checks if the provided parameters represent a valid date.

    Parameters:
    DD   -> int - Day of the month
    MM   -> int - Month of the year
    YYYY -> int - Year
    '''
    if MM <= 12 and MM >= 1 and DD >= 1:                # Checks if month and day are within valid ranges
        if MM in [1, 3, 5, 7, 8, 10, 12]:               # Months with 31 days
            if DD <= 31:
                return True                            # Valid date
        elif MM in [4, 6, 9, 11]:                       # Months with 30 days
            if DD <= 30:
                return True                            # Valid date
        elif MM == 2:                                   # February: leap year check
            if YYYY % 4 == 0 and (YYYY % 100 != 0 or YYYY % 400 == 0):  # Leap year condition
                if DD <= 29:
                    return True                        # Valid date in leap year
            elif DD <= 28:
                return True                            # Valid date in non-leap year for February
    return False                                       # Invalid date

# User input for two dates
print("---- Enter the first date ----")
DD1, MM1, YYYY1 = EnterDate()
print("---- Enter the second date ----")
DD2, MM2, YYYY2 = EnterDate()

# Output whether each date is valid or not
print("-------------------------")
print(f"{DD1}/{MM1}/{YYYY1} - {'TRUE' if isValidDate(DD1, MM1, YYYY1) else 'FALSE'}")
print(f"{DD2}/{MM2}/{YYYY2} - {'TRUE' if isValidDate(DD2, MM2, YYYY2) else 'FALSE'}")
print("-------------------------")
