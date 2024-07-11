'''
Author: Adolpho Silverio Figueiredo Neto
Date: 28/05/2024

First Exercise
Write a Python program to manage the teams of a football league.
The teams are defined by the following information:

● team name,
● team code,
● goals scored,
● goals conceded.

Construct a program that prints a menu with the following options:
1. Enter N football teams
2. Print all teams that have scored more goals than conceded
3. Given a team's code, print all its data
4. Print all teams in alphabetical order by name
5. Exit
'''

from dataclasses import dataclass

# Definition of Data Structures

@dataclass
class Team:
    TeamName: str
    TeamCode: str
    GoalsScored: int
    GoalsConceded: int

# Functions:

    # Function:

def Menu() -> bool:

    '''
Function: Menu
Function created to print the menu and receive the selected input.

Formal parameters:

Return value:
choice --> Variable created to choose the menu option.
    '''
    # Formal parameters:

    choice = input('''-------------------------------------------------------------------------------------
                                        MENU
-------------------------------------------------------------------------------------
1. Enter N football teams
2. Print all teams that have scored more goals than conceded
3. Given a team's code, print all its data
4. Print all teams in alphabetical order by name
5. Exit
-------------------------------------------------------------------------------------
Select one of the options: ''')
    print("-------------------------------------------------------------------------------------")

    # Return value:

    return choice

    # Function:

def ConfirmExit(Exit:bool) -> bool:

    '''
Function: ConfirmExit
Function created to confirm exiting the program.

Formal parameters:

Return value:
exit --> Variable that activates the exit confirmation from the program.
    '''
    
    # Formal parameters:
    
    Confirm = input("Confirm exit?\nY - Yes\nN - No\n")
    if (Confirm == "Y") or (Confirm == "y"):
        Exit = True
    print("-------------------------------------------------------------------------------------")

    # Return value:

    return Exit

    # Function:

def EnterTeam(TeamList:list[Team], TeamInfo:bool):
    
    '''
Function: EnterTeam
Function created to enter the team and its information

Formal parameters:
TeamName   --> Variable that stores the team name.
TeamCode   --> Variable that stores the team code.
GoalsScored  --> Variable that stores the goals scored by the team.
GoalsConceded --> Variable that stores the goals conceded by the team.

Return value:
TeamList --> List that stores information about the teams.
TeamInfo  --> Boolean indicating if the list is empty.

    '''

    # Formal parameters:

    TeamInfo = True
    TeamName = ""
    TeamCode = ""
    GoalsScored = -1
    GoalsConceded = -1



    while TeamName == "":
        TeamName = input("Enter the team name: ")

    while TeamCode == "":
        TeamCode = input("Enter the team code: ")

    while GoalsScored < 0:
        GoalsScored = int(input("Enter the number of goals scored: "))

    while GoalsConceded < 0:
        GoalsConceded = int(input("Enter the number of goals conceded: "))

    TeamList.append(Team(TeamName, TeamCode, GoalsScored, GoalsConceded))

    # Return value:

    return TeamList, TeamInfo

    # Function:

def PrintGoalsMoreThanConceded(TeamList:list[Team], TeamInfo:bool):

    '''
Function: PrintGoalsMoreThanConceded
Function created to print all teams that have scored more goals than conceded.

Formal parameters:

Return value:
TeamList --> List that stores information about the teams.
TeamInfo  --> Boolean indicating if the list is empty.

    '''

    # Formal parameters:
    
    if not TeamInfo:
    
        print("Error - Please enter at least one team before selecting this option!")
    
    else:

        print("Code", "TeamName       ", "Scored", "Conceded")
        print("-------------------------------------------------------------------------------------")

        for team in TeamList:
        
            if team.GoalsScored > team.GoalsConceded:
        
                print(f"{team.TeamCode:>6} {team.TeamName:<15} {team.GoalsScored:>7} {team.GoalsConceded:>6}")
    
    # Return value:

    return TeamList, TeamInfo

    # Function:

