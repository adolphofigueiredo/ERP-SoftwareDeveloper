'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 23/04/2024

Esercizio 1
Data una stringa in input indicare in output se la stringa è palindroma oppure no.
Esempio:
input: ANNA output: PALINDROMA
input: CIAO output: NON PALINDROMA
'''

# Inizializzazioni Variabili

contatore = -1                                              #Contatore creato per invertire la parola.
parolainv = ""                                              #Inizializzazione della variabile che riceverà la parola inversa.

# Sezione di Input Dati

parola = input("Inserisci la parola: ")                    #Richiesta di inserimento input, la parola.
 
# Elaborazione

parola = parola.lower()                                    #Converti tutte le lettere in minuscolo.                                   

for x in range (1,len(parola)+1):                          #Looping creato per invertire la parola.
    parolainv += parola[contatore]                         #Variabile creata per ricevere i valori della parola invertita.                   
    contatore -= 1                                         #Contatore che cambia la lettera che verrà assegnata ogni volta che passa attraverso il loop.

# Sezione di Output

if parola == parolainv:                                    #Controllo che verifica se la parola invertita è uguale alla parola inserita.
    print(f"La parola {parola} è palindroma.")             #Risultato quando la parola è palindroma.
else:
    print(f"La parola {parola} NON è palindroma.")         #Risultato quando la parola non è palindroma.