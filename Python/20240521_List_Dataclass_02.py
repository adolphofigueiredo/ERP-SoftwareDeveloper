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
    Municipality: str

    # Function:

@dataclass
class Teacher:
    FirstName: str
    LastName: str
    BirthDate: Date
    TaxCode: str
    Address: CompleteAddress
    Qualification: str

# Processing:

BD = Date(4, 3, 1982)
Teacher01 = Teacher("Adolpho", "Figueiredo", BD, "hghjgasd", CompleteAddress("Garessio", 10126, "Turin"), "Teacher")
TeacherInfoList = ["Adolpho", "Figueiredo", BD, "hghjgasd", CompleteAddress("Garessio", 10126, "Turin"), "Teacher"] 

# Output:

print(Teacher01)
print(TeacherInfoList)
