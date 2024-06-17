'''

Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: The two times
Write a program that reads 2 times in hours, minutes, and seconds and indicates which one comes first.
(Try to solve the exercise without converting everything into seconds).

'''

hour1 = int(input("Enter the hours (24h) of time 1: "))
min1 = int(input("Enter the minutes of time 1: "))
sec1 = int(input("Enter the seconds of time 1: "))
hour2 = int(input("Enter the hours (24h) of time 2: "))
min2 = int(input("Enter the minutes of time 2: "))
sec2 = int(input("Enter the seconds of time 2: "))

if hour1 == hour2:
    if min1 == min2:
        if sec1 == sec2:
            print("The times are equal.")
        elif sec1 < sec2:
            print("The first time comes first.")
        else:
            print("The second time comes first.")
    elif min1 < min2:
        print("The first time comes first.")
    else:
        print("The second time comes first.")
elif hour1 < hour2:
    print("The first time comes first.")
else:
    print("The second time comes first.")
