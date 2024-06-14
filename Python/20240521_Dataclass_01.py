from dataclasses import dataclass

# Function:

@dataclass
class Date:
    dd: int
    mm: int
    yyyy: int

# Function:

@dataclass
class Person:
    ID: int
    Name: str
    Address: str
    BirthDate: Date
    TaxCode: str
    isMarried: bool

Employee = Person(1, "Pippo", "via xyz 10", Date(17, 6, 1900), "XYZGHJ17H70265L", True)
Student = Person(1, "Mirko", "via ABC 4", Date(1, 12, 2004), "aaabbb01H04134P", True)

print(Employee.isMarried)

Employee.isMarried = False

print(Employee.isMarried)

print(Student.ID)

print(Student.BirthDate.yyyy)

print(Employee.BirthDate.yyyy)
