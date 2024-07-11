'''
Author: Adolpho Silverio Figueiredo Neto
Date: 21/05/2024

First Exercise

Given the following data definition:
Modify the Persona structure to represent the address as a structure made up of the fields: street, ZIP code, Municipality.

'''

import dataclasses

# Functions:

    # Function:

@dataclasses.dataclass
class CompleteAddress:
    Street: str
    ZIP: int
    Municipality: str

    # Function:

@dataclasses.dataclass
class Person:
    ID: int
    Name: str
    Address: CompleteAddress
    BirthDate: str
    TaxCode: str
    isMarried: bool

# Processing:

Person001 = Person(20017325, "Adolpho", CompleteAddress("Garessio", 10126, "Turin"), "04/03/1982", "GASDGGGASD545456", True)
Addr2 = CompleteAddress("Guidobono", 10137, "Turin")
Person002 = Person(200317325, "Leila", Addr2, "27/04/1986", "GFSDYUTYRUTD545456", False)

# Output:

print(Person001)
print(Person002)

Person002.Name = "Antonella"

print(Person002)
