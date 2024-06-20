'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 03/06/2024

Terzo Esercizio

Alla fine di un concorso vengono pubblicati i risultati delle prove dei concorrenti: vengono
memorizzati, per ogni partecipante:

● il nome,
● il punteggio della prima prova ,
● il punteggio della seconda prova.

Si vuole ottenere la graduatoria finale con la visualizzazione dei concorrenti ordinati in
modo decrescente rispetto al punteggio totale conseguito.
'''


from dataclasses import dataclass

@dataclass
class Concorrente:
    Nome: str
    Voto01: float
    Voto02: float

# Definizione delle Strutture Dati

# Funzioni:

#Funzione:

def InserisciDati() -> list:
    '''
Funzione: InserisciDati

Parametri formali:

Valore di ritorno:

'''
#Parametri formali:

    Concorrenti = []
    NumeroConcorrenti = int(input("Quanti concorrenti vuoi inserire? "))

    for _ in range(NumeroConcorrenti):
        Nome = input("\nInserisci il nome del concorrente: ")
        Punteggio1 = float(input("Inserisci il punteggio della prima prova: "))
        Punteggio2 = float(input("Inserisci il punteggio della seconda prova: "))
        Concorrenti.append(Concorrente(Nome=Nome, Voto01=Punteggio1, Voto02=Punteggio2))
    
#Valore di ritorno:

    return Concorrenti


#Funzione:
def VotoTotale(Concorrente: Concorrente) -> float:

    '''
Funzione: VotoTotale

Parametri formali:

Valore di ritorno:
'''
#Valore di ritorno:
    return Concorrente.Voto01 + Concorrente.Voto02


#Funzione:
def OrdinaConcorrentiVoto(Concorrenti: list) -> list:
    '''
Funzione: InserisciDati

Parametri formali:

Valore di ritorno:
'''
#Valore di ritorno:
    return sorted(Concorrenti, key=lambda Concorrente: VotoTotale(Concorrente), reverse=True)


# Inizializzazioni Variabili

# Sezione di Input Dati
 
# Elaborazione

Concorrenti = InserisciDati()
ConcorrentiOrdinati = OrdinaConcorrentiVoto(Concorrenti)

# Eventuali Sotto Processi di Elaborazione

# Sezione di Output

print("\nGraduatoria finale:\n")

for Posizione, Concorrente in enumerate(ConcorrentiOrdinati, start=1):
    print(f"{Posizione}. {Concorrente.Nome}: Punteggio totale = {VotoTotale(Concorrente)}")

