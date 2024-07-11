'''
Author: Adolpho Silverio Figueiredo Neto
Date: 03/06/2024

Second Exercise
We want to build a program that manages grades for a subject in a class of students. Grades
throughout the year can be up to 10, but not all students have the same number of grades.
The available data includes: student name and sequence of grades (max 10). Write the procedure for
inputting the data. Output the names of the students and their averages, sorted by descending average.

'''

from dataclasses import dataclass

# Data Structures Definition

@dataclass
class Student:
    Name: str
    Grades: list[float]


# Functions:


# Function:
def InsertData() -> list:
    '''
Function: 
InsertData
Formal parameters:

Return value:

    '''
# Formal parameters:

    Students = []
    NumberOfStudents = int(input("How many students do you want to enter? "))
    
    for _ in range(NumberOfStudents):
        Name = input("\nEnter the student's name: ")
        Grades = []
        
        NumberOfGrades = int(input("How many grades do you want to enter for this student? (max 10) "))
        if NumberOfGrades > 10:
            NumberOfGrades = 10
        
        for _ in range(NumberOfGrades):
            Grade = float(input(f"Enter grade {len(Grades) + 1}: "))
            Grades.append(Grade)
        
        Students.append(Student(Name=Name, Grades=Grades))
# Return value:
    
    return Students


# Function:
def CalculateAverage(student: Student) -> float:
    '''
Function: 
CalculateAverage
Formal parameters:

Return value:
'''
# Formal parameters:
    
    if not student.Grades:
      return 0.0

# Return value:
    
    return sum(student.Grades) / len(student.Grades)

# Function:
def PrintRanking(Students: list):
    '''
Function: 
PrintRanking
Formal parameters:

Return value:

    '''
# Formal parameters:
    SortedStudents = sorted(Students, key=lambda student: CalculateAverage(student), reverse=True)
    
    print("\nRanking of students by descending average:\n")
    for Position, student in enumerate(SortedStudents, start=1):
        Average = CalculateAverage(student)
        print(f"{Position}. {student.Name}: Average = {Average:.2f}")

# Variable Initializations


# Input Data Section


# Processing

print("Student grades management program")
Students = InsertData()
PrintRanking(Students)

# Possible Sub-Processing


# Output Section
