'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 23/04/2024

Esercizio 3
Leggi due stringhe e verifica se una è una sottostringa dell’altra (ovvero se è contenuta
nell’altra).
'''
                                                                                                          
# Inizializzazioni Variabili

str1 = input("Inserisci la prima stringa: ")               #Richiesta della prima stringa che verrà testata.

str2 = input("Inserisci la seconda stringa: ")             #Richiesta della seconda stringa che verrà testata.

# Elaborazione

str1lower = str1.lower()
str2lower = str2.lower()

if str1lower in str2lower:
    print(f"\nÈ possibile trovare la prima stringa: '{str1}' nella seconda stringa: '{str2}'.\n")      #Condizioni create per capire se una stringa
elif str2lower in str1lower:                                                                           #può essere trovata in un'altra o non può
    print(f"\nÈ possibile trovare la seconda stringa: '{str2}' nella prima stringa: '{str1}'.\n")      #essere trovata in nessuna.
else:
    print("Ne uno ne altro.")