# Function:
def IsNumber(Num):
    '''
Function: IsNumber
Function that allows the program to determine if the input is numeric.
Parameters:
Num --> Variable that will be tested
Check --> Variable that indicates if the tested number is a number or not.
Return value:
Check --> bool
    '''
    # Parameters:
    Check = True
    Filter = "-.0123456789"         # Variable containing the characters that keep the check true.
    for x in Num:                   # Loop created to test each digit of the Num variable.
        if x not in Filter:         # Condition created to give instructions after finding an unacceptable digit.
            Check = False           # The variable becomes false because an unacceptable character was found.
            break                   # After the loop encounters an unacceptable character, the loop ends.
    # Return value:
    return Check

'''
--------------------------------------------------------------------------------------------------------
'''

Check = False

while Check == False:
    test = input("Enter the number: ")
    Check = IsNumber(test)

test = float(test)

print(test * 4)
