'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 23/04/2024

Esercizio 2
Leggi una stringa e determina quante vocali contiene.
'''
                                                                                                          
# Inizializzazioni Variabili

parola = input("\nInserisci la stringa: ").lower()         #Richiesta di inserimento dati.
contatore = 0                                              #Contatore responsabile del controllo di ogni lettera.
vocale = 0                                                 #Contatore responsabile del conteggio di ogni vocale trovata.
 
# Elaborazione

for x in range (1,len(parola)+1):                          #Loop creato per controllare ogni lettera della stringa inserita.
    verifica = parola[contatore]                           #Selezione di una lettera in base al contatore
    contatore += 1                                         #Contatore creato per modificare il controllo di ogni lettera.
    if verifica == "a" or verifica == "e" or verifica == "i" or verifica == "o" or verifica == "u":     #Condizione creata per testare se è una vocale o no.
        vocale += 1                                        #Attivazione del contatore responsabile del conteggio di ogni vocale trovata.

# Sezione di Output

if vocale == 0:
    print("Questa stringa non contiene vocali.\n")         #Condizione creata per determinare quale modello di risposta verrà utilizzato?
elif vocale == 1:
    print(f"Questa stringa contiene {vocale} vocale.\n")
else:
    print(f"Questa stringa contiene {vocale} vocali.\n")