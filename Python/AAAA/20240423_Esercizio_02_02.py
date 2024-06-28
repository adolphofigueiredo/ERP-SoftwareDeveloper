'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 23/04/2024

Esercizio 2
Leggi una stringa e determina quante vocali contiene.
'''
##
## Funzioni:
##

def inserisciStringa() -> str:

    '''
Funzione: inserisciStringa
Permette all'utente di inserire una stringa
dallo standard input
Parametri formali:
None
Valore di ritorno:
str stringa -> stringa inserita dall'utente
    '''

# inizializzazione stringa fuori dominio

    stringa = ""

# loop di inserimento e controllo stringa

    while stringa == "":
        stringa = input("Inserisci la stringa (non vuota):")
    return stringa

def isVocale(carattere: str) -> bool:

    '''
Funzione: isVocale
Verifica che il carattere inserito sia
una vocale o meno
Parametri formali:
str carattere -> carattere su cui si esegue il controllo
Valore di ritorno:
bool ret -> set True allora vocale altrimenti False
Fondamenti di programmazione Es. sulle stringhe Massimo Papa 10/17
    '''

# inizializzazione valore di ritoeno

    ret = False
    filtroVocali="aeiouAEIOU"
    if carattere !="": # se carattere non nullo
# seleziono primo carattere della stringa passata
        car = carattere[0]
    if car in filtroVocali:
        ret = True
    return ret

# Funzione molto più compatta

'''
def isVocale1(carattere:str) -> bool:
return carattere in "aeiouAEIOU"
'''

def contaVocali(stringa: str) -> int:

    '''
Funzione: contaVocali
Conta il numero di vocali
contenute nella stringa passata
come parametro
Parametri formali:
str stringa -> stringa su cui si esegue il controllo
Valore di ritorno:
int cont -> conteggio vocali all'interno di str
    '''

# inizializzazione valore di ritoeno

    cont = 0

# loop di conteggio

    for carattere in stringa:
        if isVocale(carattere):
            cont +=1
    return cont

    '''
Es. sulle stringhe Massimo Papa 11/17
Programma principale
L'utente inserisce una stringa
dallo standard input. Successivamente
si contano le vocali e si stampano
sullo standard output
'''

# Sezione di input Dati

stringa = inserisciStringa()

# Elaborazione

numVocali=contaVocali(stringa)

# Output

print(stringa,"-> ",numVocali,"vocali")