# Function:
def RicercaBinaria(Lista, Ricerca):
    '''
Function: RicercaBinaria
This function compares the key "Ricerca" with the element that is in the middle of the list. 
If the identified element is not the same as the one being searched for, 
the search continues in the lower or upper half of the list, 
depending on whether the key is smaller or larger than the middle element.

Formal parameters:
N --> Number of elements in the list
Lista --> List that will be used for the search
Ricerca --> The search key
TentativoMAX --> Maximum number of attempts still possible

Return value:
Trovato --> Boolean variable indicating whether the key was found in the list
Posizione --> Position where the test is conducted in the sorted list.
    '''
    # Formal parameters:
    Trovato = False  # Indicates whether the key was found
    Lista = sorted(Lista)  # Sort the list
    Tentativo = 0  # Start index for search
    N = len(Lista)  # Length of the list
    Possibilita = N - 1  # End index for search
    Posizione = int((Tentativo + Possibilita) / 2)  # Middle index
    
    # Perform binary search
    while (Tentativo <= Possibilita) and (Lista[Posizione] != Ricerca):
        if Lista[Posizione] > Ricerca:
            Possibilita = Posizione - 1  # Search in the lower half
        else:
            Tentativo = Posizione + 1  # Search in the upper half
        Posizione = int((Tentativo + Possibilita) / 2)  # Update middle index
    
    # Check if the key was found
    if Lista[Posizione] == Ricerca:
        Trovato = True
    if not Trovato:
        Posizione = "-----"  # If not found, set position to "-----"
    
    # Return value:
    return Trovato, Posizione

# Test the function
Lista = [312, 203, 310, 30, 273, 168, 187, 463, 332, 179, 365, 87, 135, 430, 375, 290, 95, 242, 489, 270, 190, 152, 13, 154, 123, 302, 308, 190, 376, 447, 161, 281, 140, 129, 184, 249, 298, 360, 83, 381, 234, 419, 158, 113, 294, 465, 280, 427, 54, 206]
Ricerca = 10

Trovato, Posizione = RicercaBinaria(Lista, Ricerca)
print("Found:  ", Trovato, "\nPosition:", Posizione)
