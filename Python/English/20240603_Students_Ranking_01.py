'''
Author: Adolpho Silverio Figueiredo Neto
Date: 03/06/2024

Third Exercise

At the end of a competition, the results of the contestants' tests are published: for each participant,
the following are stored:

● Name,
● Score of the first test,
● Score of the second test.

The final ranking is desired with the display of contestants sorted in descending order
based on the total score achieved.
'''

from dataclasses import dataclass

@dataclass
class Contestant:
    Name: str
    Score1: float
    Score2: float

# Data Structures Definition

# Functions:

# Function:
def InsertData() -> list:
    '''
Function: InsertData

Formal parameters:

Return value:

'''
# Formal parameters:

    Contestants = []
    NumberOfContestants = int(input("How many contestants do you want to enter? "))

    for _ in range(NumberOfContestants):
        Name = input("\nEnter the contestant's name: ")
        Score1 = float(input("Enter the score of the first test: "))
        Score2 = float(input("Enter the score of the second test: "))
        Contestants.append(Contestant(Name=Name, Score1=Score1, Score2=Score2))
    
# Return value:

    return Contestants


# Function:
def TotalScore(contestant: Contestant) -> float:

    '''
Function: TotalScore

Formal parameters:

Return value:
'''
# Return value:
    return contestant.Score1 + contestant.Score2


# Function:
def SortContestantsByScore(contestants: list) -> list:
    '''
Function: SortContestantsByScore

Formal parameters:

Return value:
'''
# Return value:
    return sorted(contestants, key=lambda contestant: TotalScore(contestant), reverse=True)


# Variable Initializations

# Input Data Section

# Processing

Contestants = InsertData()
SortedContestants = SortContestantsByScore(Contestants)

# Possible Sub-Processing

# Output Section

print("\nFinal ranking:\n")

for Position, contestant in enumerate(SortedContestants, start=1):
    print(f"{Position}. {contestant.Name}: Total score = {TotalScore(contestant)}")
