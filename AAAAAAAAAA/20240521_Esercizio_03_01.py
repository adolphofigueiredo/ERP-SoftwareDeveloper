'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 21/05/2024

Terzo Esercizio

Codificare la struttura che possa contenere i dati relativi al giocatore tesserato in una
squadra di calcio.

'''

from dataclasses import dataclass

# Funzioni:

    #Funzione:

@dataclass
class Data:
    gg: int
    mm: int
    aaaa: int

@dataclass
class Tessera:
    DataNascita: Data
    Nome: str
    Cognome: str
    CodiceFiscale: str
    Ruolo: str
    Squadra: str
    TempoContrattuale: int

#Elaborazione:

Giocatore01 = Tessera(Data(27,12,2005),"Mario","Rossi","TRETQETYQER623634","Attaccante","Corinthians",5)

Giocatore02 = Tessera(Data(4,8,2005),"Ronaldo","Gaucho","TRETQETYDASDAS4","Portiere","Palmeiras",6)

#Output:

print(Giocatore01)
print(Giocatore02)