'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 03/06/2024

Secondo Esercizio
Si vuole costruire un programma che gestisca i voti di una materia di una classe di studenti. I voti
durante l’anno possono essere al massimo 10, ma non tutti gli studenti hanno lo stesso numero di voti.
I dati di cui si dispone sono: nome studente e successione di voti (max 10). Scrivere la procedura di
input dei dati. Stampare in output i nomi degli studenti e la loro media, ordinati per media decrescente.

'''

from dataclasses import dataclass

# Definizione delle Strutture Dati

@dataclass
class Studente:
    Nome: str
    Voti: list[float]


# Funzioni:


#Funzione:

def InserisciDati() -> list:
    '''
Funzione: 
InserisciDati
Parametri formali:

Valore di ritorno:

    '''
#Parametri formali:

    Studenti = []
    NumeroStudenti = int(input("Quanti studenti vuoi inserire? "))
    
    for _ in range(NumeroStudenti):
        Nome = input("\nInserisci il nome dello studente: ")
        Voti = []
        
        NumeroVoti = int(input("Quanti voti vuoi inserire per questo studente? (max 10) "))
        if NumeroVoti > 10:
            NumeroVoti = 10
        
        for _ in range(NumeroVoti):
            Voto = float(input(f"Inserisci il voto {len(Voti) + 1}: "))
            Voti.append(Voto)
        
        Studenti.append(Studente(Nome=Nome, Voti=Voti))
#Valore di ritorno:
    
    return Studenti


#Funzione:
def CalcolaMedia(Studente: Studente) -> float:
    '''
Funzione: 
InserisciDati
Parametri formali:

Valore di ritorno:
'''
#Parametri formali:
    
    if not Studente.Voti:
      return 0.0

#Valore di ritorno:
    
    return sum(Studente.Voti) / len(Studente.Voti)

#Funzione:
def StampareGraduatoria(Studenti: list):
    '''
Funzione: 
InserisciDati
Parametri formali:

Valore di ritorno:

    '''
#Parametri formali:
    StudentiOrdinati = sorted(Studenti, key=lambda Studente: CalcolaMedia(Studente), reverse=True)
    
    print("\nGraduatoria degli studenti per media decrescente:\n")
    for Posizione, Studente in enumerate(StudentiOrdinati, start=1):
        Media = CalcolaMedia(Studente)
        print(f"{Posizione}. {Studente.Nome}: Media = {Media:.2f}")

# Inizializzazioni Variabili


# Sezione di Input Dati

 
# Elaborazione

print("Programma di gestione voti degli studenti")
Studenti = InserisciDati()
StampareGraduatoria(Studenti)

# Eventuali Sotto Processi di Elaborazione


# Sezione di Output