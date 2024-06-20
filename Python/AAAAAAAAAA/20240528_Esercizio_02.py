'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 28/05/2024

Secondo Esercizio
Un negozio di alimentari ha un archivio (tabella) in cui vengono memorizzati i prodotti presenti in magazzino.
Per ogni prodotto in magazzino, si dispone dei seguenti dati:
● la descrizione,
● la quantità disponibile in magazzino,
● la data di scadenza.
Il programma deve memorizzare in un altra tabella tutti i prodotti che sono da cancellare dall'archivio perché
scaduti (un prodotto è scaduto quando l'anno di scadenza è inferiore al 2024).

'''
from dataclasses import dataclass

# Definizione delle Strutture Dati

@dataclass
class Data:
    gg: int
    mm: int
    aaaa: int

@dataclass
class Prodotto:
    Descrizione: str
    Quantita: int
    Misura: str
    Scadenza: Data

# Inizializzazioni Variabili

Magazzino = list()
MagazzinoScaduto = list()

# Sezione di Input Dati

Magazzino.append(Prodotto("Filetto di Manzo",15,"kg",Data(20,6,2029)))
Magazzino.append(Prodotto("Salmone Fresco",10,"kg",Data(5,6,2027)))
Magazzino.append(Prodotto("Formaggio Parmigiano",8,"kg",Data(15,9,2028)))
Magazzino.append(Prodotto("Patata Inglese",50,"kg",Data(10,7,2021)))
Magazzino.append(Prodotto("Olio",30,"litri",Data(1,1,2023)))
Magazzino.append(Prodotto("Lattuga Riccia",25,"unità",Data(3,6,2022)))
Magazzino.append(Prodotto("Pomodoro Italiano",40,"kg",Data(7,6,2022)))
Magazzino.append(Prodotto("Riso Arborio",20,"kg",Data(30,12,2024)))
Magazzino.append(Prodotto("Vino Bianco Secco",60,"bottiglie",Data(1,12,2026)))
Magazzino.append(Prodotto("Gamberi Medi",25,"kg",Data(15,6,2022)))
Magazzino.append(Prodotto("Farina di Grano",100,"kg",Data(1,11,2023)))
Magazzino.append(Prodotto("Zucchero di Canna",15,"kg",Data(20,8,2023)))
Magazzino.append(Prodotto("Fagioli Neri",30,"kg",Data(25,10,2022)))
Magazzino.append(Prodotto("Pepe Nero",5,"kg",Data(2,4,2025)))
Magazzino.append(Prodotto("Salsa di Soia",40,"litri",Data(15,3,2025)))
Magazzino.append(Prodotto("Burro Senza Sale",20,"kg",Data(1,7,2024)))
Magazzino.append(Prodotto("Pollo Disossato",50,"kg",Data(15,7,2024)))
Magazzino.append(Prodotto("Carota",30,"kg",Data(12,6,2025)))
Magazzino.append(Prodotto("Miele Biologico",25,"kg",Data(1,1,2023)))
Magazzino.append(Prodotto("Latte Intero",100,"litri",Data(5,6,2024)))
Magazzino.append(Prodotto("Farina di Mais",40,"kg",Data(20,9,2022)))
Magazzino.append(Prodotto("Panna Fresca",30,"litri",Data(15,7,2025)))
Magazzino.append(Prodotto("Pasta Penne",60,"kg",Data(30,12,2024)))
Magazzino.append(Prodotto("Aglio",10,"kg",Data(1,8,2022)))
Magazzino.append(Prodotto("Broccoli",20,"kg",Data(8,6,2022)))

# Elaborazione

for Prodotto in Magazzino:
    if Prodotto.Scadenza.aaaa < 2024:
        MagazzinoScaduto.append(Prodotto)

# Eventuali Sotto Processi di Elaborazione


# Sezione di Output

print("-----------------------------------------------------------")
print("------------------------ Prodotti -------------------------")
print("-----------------------------------------------------------")

for Prodotto in Magazzino:
    print(f"{Prodotto.Descrizione:20}",end="\t")
    print(f"{Prodotto.Quantita:5}",end="\t")
    print(f"{Prodotto.Misura:8}",end="\t")
    print(f"{Prodotto.Scadenza.gg}","/",f"{Prodotto.Scadenza.mm}","/",f"{Prodotto.Scadenza.aaaa}",sep="")

print("-----------------------------------------------------------")
print("-------------------- Prodotti Scaduti ---------------------")
print("-----------------------------------------------------------")

for Prodotto in MagazzinoScaduto:
    print(f"{Prodotto.Descrizione:20}",end="\t")
    print(f"{Prodotto.Quantita:5}",end="\t")
    print(f"{Prodotto.Misura:8}",end="\t")
    print(f"{Prodotto.Scadenza.gg:>}","/",f"{Prodotto.Scadenza.mm:>}","/",f"{Prodotto.Scadenza.aaaa:>}",sep="")

print("-----------------------------------------------------------")
print("-----------------------------------------------------------")