'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 07/05/2024

Esercizio 01

Memorizzare in una lista di 100 posti i primi cento numeri naturali in ordine inverso.
'''
print("----------1-----------")
Lista = list()
for x in range(1,101):
    Lista += [x]
Lista.reverse()

print(Lista)
print("----------2-----------")
Lista = list()
for x in range(0,100):
    Lista += [x]
Lista.reverse()

print(Lista)
print("----------3-----------")
Lista = list()
for x in range(0,100):
    Lista += [100-x]

print(Lista)
print("----------4-----------")
Lista = list()
for x in range(100,0,-1):
    Lista += [x]

print(Lista)
print("----------------------")    