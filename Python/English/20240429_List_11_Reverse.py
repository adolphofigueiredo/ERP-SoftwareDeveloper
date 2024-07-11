'''
Author: Adolpho Silverio Figueiredo Neto
Date: 07/05/2024

Exercise 01

Store in a list of 100 positions the first one hundred natural numbers in reverse order.
'''
print("----------1-----------")
Lista = list()
for x in range(1, 101):
    Lista += [x]
Lista.reverse()

print(Lista)
print("----------2-----------")
Lista = list()
for x in range(0, 100):
    Lista += [x]
Lista.reverse()

print(Lista)
print("----------3-----------")
Lista = list()
for x in range(0, 100):
    Lista += [100 - x]

print(Lista)
print("----------4-----------")
Lista = list()
for x in range(100, 0, -1):
    Lista += [x]

print(Lista)
print("----------------------")
