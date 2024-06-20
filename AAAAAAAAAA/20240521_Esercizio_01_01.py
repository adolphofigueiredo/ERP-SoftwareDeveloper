'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 21/05/2024

Primo Esercizio

Data la seguente definizione di dati:
Modificare la struttura Persona per rappresentare l’indirizzo come una struttura formata
dai campi: via, CAP, Comune.

'''

import dataclasses

# Funzioni:

    #Funzione:

@dataclasses.dataclass
class IndirizzoCompleto:
    Via: str
    CAP: int
    Comune: str

    #Funzione:

@dataclasses.dataclass
class Persona:
    Matricola: int
    Nome: str
    Indirizzo: IndirizzoCompleto
    DataNascita: str
    CodiceFiscale: str
    isConiugato: bool

#Elaborazione:

Persona001 = Persona(20017325,"Adolpho",IndirizzoCompleto("Garessio",10126,"Torino"),"04/03/1982","GASDGGGASD545456",True)
Ind2 = IndirizzoCompleto("Guidobono",10137,"Torino")
Persona002 = Persona(200317325,"Leila",Ind2,"27/04/1986","GFSDYUTYRUTD545456",False)

#Output:

print(Persona001)
print(Persona002)

Persona002.Nome = "Antonella"

print(Persona002)
