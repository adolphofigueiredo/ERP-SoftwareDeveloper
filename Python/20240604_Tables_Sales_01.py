'''
Author: Adolpho Silverio Figueiredo Neto
Date: 04/06/2024

Second Exercise

A furniture store needs to manage the sale of tables produced by various master craftsmen suppliers.
Each table has a type, a maximum number of people it can accommodate, and dimensions (height from the ground, length, and width of the top) in meters. We want to create a program that allows us to store all the different types of tables that the furniture store sells. This application should allow printing of tables according to the master craftsman entered in the search query, sorted by the average surface area per person that the table can offer.
'''

from dataclasses import dataclass

# Definition of Data Structures

@dataclass
class Table:
    Craftsman: str
    MaxPersons: int
    HeightInMeters: float
    LengthInMeters: float
    WidthInMeters: float

# Functions:

# Function:
def InsertTable(tables: list) -> list:
    '''
Function: InsertTable
This function allows insertion of tables into the list.
Formal Parameters:
tables --> list of tables to insert into
Return Value:
tables --> updated list of tables
    '''

# Formal Parameters:
    while True:
        Craftsman = ""
        while not Craftsman:
            Craftsman = input("Enter the craftsman: ")

        MaxPersons = 0
        while MaxPersons <= 0:
            MaxPersons = int(input("Enter the maximum number of people that can sit around the table: "))

        HeightInMeters = 0
        while HeightInMeters <= 0:
            HeightInMeters = float(input("Enter the height in meters: "))

        LengthInMeters = 0
        while LengthInMeters <= 0:
            LengthInMeters = float(input("Enter the length in meters: "))

        WidthInMeters = 0
        while WidthInMeters <= 0:
            WidthInMeters = float(input("Enter the width in meters: "))

        tables.append(Table(Craftsman, MaxPersons, HeightInMeters, LengthInMeters, WidthInMeters))

        Confirm = input("Do you want to insert another table?\n\nS - Yes\nN - No\n")
        if Confirm.lower() == "n":
            break

# Return Value:
    return tables

# Function:
def AverageSurfaceArea(Length: float, Width: float, MaxPersons: int) -> float:
    '''
Function: AverageSurfaceArea
Calculates the average surface area per person that the table can offer.
Formal Parameters:
Length --> length of the table in meters
Width --> width of the table in meters
MaxPersons --> maximum number of people that can sit around the table
Return Value:
average_surface_area --> average surface area per person
    '''

# Formal Parameters:
    average_surface_area = (Length * Width) / MaxPersons

# Return Value:
    return average_surface_area

# Function:
def SortByAverageSurfaceArea(tables: list) -> list:
    '''
Function: SortByAverageSurfaceArea
Sorts the tables by the average surface area per person in ascending order.
Formal Parameters:
tables --> list of tables to sort
Return Value:
tables --> sorted list of tables
    '''

# Formal Parameters:
    for i in range(len(tables)):
        for j in range(i, len(tables)):
            if AverageSurfaceArea(tables[i].LengthInMeters, tables[i].WidthInMeters, tables[i].MaxPersons) > AverageSurfaceArea(tables[j].LengthInMeters, tables[j].WidthInMeters, tables[j].MaxPersons):
                tables[i], tables[j] = tables[j], tables[i]

# Return Value:
    return tables

# Function:
def SortByCraftsman(tables: list) -> list:
    '''
Function: SortByCraftsman
Sorts the tables by craftsman name in ascending order.
Formal Parameters:
tables --> list of tables to sort
Return Value:
tables --> sorted list of tables
    '''

# Formal Parameters:
    for i in range(len(tables)):
        for j in range(i, len(tables)):
            if tables[i].Craftsman > tables[j].Craftsman:
                tables[i], tables[j] = tables[j], tables[i]

# Return Value:
    return tables

# Variable Initialization

tables = []

# Input Section

tables = InsertTable(tables)

# Processing

tables = SortByAverageSurfaceArea(tables)
tables = SortByCraftsman(tables)

# Output Section

print("     Craftsman      ", " Max Persons ", " Height ", " Length ", " Width ", " Avg Surface Area / Person ")

for table in tables:
    print(f"{table.Craftsman:<20} {table.MaxPersons:<12} {table.HeightInMeters:<8.2f} {table.LengthInMeters:<8.2f} {table.WidthInMeters:<8.2f} {AverageSurfaceArea(table.LengthInMeters, table.WidthInMeters, table.MaxPersons):<22.2f}")
