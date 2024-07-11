'''
Author: Adolpho Silverio Figueiredo Neto
Date: 21/05/2024

Second Exercise

Encode a structure that can contain the data related to a school teacher.

'''

from dataclasses import dataclass

# Functions:

    # Function:

@dataclass
class Date:
    day: int
    month: int
    year: int

    # Function:

@dataclass
class CompleteAddress:
    Street: str
    ZIP: int
    City: str

    # Function:

@dataclass
class Teacher:
    FirstName: str
    LastName: str
    BirthDate: Date
    TaxCode: str
    Address: CompleteAddress
    Qualification: str

# Initialization

dt = Date(1, 1, 2000)
teacher01 = Teacher("Adolpho", "Silverio", dt, "hghjgasd", CompleteAddress("adas", 10, "to"), "Teacher")
teacherInfoList = ["Adolpho", "Silverio", dt, "hghjgasd", CompleteAddress("adas", 10, "to"), "Teacher"]

# The data in lines 43 and 44 are the same, but they are stored in different ways, meaning they are not the same.

print(teacher01)
print(teacherInfoList)
