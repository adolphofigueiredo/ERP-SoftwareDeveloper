'''
Author: Adolpho Silverio Figueiredo Neto
Date: 06/04/2024

Second Exercise

A furniture store needs to manage the sale of tables produced by different master craftsmen suppliers.
Each table is of a type, has a maximum number of people who can sit around it, and has dimensions 
(height from the ground, length, and width of the top) in meters. It is desired to create a program 
that allows storing all the different types of tables that the furniture store sells. This application 
should allow printing tables according to the craftsman inserted in the search query, ordered by the 
average surface area per person that the table can offer.
'''

from dataclasses import dataclass

# Data Structure Definition

@dataclass
class Table:
    Craftsman: str
    MaxPeople: int
    HeightInMeters: float
    LengthInMeters: float
    WidthInMeters: float

# Functions:

# Function:
def InsertTable(Tables: list) -> list:
    '''
    Function: InsertTable
    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Formal parameters:
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Return value:
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

# Formal parameters:
    
    Inserting = True

    while Inserting:

        Craftsman = ""
        while not Craftsman:
            Craftsman = input("Enter the master craftsman: ")
    
        MaxPeople = 0
        while MaxPeople <= 0:
            MaxPeople = int(input("Enter the maximum number of people who can sit around: "))
    
        HeightInMeters = 0
        while HeightInMeters <= 0:
            HeightInMeters = float(input("Enter the height in meters: "))
    
        LengthInMeters = 0
        while LengthInMeters <= 0:
            LengthInMeters = float(input("Enter the length in meters: "))
    
        WidthInMeters = 0
        while WidthInMeters <= 0:
            WidthInMeters = float(input("Enter the width in meters: "))

        Tables.append(Table(Craftsman, MaxPeople, HeightInMeters, LengthInMeters, WidthInMeters))

        Confirm = input("Do you want to insert a new table?\n\nY - Yes\nN - No\n")
        if Confirm == "N" or Confirm == "n":
            Inserting = False

# Return value:

    return Tables


# Function:
def AverageSurface(Length: float, Width: float, MaxPeople: int) -> float:
    '''
    Function: AverageSurface
    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Formal parameters:
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Return value:
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

# Formal parameters:

    AverageSurface = ((Length * Width) / MaxPeople)

# Return value:

    return AverageSurface


# Function:
def OrderAverageSurface(Tables: list) -> list:
    '''
    Function: OrderAverageSurface
    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Formal parameters:
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Return value:
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

# Formal parameters:

    for i in range(len(Tables)):
        for j in range(i, len(Tables)):
            if AverageSurface(Tables[i].LengthInMeters, Tables[i].WidthInMeters, Tables[i].MaxPeople) > AverageSurface(Tables[j].LengthInMeters, Tables[j].WidthInMeters, Tables[j].MaxPeople):
                Tables[i], Tables[j] = Tables[j], Tables[i]

# Return value:

    return Tables

# Function:
def OrderCraftsman(Tables: list) -> list:
    '''
    Function: OrderCraftsman
    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Formal parameters:
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Return value:
    xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

# Formal parameters:

    for i in range(len(Tables)):
        for j in range(i, len(Tables)):
            if Tables[i].Craftsman > Tables[j].Craftsman:
                Tables[i], Tables[j] = Tables[j], Tables[i]

# Return value:

    return Tables


# Variable Initializations

Tables = []

# Data Input Section

Tables = InsertTable(Tables)

# Processing

Tables = OrderAverageSurface(Tables)
Tables = OrderCraftsman(Tables)

# Any Sub Processing

# Output Section

print("     Craftsman      ", " People ", " Height ", " Length ", " Width ", " Surface / Person ")

for Table in Tables:
    
    print(f"{Table.Craftsman:<20} {Table.MaxPeople:<9} {Table.HeightInMeters:<9} {Table.LengthInMeters:<11} {Table.WidthInMeters:<11} {AverageSurface(Table.LengthInMeters, Table.WidthInMeters, Table.MaxPeople):<22}")
