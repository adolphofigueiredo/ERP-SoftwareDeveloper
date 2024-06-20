"""
    Author:  First Last
    Date: dd/mm/yyyy

    Title: Cross-country race
    We want to manage the ranking of a 
    cross-country race. At the end of a 
    cross-country race, the bib number, 
    name, and time taken (expressed in 
    hours, minutes, and seconds) are recorded 
    for each participant. We want to print 
    the participants sorted by the time taken.

"""

from dataclasses import dataclass

# definition of data structures
@dataclass
class Time:
    """
    Data structure Time.
    Useful for managing
    the arrival times of the
    cross-country race.
    It defines 4 fields.
    """

    hh: int  # hour
    mm: int  # minutes
    ss: int  # seconds
    total_seconds: int  # total time in seconds


@dataclass
class Participant:
    """
    Data structure Participant.
    Models the participant
    in the cross-country race through
    3 fields.
    """
    bib_number: int  # Bib number
    name: str        # Participant's name
    time_taken: Time # time taken


# Input of the number of participants in the race
def ask_number_of_participants() -> int:
    """
    Function: ask_number_of_participants
    Allows you to enter the number of
    participants in the cross-country race

    Formal parameters:
        None
    Return values:
        int N -> Number of participants
    """
    # initialize N outside domain
    N = -1
    while N <= 0:
        N = int(input("Enter N [>0]: "))

    return N


def enter_bib_number(i: int) -> str:
    """
    Function: enter_bib_number
    Allows you to enter the bib number
    of the i-th participant

    Formal parameters:
        int i -> Registration position of the participant
    Return values:
        int bib_number -> Bib number
    """

    # Enter bib number
    bib_number = input("Enter bib number for participant " + str(i) + ":")

    return bib_number


def enter_name(i: int) -> str:
    """
    Function: enter_name
    Allows you to enter the name of the
    i-th participant

    Formal parameters:
        int i -> Registration position of the participant
    Return values:
        int bib_number -> Bib number
    """

    # Enter participant's name
    name = input("Enter name for participant " + str(i) + ":")

    return name


def calculate_total_seconds(hh: int, mm: int, ss: int) -> int:
    """
    Function: calculate_total_seconds
    Transforms the time from the format
    hh:mm:ss into the total number of seconds

    Formal parameters:
        int hh -> number of hours
        int mm -> number of minutes
        int ss -> number of seconds
    Return values:
        int seconds -> Total number of seconds
    """

    return hh * 3600 + mm * 60 + ss


def enter_time(i: int) -> Time:
    """
    Function: enter_time
    Allows you to enter the time taken
    by the i-th participant to complete
    the cross-country race.

    Formal parameters:
        int i -> Registration position of the participant
    Return values:
        Time time -> time taken by the participant
    """

    # Enter participant's time
    print("Entering time taken by participant", i)
    # Enter hours
    hh = -1
    while hh < 0:
        hh = int(input("hh [>=0]: "))
    # Enter minutes
    mm = -1
    while mm < 0 or mm > 59:
        mm = int(input("mm [0<=mm<=59]: "))
    # Enter seconds
    ss = -1
    while ss < 0 or ss > 59:
        ss = int(input("ss [0<=ss<=59]: "))

    # Calculate the total number of seconds
    total_seconds = calculate_total_seconds(hh, mm, ss)

    # Store data in the dataclass
    time = Time(hh, mm, ss, total_seconds)

    return time


# Input of participant information
def load_table(tab: list[Participant], N: int):
    """
    Function: load_table
    Allows you to enter the participants in the
    cross-country race, each participant is characterized
    by: bib number, name, and time taken

    Formal parameters:
    Participant tab -> table that stores the participants
                       in the cross-country race
    int N -> Total number of participants in the race
    """

    # table loading loop
    for i in range(N):
        bib_number = enter_bib_number(i)
        name = enter_name(i)
        time_taken = enter_time(i)
        participant = Participant(bib_number, name, time_taken)
        tab.append(participant)


# Function that sorts according to the arrival time
def sort(tab: list[Participant], N: int):
    """
    Function: sort
    Sorts in ascending order according to
    the arrival time of the participants
    in the cross-country race

    Formal parameters:
    list tab -> table of participants in the race
    int N -> Total number of participants in the race
    """
    # Sorting loop using the selection sort algorithm
    for i in range(N - 1):
        for j in range(i + 1, N):
            if tab[i].time_taken.total_seconds > tab[j].time_taken.total_seconds:
                tab[i], tab[j] = tab[j], tab[i]
    return tab


# Print race results on the screen
def print_results(tab: list[Participant], N: int) -> None:
    """
    Function: print_results
    Allows you to print all the rows
    of the table given as a formal parameter.

    Formal parameters:
        list[Participant] tab -> Table containing the data of the participants
                                 in the cross-country race
        int N -> Number of participants in the race
    Return values:
        None
    """
    # Print intro
    print("***********************************")
    print("**** CROSS-COUNTRY RACE RESULTS ****")
    print("***********************************")
    print("Bib Number\tName\t\tTime")

    # table record printing loop
    for athlete in tab:
        print(athlete.bib_number, end="\t\t")
        print(athlete.name, end="\t\t")
        print(athlete.time_taken.total_seconds, end="\n")


# Variable initializations
# Participant table in the race
table = list()

# Input Data Section
N = ask_number_of_participants()
load_table(table, N)

# Sorting
table = sort(table, N)

# Output Section
print_results(table, N)
