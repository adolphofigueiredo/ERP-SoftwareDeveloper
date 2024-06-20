'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 23/04/2024

Esercizio 1
Data una stringa in input indicare in output se la stringa è palindroma oppure no.
Esempio:
input: ANNA output: PALINDROMA
input: CIAO output: NON PALINDROMA
'''


##
## Funzioni:
##

def inserisciStringa() -> str:

    '''
Funzione: inserisciStringa
Permette all'utente di inserire una stringa dallo standard input
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

def isPalindroma(stringa: str) -> bool:

    """
Fondamenti di programmazione Es. sulle stringhe Massimo Papa 7/17
Funzione: isPalindroma
Verifica che la stringa passata come argomento formale
sia palindromo o meno.
Parametri formali:
str stringa -> stringa su cui si esegue il controllo
Valore di ritorno:
bool ret -> set True allora palindorma altrimenti False
    """

# inizializzazione valore di ritoeno

    ret = True

# Lunfghezza della stringa

    lunStr = len(stringa)

# loop di verifica

    pos=0

    while pos < lunStr / 2 and ret:
        if stringa[pos] != stringa[lunStr - pos - 1]:
            ret = False
            pos +=1

    return ret
    
    '''
def isPalindroma_FOR(stringa: str) -> bool:
    """
Funzione: isPalindroma
Verifica che la stringa passata come argomento formale
sia palindromo o meno.
Parametri formali:
str stringa -> stringa su cui si esegue il controllo
Valore di ritorno:
bool ret -> set True allora palindorma altrimenti False
    """

# inizializzazione valore di ritoeno

    ret = True

# Lunfghezza della stringa

    lunStr = len(stringa)

# loop di verifica

    for pos in range(int(lunStr / 2)):
        if stringa[pos] != stringa[lunStr - pos - 1]:
            ret = False
            break
    return ret
    '''
    '''
def isPalindroma_PROPSTR(stringa: str) -> bool:

    """
Funzione: isPalindroma
Verifica che la stringa passata come argomento formale
sia palindromo o meno.
Parametri formali:
str stringa -> stringa su cui si esegue il controllo
Valore di ritorno:
bool ret -> set True allora palindorma altrimenti False
    """

    return stringa == stringa[::-1]
    '''

"""
Programma principale
L'algortimo stampa sullo standard output
se la stringa inserita dall'utente è
palindroma oppure no.
"""

# Sezione di input Dati

stringa = inserisciStringa()

# Elaborazione e output

if isPalindroma(stringa):
    print(stringa, "-> PALINDROMA")
else:
    print(stringa, "-> NON PALINDROMA")