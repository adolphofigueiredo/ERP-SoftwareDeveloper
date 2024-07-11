'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 23/04/2024

Esercizio 3
Leggi due stringhe e verifica se una è una sottostringa dell’altra (ovvero se è contenuta
nell’altra).
'''
                                                                                                          
##
## Funzioni:
##

def inserisciStringa(prompt: str) -> str:

    '''
Funzione: inserisciStringa
Permette all'utente di inserire una stringa
dallo standard input
Parametri formali:
str -> prompt che viene visualizzato
Valore di ritorno:
str stringa -> stringa inserita dall'utente
    '''

# inizializzazione stringa fuori dominio

    stringa = ""

# loop di inserimento e controllo stringa

    while stringa == "":
        stringa = input(prompt)
    return stringa

def isContenuta(str2: str, str1: str) -> bool:

    '''
Funzione: isContenuta
Verifica che la stringa str2 sia o meno
all'interno della stringa str1
Parametri formali:
str str2 -> stringa che si vuole verificare
Fondamenti di programmazione Es. sulle stringhe Massimo Papa 13/17
str str1 -> stringa contenitore
Valore di ritorno:
bool ret -> set True allora str2 contenuta in
str1 altrimenti False
    '''

# inizializzazione valore di ritoeno

    ret = False

# loop proncipale di verifica

    i = 0 # i posizione caratteri in str1
    j = 0 # posizione caratteri in str2

# loop sui caratteri di str1 e di str2

    while i < len(str1) and j < len(str2):
        if str1[i] != str2[j]:
            j = 0
        else:
            j += 1
        i += 1

# print("i=", i, "j=", j)
# Verifico il motico per cui sono uscito dal loop

    if j >= len(str2) and i < len(str1): # Ho trovato un'occorrenza di
        ret = True # str2 all'interno di str1
    elif j == 0 and i == len(str1): # str2 si trova al fondo di str1
        ret = True
    elif j == len(str2) and i == len(str1): # str2 == str1
        ret = True
    if j >= len(str2) and i <= len(str1) or j==0 and i==len(str1):
        ret = True

    return ret

# Funzione molto più compatta

"""
def isContenuta1(str2: str, str1: str) -> bool:
return str2 in str1
"""

"""
Programma principale
Il programma permette all'utente di inserire
Fondamenti di programmazione Es. sulle stringhe Massimo Papa 14/17
due stringhe. Poi verifica che la seconda stringa
sia contenuta nella prima.
"""

# Sezione di input Dati

stringa1 = inserisciStringa("Prima stringa")
stringa2 = inserisciStringa("Seconda stringa")

# Elaborazione e output

if isContenuta(stringa2, stringa1):
    print(stringa1, "CONTIENE", stringa2)
else:
    print(stringa1, "NON CONTIENE", stringa2)