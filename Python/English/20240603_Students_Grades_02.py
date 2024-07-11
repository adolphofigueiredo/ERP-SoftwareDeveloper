'''
Author: Adolpho Silverio Figueiredo Neto
Date: 03/06/2024

Third Exercise

At the end of a competition, the results of the competitors' tests are published: they are stored for each participant:

● Name,
● Score of the first test,
● Score of the second test.

The final ranking is desired with the display of competitors sorted in descending order according to the total score achieved.
'''

from dataclasses import dataclass

@dataclass
class Competitor:
    Name: str
    Score01: float
    Score02: float

# Definition of Data Structures

# Functions:

# Function:

def InputData() -> list:
    '''
Function: InputData

Formal Parameters:

Return Value:

'''
# Formal Parameters:

    Competitors = []
    NumCompetitors = int(input("How many competitors do you want to enter? "))

    for _ in range(NumCompetitors):
        Name = input("\nEnter the competitor's name: ")
        Score1 = float(input("Enter the score of the first test: "))
        Score2 = float(input("Enter the score of the second test: "))
        Competitors.append(Competitor(Name=Name, Score01=Score1, Score02=Score2))
    
# Return Value:

    return Competitors


# Function:
def TotalScore(Competitor: Competitor) -> float:

    '''
Function: TotalScore

Formal Parameters:

Return Value:
'''
# Return Value:
    return Competitor.Score01 + Competitor.Score02


# Function:
def SortCompetitorsByScore(Competitors: list) -> list:
    '''
Function: SortCompetitorsByScore

Formal Parameters:

Return Value:
'''
# Return Value:
    return sorted(Competitors, key=lambda Competitor: TotalScore(Competitor), reverse=True)


# Variable Initializations

# Input Section

# Processing

Competitors = InputData()
SortedCompetitors = SortCompetitorsByScore(Competitors)

# Any Sub-Processing

# Output Section

print("\nFinal ranking:\n")

for Position, Competitor in enumerate(SortedCompetitors, start=1):
    print(f"{Position}. {Competitor.Name}: Total score = {TotalScore(Competitor)}")
