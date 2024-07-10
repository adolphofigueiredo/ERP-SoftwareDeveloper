'''
Author: Adolpho Silverio Figueiredo Neto
Date: 28/05/2024

Third Exercise
A dental clinic uses a table to store all appointments made for the month of July.
Appointments have the following record layout: surname and date (number from 1 to 31).
Write a function that prints to standard output which days are free.
Build the program that loads the table and tests the designed function.

'''
from dataclasses import dataclass

# Data Structure Definitions

@dataclass
class Appointment:
    Day: int
    First_name: str
    Last_name: str

# Functions

def find_free_days(appointments: list, free_days: list) -> list:
    '''
    Function: find_free_days
    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    Parameters:
    appointments --> list of Appointment objects
    free_days --> list to store days that are free
    Return Value:
    free_days --> list of days that are free
    '''

    M = int(input("\nHow many days are there in the month you want to analyze? "))
    
    for i in range(1, M + 1):
        found = False

        for appointment in appointments:
            if appointment.Day == i:
                found = True
                break

        if not found:
            free_days.append(i)

    return free_days
                                                                                                          
# Initialize Variables

appointments = list()
free_days = list()

# Input Section

appointments.append(Appointment(22, "Adolpho", "Figueiredo"))
appointments.append(Appointment(5, "Giovanni", "Rossi"))
appointments.append(Appointment(14, "Maria", "Bianchi"))
appointments.append(Appointment(19, "Carlo", "Ricci"))
appointments.append(Appointment(7, "Anna", "Ferrari"))
appointments.append(Appointment(23, "Pietro", "Esposito"))
appointments.append(Appointment(30, "Luca", "Romano"))
appointments.append(Appointment(8, "Marina", "Colombo"))
appointments.append(Appointment(21, "Paolo", "Bruno"))
appointments.append(Appointment(12, "Riccardo", "Galli"))
appointments.append(Appointment(27, "Francesca", "Conti"))
appointments.append(Appointment(15, "Gabriele", "De Luca"))
appointments.append(Appointment(3, "Luana", "Costa"))
appointments.append(Appointment(10, "Filippo", "Greco"))
appointments.append(Appointment(29, "Giulia", "Marino"))
appointments.append(Appointment(6, "Daniele", "Giordano"))
appointments.append(Appointment(22, "Alessia", "Rizzo"))
appointments.append(Appointment(11, "Raffaele", "Lombardi"))
appointments.append(Appointment(2, "Laura", "Barone"))
appointments.append(Appointment(17, "Matteo", "Leone"))
appointments.append(Appointment(26, "Beatrice", "Moretti"))
appointments.append(Appointment(9, "Gustavo", "Serra"))
appointments.append(Appointment(1, "Camilla", "Sanna"))
appointments.append(Appointment(22, "Matteo", "Ferri"))
appointments.append(Appointment(16, "Bianca", "Riva"))
appointments.append(Appointment(20, "Isabella", "Grassi"))
 
# Processing

free_days = find_free_days(appointments, free_days) 

# Output Section

print("\n---------- Appointments -----------\n")

for appointment in appointments:
    print(f"{appointment.Day:<3} - {appointment.First_name:<15} {appointment.Last_name:<15}")

print("\n---------- Free Days -------------\n")

for day in free_days:
    print(day, " - Free")

print("\n----------------------------------\n")
