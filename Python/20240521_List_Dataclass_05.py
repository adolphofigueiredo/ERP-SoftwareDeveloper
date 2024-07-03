'''
Author: Adolpho Silverio Figueiredo Neto
Date: 21/05/2024

Fourth Exercise

Represent with a structure the information of a city: name, current population
number and population number from last year. Build a function that calculates
the population increase (or decrease). Write a program that allows testing the
designed function, including data entry.
'''

from dataclasses import dataclass

# Data Structure Definitions
@dataclass
class Population:
    City: str
    CurrentPopulation: int
    PopulationLastYear: int

# Function for Data Input
def InputData():
    population = Population("", 0, 0)
    
    while population.City == "":
        population.City = input("\nEnter the city name: ")

    while population.CurrentPopulation <= 0:
        population.CurrentPopulation = int(input("Enter the current population number: "))

    while population.PopulationLastYear <= 0:
        population.PopulationLastYear = int(input("Enter the population number from last year: "))

    return population

# Processing
population = InputData()

delta_population = population.CurrentPopulation - population.PopulationLastYear
delta_percentage = (delta_population / population.PopulationLastYear) * 100

# Output
if delta_population < 0:
    print(f"\nThe population of {population.City} decreased by {-delta_population} people, {-delta_percentage:.2f}% compared to last year.\n")
elif delta_population == 0:
    print(f"\nThe population of {population.City} is the same as last year.\n")
else:
    print(f"\nThe population of {population.City} increased by {delta_population} people, {delta_percentage:.2f}% compared to last year.\n")
