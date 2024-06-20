'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 04/03/2024

Quinto Esercizio
Si scriva un programma che simuli lo sblocco di un cellulare, il programma legge un pin di
4 cifre inserito dall’utente e lo imposta come pin. Il programma successivamente chiede di
reinserire il pin, se viene inserito quello corretto scrive “telefono sbloccato”, altrimenti lo
richiede e al terzo tentativo errato visualizza il messaggio “telefono bloccato”
esempio:
Impostazione PIN: 1 2 3 4
Inserimento PIN : 1 2 3 5 -> Errore! Reinserire il PIN
2 Inserimento PIN : 1 2 3 8 -> Errore! Reinserire il PIN
3 Inserimento PIN : 1 2 3 1 -> Errore! PIN BLOCCATO!
Impostazione PIN: 2 1 3 4
Inserimento PIN : 2 1 5 3 -> Errore! Reinserire il PIN
2 Inserimento PIN : 2 1 3 4 -> CORRETTO! CELLULARE SBLOCCATO!

'''

# Sezione di input Dati

pin = input("Impostazione PIN (4 cifre numeriche): ")
tentativo = 0

# Elaborazione

while len(pin) != 4 or pin.isdigit() != True:
    pin = input("\nImpostazione PIN (4 cifre numeriche): ")
test = input("\nInserisci il PIN (4 cifre numeriche): ")
tentativo += 1
while test != pin and tentativo < 3:
    print("Errore! Reinserire il PIN!")
    test = input("\nInserisci il PIN (4 cifre numeriche): ")
    tentativo += 1

# Sezione di output

if test == pin:
    print("\nCorretto! Telefono Sbloccato!")
else:
    print("\nErrore! PIN BLOCCATO!")