def PrintTeam(TeamList:list[Team], TeamInfo:bool):

    '''
Function: PrintTeam
Function created to print a specific team based on its code.

Formal parameters:
N --> Number of elements in the list
Found --> Boolean variable indicating if the key was found in the list
Counter --> Counter that records the number of search attempts for the key in the list
Search --> The search key

Return value:
TeamList --> List that stores information about the teams.
TeamInfo  --> Boolean indicating if the list is empty. 

    '''

    # Formal parameters:
    
    if not TeamInfo:
    
        print("Error - Please enter at least one team before selecting this option!")
    
    else:

        Found = False

        Search = input("Enter the code to search: ")
        print("-------------------------------------------------------------------------------------")

        for team in TeamList:

            if team.TeamCode == Search:

                Found = True

                print("Code", "TeamName       ", "Scored", "Conceded")
                print("-------------------------------------------------------------------------------------")
                print(f"{team.TeamCode:>6} {team.TeamName:<15} {team.GoalsScored:>7} {team.GoalsConceded:>6}")

                break

        if not Found:

            print("Code not found!")                

    # Return value:

    return TeamList, TeamInfo

    # Function:

def PrintTeamsInAlphabeticalOrder(TeamList:list[Team], TeamInfo:bool):

    '''
Function: PrintTeamsInAlphabeticalOrder
Function created to print all teams in alphabetical order.

Formal parameters:
N --> Number of elements in the list

Return value:
TeamList --> List that stores information about the teams.
TeamInfo  --> Boolean indicating if the list is empty. 

    '''

    # Formal parameters:
    
    if not TeamInfo:
    
        print("Error - Please enter at least one team before selecting this option!")
    
    else:
        N = len(TeamList)
        for i in range(N):
            for j in range(i, N):
                if TeamList[i].TeamName > TeamList[j].TeamName:
                    TeamList[i], TeamList[j] = TeamList[j], TeamList[i]
    
    print("---------------------------------- O r d e r e d ----------------------------------")
    print("Code", "TeamName       ", "Scored", "Conceded")
    print("-------------------------------------------------------------------------------------")
    
    for team in TeamList:
        print(f"{team.TeamCode:>6} {team.TeamName:<15} {team.GoalsScored:>7} {team.GoalsConceded:>6}")

    # Return value:

    return TeamList, TeamInfo

# Variable Initializations

TeamList = list()
Exit = False
TeamInfo = False

# Data Input Section
 
# Processing

while not Exit:

    choice = Menu()
    
    match choice:

        case "1":
            
            TeamList, TeamInfo = EnterTeam(TeamList, TeamInfo)
            print("-------------------------------------------------------------------------------------")

        case "2":
        
            TeamList, TeamInfo = PrintGoalsMoreThanConceded(TeamList, TeamInfo)
            print("-------------------------------------------------------------------------------------")
        
        case "3":
        
            TeamList, TeamInfo = PrintTeam(TeamList, TeamInfo)
            print("-------------------------------------------------------------------------------------")
        
        case "4":
            
            TeamListOrdered, TeamInfo = PrintTeamsInAlphabeticalOrder(TeamList, TeamInfo)
            print("-------------------------------------------------------------------------------------")
        
        case "5":
            
            Exit = ConfirmExit(Exit)

# Any Sub-processes

# Output Section

#print("Code", "TeamName       ", "Scored", "Conceded")
#print("-------------------------------------------------------------------------------------")

#for team in TeamList:
#    print(f"{team.TeamCode:>6} {team.TeamName:<15} {team.GoalsScored:>7} {team.GoalsConceded:>6}")

#print("---------------------------------- O r d e r e d ----------------------------------")
#print("Code", "TeamName       ", "Scored", "Conceded")
#print("-------------------------------------------------------------------------------------")

#for team in TeamListOrdered:
#    print(f"{team.TeamCode:>6} {team.TeamName:<15} {team.GoalsScored:>7} {team.GoalsConceded:>6}")

#print("-------------------------------------------------------------------------------------")
