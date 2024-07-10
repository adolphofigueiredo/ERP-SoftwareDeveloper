# Function:
def Massimo(Lista):
    '''
Function: Massimo
This function is created to find the maximum value in the list.

Formal parameters:
Lista --> List that will be used for the search
N --> Number of elements in the list
Contatore --> Counter that records the number of tested elements

Return value:
Max --> Variable created to store the maximum value in the list
    '''
    # Formal parameters:
    N = len(Lista)  # Get the number of elements in the list
    Max = Lista[0]  # Assume the first element is the maximum
    Contatore = 1  # Start counter from the second element
    
    # Loop through the list to find the maximum value
    while Contatore < N:
        if Lista[Contatore] > Max:
            Max = Lista[Contatore]  # Update the maximum value if a larger one is found
        Contatore += 1  # Move to the next element
    
    # Return the maximum value found
    return Max

# Sample list
Lista = [312, 203, 310, 30, 273, 168, 187, 463, 332, 179, 365, 87, 135, 430, 375, 290, 95, 242, 489, 270, 190, 152, 13, 154, 123, 302, 308, 190, 376, 447, 161, 281, 140, 129, 184, 249, 298, 360, 83, 381, 234, 419, 158, 113, 294, 465, 280, 427, 54, 206]

# Find the maximum value in the list
Max = Massimo(Lista)

# Print the maximum value
print(Max)
