'''
Author: Adolpho Silverio Figueiredo Neto
Date: 03/06/2024

Second Exercise
A program is needed to manage the grades of a subject for a class of students. Grades
throughout the year can be at most 10, but not all students have the same number of grades.
The available data are: student name and sequence of grades (up to 10). Write the procedure for
inputting the data. Output the names of the students and their average grades, sorted by average in descending order.

'''

from dataclasses import dataclass

# Definition of Data Structures

@dataclass
class Student:
    Name: str
    Grades: list[float]


# Functions:


# Function:

def InputData() -> list:
    '''
Function: 
InputData
Formal Parameters:

Return Value:

    '''
#Formal Parameters:

    Students = []
    NumStudents = int(input("How many students do you want to enter? "))
    
    for _ in range(NumStudents):
        Name = input("\nEnter the student's name: ")
        Grades = []
        
        NumGrades = int(input("How many grades do you want to enter for this student? (max 10) "))
        if NumGrades > 10:
            NumGrades = 10
        
        for _ in range(NumGrades):
            Grade = float(input(f"Enter grade {len(Grades) + 1}: "))
            Grades.append(Grade)
        
        Students.append(Student(Name=Name, Grades=Grades))
#Return value:
    
    return Students


# Function:

def CalculateAverage(student: Student) -> float:
    '''
Function: 
InputData
Formal Parameters:

Return Value:
'''
#Formal Parameters:
    
    if not student.Grades:
      return 0.0

#Return value:
    
    return sum(student.Grades) / len(student.Grades)

# Function:

def PrintRanking(students: list):
    '''
Function: 
InputData
Formal Parameters:

Return Value:

    '''
#Formal Parameters:
    sorted_students = sorted(students, key=lambda student: CalculateAverage(student), reverse=True)
    
    print("\nRanking of students by average grade in descending order:\n")
    for position, student in enumerate(sorted_students, start=1):
        average = CalculateAverage(student)
        print(f"{position}. {student.Name}: Average = {average:.2f}")

# Variable Initializations


# Input Section


# Processing

print("Student grades management program")
students = InputData()
PrintRanking(students)

# Any Sub-Processing

# Output Section
