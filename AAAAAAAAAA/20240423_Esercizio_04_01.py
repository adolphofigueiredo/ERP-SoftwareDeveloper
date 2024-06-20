'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 23/04/2024

Esercizio 4 
Leggi una frase e stampala in ordine inverso.
Esempio:
input: CIAO COME STAI? output: ?IAST EMOC OAIC
'''

# Inizializzazioni Variabili

str = input("\nInserisci la frase: ")                      #Richiesta della stringa.
strinversa = ""                                            #variabile creata per ricevere il valore della stringa invertita.
# Sezione di Input Dati

contatore = -1                                             #Contatore responsabile del controllo di ogni lettera.
 
# Elaborazione

for x in range (1,len(str)+1):                             #Ciclo creato per invertire la stringa inserita.
    strinversa += str[contatore]                           #Accumulatore di ogni lettera prelevata dalla stringa originale.
    contatore -=1                                          #Contatore responsabile del controllo di ogni lettera.
 
# Sezione di Output

print(f"\nLa stampa inversa è '{strinversa}'.\n")          #Stampa della stringa invertita.