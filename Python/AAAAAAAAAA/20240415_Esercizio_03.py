'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 15/04/2024

Terzo Esercizio
Creare una funzione che ricevuti tre importi di denaro sposti gli eventuali debiti (si
considerino debiti gli importi negativi) sul primo importo. Utilizzare i parametri
predefiniti. Creare un programma principale per testare la funzione.

Esempio:

Se gli importi sono  5 -1 -2 gli importi dopo l’applicazione della funzione saranno  2 0 0.
Se gli importi sono -3  4 -2 gli importi dopo l’applicazione della funzione saranno -5 4 0.
Se gli importi sono  4 -2 -2 gli importi dopo l’applicazione della funzione saranno  0 0 0.
Se gli importi sono  6 -4 -3 gli importi dopo l’applicazione della funzione saranno -1 0 0.
'''

def InserisciDebito():
    x1 = int(input("Inserisci il primo debito: "  ))
    x2 = int(input("Inserisci il secondo debito: "))
    x3 = int(input("Inserisci il terzo debito: "  ))
    return x1,x2,x3

def debitoprima(x1,x2,x3):
    if x1 >= 0 and x2 >= 0 and x3 >= 0:
        r1 = x1
        r2 = x2
        r3 = x3
    elif x2 < 0 and x3 < 0:
        r1 = x1 + x2 + x3
        r2 = 0
        r3 = 0
    elif x2 < 0:
        r1 = x1 + x2
        r2 = 0
        r3 = x3
    elif x3 < 0:
        r1 = x1 + x3
        r2 = x2
        r3 = 0

    return r1,r2,r3

x1,x2,x3 = InserisciDebito()

r1,r2,r3 = debitoprima(x1,x2,x3)

print("Importo: ",r1," ",r2," ",r3," ")

#print("Importo 01:",debitoprima( 5,-1,-2))  #Test 01
#print("Importo 02:",debitoprima(-3, 4,-2))  #Test 02
#print("Importo 03:",debitoprima( 4,-2,-2))  #Test 03
#print("Importo 04:",debitoprima( 6,-4,-3))  #Test 04
#print("Importo 05:",debitoprima( 6, 4, 3))  #Test 05