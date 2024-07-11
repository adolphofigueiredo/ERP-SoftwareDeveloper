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

dt=Data(1,1,2000)
docente01 = Docente("Adolpho","Silverio",dt,"hghjgasd",IndirizzoCompleto("adas",10,"to"),"Insegnante")
listainforDocente = ["Adolpho","silverio",dt,"hghjgasd",IndirizzoCompleto("adas",10,"to"),"Insegnante"] 
#Na linha 43 e 44 sao os mesmo dados porém estao armazenados de maneiras diferentes, ou seja, nao é a mesma coisa.

print(docente01)
print(listainforDocente)