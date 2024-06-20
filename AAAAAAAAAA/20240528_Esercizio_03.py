'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 28/05/2024

Terzo Esercizio
Un ambulatorio dentistico utilizza una tabella per memorizzare tutte le prenotazioni effettuate per il mese di Luglio.
Le prenotazioni hanno il seguente tracciato record: cognome e data (numero compreso da 1 a 31).
Si scriva una funzione che stampi sullo standard output quali siano i giorni liberi.
Si costruisca il programma che carichi la tabella e provi la funzione progettata.

'''
from dataclasses import dataclass

# Definizione delle Strutture Dati

@dataclass
class Prenotazioni:
    Giorno: int
    Nome: str
    Cognome: str

# Funzioni:


    #Funzione:
def IsLiberi(Prenotato:list , GiorniLiberi:list) -> list: 
    '''
Funzione:
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Parametri formali:
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxx --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
Valore di ritorno:
Lista --> xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx   
    '''

    #Parametri formali:

    Trovato = False

    Mese = int(input("\nQuanti giorni ci sono nel mese che vuoi analizzare? "))
    
    for i in range ( 1 , Mese + 1 ):

        for Prenotazioni in Prenotato:

            if Prenotazioni.Giorno == i:
                Trovato = True
                break

        if not Trovato:
            GiorniLiberi.append(i)

        Trovato = False
   
    #Valore di ritorno:

    return GiorniLiberi
                                                                                                          
# Inizializzazioni Variabili

Prenotato = list()
GiorniLiberi = list()

# Sezione di Input Dati

Prenotato.append(Prenotazioni(22,"Adolpho","Figueiredo"))
Prenotato.append(Prenotazioni(5,"Giovanni","Rossi"))
Prenotato.append(Prenotazioni(14,"Maria","Bianchi"))
Prenotato.append(Prenotazioni(19,"Carlo","Ricci"))
Prenotato.append(Prenotazioni(7,"Anna","Ferrari"))
Prenotato.append(Prenotazioni(23,"Pietro","Esposito"))
Prenotato.append(Prenotazioni(30,"Luca","Romano"))
Prenotato.append(Prenotazioni(8,"Marina","Colombo"))
Prenotato.append(Prenotazioni(21,"Paolo","Bruno"))
Prenotato.append(Prenotazioni(12,"Riccardo","Galli"))
Prenotato.append(Prenotazioni(27,"Francesca","Conti"))
Prenotato.append(Prenotazioni(15,"Gabriele","De Luca"))
Prenotato.append(Prenotazioni(3,"Luana","Costa"))
Prenotato.append(Prenotazioni(10,"Filippo","Greco"))
Prenotato.append(Prenotazioni(29,"Giulia","Marino"))
Prenotato.append(Prenotazioni(6,"Daniele","Giordano"))
Prenotato.append(Prenotazioni(22,"Alessia","Rizzo"))
Prenotato.append(Prenotazioni(11,"Raffaele","Lombardi"))
Prenotato.append(Prenotazioni(2,"Laura","Barone"))
Prenotato.append(Prenotazioni(17,"Matteo","Leone"))
Prenotato.append(Prenotazioni(26,"Beatrice","Moretti"))
Prenotato.append(Prenotazioni(9,"Gustavo","Serra"))
Prenotato.append(Prenotazioni(1,"Camilla","Sanna"))
Prenotato.append(Prenotazioni(22,"Matteo","Ferri"))
Prenotato.append(Prenotazioni(16,"Bianca","Riva"))
Prenotato.append(Prenotazioni(20,"Isabella","Grassi"))
 
# Elaborazione

GiorniLiberi = IsLiberi(Prenotato , GiorniLiberi) 

# Eventuali Sotto Processi di Elaborazione

# Sezione di Output

print("\n---------- Prenotazioni -----------\n")

for Prenotazioni in Prenotato:
    print(f"{Prenotazioni.Giorno:<3} - {Prenotazioni.Nome:<15} {Prenotazioni.Cognome:<15}")

print("\n---------- Giorni Liberi ----------\n")


for i in GiorniLiberi:
    print(i, " - Libero")

print("\n-----------------------------------\n")