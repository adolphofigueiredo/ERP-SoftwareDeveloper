'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 19/03/2024

Esercizio: Tabella Somme (Cicli Anidificati)

Si vuole stampare in output la tabella di tutte le possibili somme che si possono ottenere
lanciando due dadi con N facce (N inserito in input).
Esempio: N = 4

  1 2 3 4
1 2 3 4 5
2 3 4 5 6
3 4 5 6 7
4 5 6 7 8

Attenzione:
● Non si devono stampare i contorni delle righe e colonne della tabella e numeri con
sfondo grigio. Per formattare le stampe si ricordi che si puo’ utilizzare la
tabulazione:
print(end=“\t” )

● Si devono necessariamente utilizzare i cicli annidati.

'''

# Sezione di input Dati

N = int(input("\nInserisci il numero di facce del dado: ")) #Numero di facce del dado
while N <= 0:                                               #Loop creato per garantire che il numero di dati da inserire sia positivo.
    N = int(input("\nErrore - Il numero deve essere positivo!\n\nInserisci il numero di facce del dado: "))

# Inizializzazioni variabili

riga = 2
colonna = 0

# Elaborazione

while riga < N + 2:                                 #Ciclo creato per calcolare la prima variabile della riga
    print("\n" , riga , end = "\t")
    riga += 1
    colonna = riga
    volte = 1
    while volte < N:                             #Ciclo creato per calcolare le altre variabile della riga
        print(colonna , end = "\t")
        colonna +=1
        volte +=1
print("\n")

# Eventuali sotto processi di Elaborazione

# Sezione di output
