from dataclasses import dataclass

    #Funzione:

@dataclass
class Data:
    gg: int
    mm: int
    aaaa: int

    #Funzione:

@dataclass
class Persona :
    Matricola: int
    Nome: str
    Indirizzo: str
    DataNascita: Data
    CodiceFiscale: str
    isConiugato: bool

Dipendente = Persona(1,"Pippo","via xyz 10",Data(17,6,1900),"XYZGHJ17H70265L",True)
Studente   = Persona(1,"Mirko","via ABC 4",Data(1,12,2004),"aaabbb01H04134P",True)

print(Dipendente.isConiugato)

Dipendente.isConiugato = False

print(Dipendente.isConiugato)

print(Studente.Matricola)

print(Studente.DataNascita.aaaa)

print(Dipendente.DataNascita.aaaa)