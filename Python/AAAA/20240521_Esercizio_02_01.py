'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 21/05/2024

Secondo Esercizio

Codificare una struttura che possa contenere i dati relativi al docente di una scuola.

'''

from dataclasses import dataclass

# Funzioni:

    #Funzione:

@dataclass
class Data:
    gg: int
    mm: int
    aaaa: int

    #Funzione:

@dataclass
class IndirizzoCompleto:
    Via: str
    CAP: int
    Comune: str

    #Funzione:

@dataclass
class Docente:
    Nome: str
    Cognome: str
    DataNascita: Data
    CodiceFiscale: str
    Indirizzo: IndirizzoCompleto
    Qualifica: str

#Elaborazione:

DT = Data(4,3,1982)
Docente01 = Docente("Adolpho","Figueiredo",DT,"hghjgasd",IndirizzoCompleto("Garessio",10126,"Torino"),"Insegnante")
ListaInfoDocente = ["Adolpho","Figueiredo",DT,"hghjgasd",IndirizzoCompleto("Garessio",10126,"Torino"),"Insegnante"] 

#Output:

print(Docente01)
print(ListaInfoDocente)