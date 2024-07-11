'''

Author: Adolpho Silverio Figueiredo Neto
Date: 01/03/2024

Exercise: Speed Limits

According to Article 142 of the Highway Code:

➔ Anyone who does not observe the minimum speed limits or exceeds the maximum
speed limits by no more than 10 km/h is subject to an administrative fine of
€36.

➔ Anyone who exceeds the maximum speed limits by more than 10 km/h but no more
than 40 km/h is subject to an administrative fine of €148.

➔ Anyone who exceeds the maximum speed limits by more than 40 km/h but no more
than 60 km/h is subject to an administrative fine of €370.

➔ Anyone who exceeds the maximum speed limits by more than 60 km/h is subject to
an administrative fine of €500.

Design an algorithm that reads the maximum allowed speed and the recorded speed
as input and prints a message like:
"Limit respected" or "Limit violated and the fine to pay is ...".

'''

limit = int(input("Enter the maximum speed limit (Km/h): "))
speed = int(input("Enter the recorded speed (Km/h): "))

if speed > limit + 60:
    print("Limit violated and the fine to pay is €500.")
elif speed > limit + 40:
    print("Limit violated and the fine to pay is €370.")
elif speed > limit + 10:
    print("Limit violated and the fine to pay is €148.")
elif speed > limit:
    print("Limit violated and the fine to pay is €36.")
else:
    print("Limit respected!")
