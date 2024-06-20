# Inserimento N (dimensione della lista)
N = int(input("N: "))
while N < 1:
    N = int(input("REINSERISCI N: "))

# Inserimento N elementi nella lista
lista=[] # creo la lista vuota
# Loop di inserimento elementi nella lista
for i in range(N):
    # richiedo in input l'elemento da inserire nella lista
    elemento=float(input("Inserisci elemento lista: "))
    # Memorizzo l'elemento nella lista
    lista += [elemento]

# stampa della lista sullo standrad output
for ele in lista:
    print("Elemento lista: ",ele)

