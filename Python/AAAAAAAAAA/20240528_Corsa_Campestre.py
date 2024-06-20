"""
    Autore:  Nome Cognome
    Data: gg/mm/aaaa

    Titolo: Corsa campestre
    Si vuole gestire la classifica di una gara 
    campestre di corsa.  Alla fine di una gara 
    campestre vengono memorizzati, per ogni 
    partecipante, il numero di pettorale, il 
    nome e il tempo impiegato espresso in ore, 
    minuti e secondi. Si vuole la stampa dei 
    partecipanti ordinati rispetto al tempo 
    impiegato.

"""

from dataclasses import dataclass

# definizione delle strutture dati
@dataclass
class Tempo:
    """
    Struttura dati Tempo. 
    Utile per gestire
    i tempi di arrivo della
    corsa campestre.
    Sono definit 4 campi.
    """

    hh: int  # ora
    mm: int  # minuti
    ss: int  # secondi
    totSecondi: int  # conteggio tempo in secondi


@dataclass
class Partecipante:
    """
    Struttura dati Partecipante. 
    Modellizza il partecipante
    alla gara campestre attraverso
    3 campi.
    """
    pettorale: int  # Numero del pettorale
    nome: str       # Nome del partecipante
    tempoImpiegato: Tempo   # tempo impiegato


# Input del numero dei partecipanti alla gara
def chiediNumPartecipanti() -> int:
    """
    Funzione: chiediNumPartecipanti
    Permette di inserire il numero di
    partecipanti alla corsa campestre

    Parametri formali:
        None
    Valori di ritorno:
        int N -> Numero di partecipanti
    """
    # inizializzazione N fuori dominio
    N = -1
    while N <= 0:
        N = int(input("Inserisci N [>0]: "))

    return N


def inserisciNumeroPettorale(i: int) -> str:
    """
    Funzione: inserisciNumeroPettorale
    Permette di inserire il numero del pettorale
    al partecipante i-esimo

    Parametri formali:
        int i -> Posizione di registrazione partecipante
    Valori di ritorno:
        int pettorale -> Numero di pettorale
    """

    # Inserimento pettorale
    pettorale = input("Inserisci pettorale partecipante " + str(i) + ":")

    return pettorale


def inserisciNome(i: int) -> str:
    """
    Funzione: inserisciNome
    Permette di inserire il nome del
    partecipante i-esimo

    Parametri formali:
        int i -> Posizione di registrazione partecipante
    Valori di ritorno:
        int pettorale -> Numero di pettorale
    """

    # Inserimento nome partecipante
    nome = input("Inserisci nome partecipante " + str(i) + ":")

    return nome


def calcolaSecondiTotali(hh: int, mm: int, ss: int) -> int:
    """
    Funzione: calcolaSecondiTotali
    Trasforma il tempo dal formato
    hh:mm:ss in numero di secondi
    totali

    Parametri formali:
        int hh -> numero di ore
        int mm -> numero di minuti
        int ss -> numero di secondi
    Valori di ritorno:
        int secondi -> Numero di secondi totali
    """

    return hh * 3600 + mm * 60 + ss


def inserisciTempo(i: int) -> Tempo:
    """
    Funzione: inserisciTempo
    Permette di inserire il tempo impiegato
    dal partecipante i-esimo per terminare
    la gara campestre.

    Parametri formali:
        int i -> Posizione di registrazione partecipante
    Valori di ritorno:
        Tempo tempo -> tempo impiegato dal partecipante
    """

    # Inserimento tempo partecipante
    print("Inserimento tempo impiegato dal partecipante", i)
    # Inserimento ore
    hh = -1
    while hh < 0:
        hh = int(input("hh [>0]: "))
    # Inserimento minuti
    mm = -1
    while mm < 0 or mm > 59:
        mm = int(input("mm [0<=mm<=59]: "))
    # Inserimento secondi
    ss = -1
    while ss < 0 or ss > 59:
        ss = int(input("ss [0<=ss<=59]: "))

    # Calcola il numero totale di secondi
    totSecondi = calcolaSecondiTotali(hh, mm, ss)

    # Memorizza dati nella dataclass
    tempo = Tempo(hh, mm, ss, totSecondi)

    return tempo


# Input delle informazioni dei partecipanti
def caricaTabella(tab: list[Partecipante], N: int):
    """
    Funzione: caricaTabella
    Permette di inserire i partecipanti alla
    corsa campestre, ogni partecipante è caratterizzato
    da: numero pettorale, nome e tempo impiegato

    Parametri formali:
    Partecipante tab -> tabella che memorizza i partecipanti
                        alla gara campestre
    int N -> Numero totale di partecipanti alla gara
    """

    # loop di caricamento tabella
    for i in range(N):
        pettorale = inserisciNumeroPettorale(i)
        nome = inserisciNome(i)
        tempoImpiegato = inserisciTempo(i)
        partecipante = Partecipante(pettorale, nome, tempoImpiegato)
        tab.append(partecipante)


# Funzione che effettua l’ordinamento
# a secondo del tempo di arrivo
def ordina(tab: list[Partecipante], N: int):
    """
    Funzione: ordina
    Effettua l'ordinamento crescente secondo
    l'ordine di arrivo al traguardo dei
    partecipanti alla gara campèestre

    Parametri formali:
    list tab -> tabella dei partecipanti alla gara
    int N -> Numero totale di partecipanti alla gara
    """
    ###tab.sort(reverse=False,key=lambda k: k.tempoImpiegato.totSecondi)
    # Loop di ordinamento secondo l'algoritmo selection sort
    for i in range(N - 1):
        for j in range(i + 1, N):
            if tab[i].tempoImpiegato.totSecondi > tab[j].tempoImpiegato.totSecondi:
                tab[i], tab[j] = tab[j], tab[i]
    return tab


# Stampa a video dei risultati della gara
def stampa(tab: list[Partecipante], N: int) -> None:
    """
    Funzione: stampa
    Permette di inserire tutte le righe
    della tabella data come parametro formale.

    Parametri formali:
        list[Partecipante] tab -> Tabella contente i dati dei partecipanti
                                  alla gara campestre
        int N -> Numero di partecipoanti alla gara
    Valori di ritorno:
        None
    """
    # Stampa intro
    print("***********************************")
    print("**** CLASSIFICA GARA CAMPESTRE ****")
    print("***********************************")
    print("Pettorale\tNome\t\tTempo")

    # loop di stampa record tabella
    for atleta in tab:
        print(atleta.pettorale, end="\t\t")
        print(atleta.nome, end="\t\t")
        print(atleta.tempoImpiegato.totSecondi, end="\n")


# Inizializzazioni variabili
# Tabella dei partecipanti alla gara
tabella = list()

# Sezione di input Dati
N = chiediNumPartecipanti()
caricaTabella(tabella, N)

# Ordinamento
tabella = ordina(tabella, N)

# Sezione di output
stampa(tabella, N)
