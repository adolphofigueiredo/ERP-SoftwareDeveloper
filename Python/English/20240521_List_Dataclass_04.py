'''
Author: Adolpho Silverio Figueiredo Neto
Date: 21/05/2024

Third Exercise

Encode a structure that can contain the data related to a registered player in a football team.

'''

from dataclasses import dataclass

# Functions:

    # Function:

@dataclass
class Date:
    day: int
    month: int
    year: int

@dataclass
class PlayerCard:
    BirthDate: Date
    FirstName: str
    LastName: str
    TaxCode: str
    Position: str
    Team: str
    ContractDuration: int

# Initialization:

Player01 = PlayerCard(Date(27,12,2005),"Mario","Rossi","TRETQETYQER623634","Forward","Corinthians",5)

Player02 = PlayerCard(Date(4,8,2005),"Ronaldo","Gaucho","TRETQETYDASDAS4","Goalkeeper","Palmeiras",6)

# Output:

print(Player01)
print(Player02)
