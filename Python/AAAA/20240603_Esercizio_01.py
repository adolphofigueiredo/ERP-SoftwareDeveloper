'''
Autore: Adolpho Silverio Figueiredo Neto
Data: 03/06/2024

Primo Esercizio

Una tabella contiene l'andamento delle quotazioni di alcune azioni in borsa nell'ultima settimana.
La struttura è definita in questo modo: nome, valori: una sequenza di 7 float (uno per ogni giorno
della settimana).Il programma deve visualizzare sullo schermo quante azioni hanno avuto un calo
superiore al 10% in una sola giornata.

Esempio:

Stellantis 100 98 97 96 110 109 105
ACME 100 95 100 88 81 105 107

Il programma dovrà fornire come risultato 1, in quanto la ACME ha avuto un calo superiore al 10%
fra il terzo e il quarto giorno.

'''

from dataclasses import dataclass

@dataclass
class Azione:
    Ticker: str
    Prices: list
    

# Definizione delle Strutture Dati

# Funzioni:

#Funzione:
def InserisciDatiAzione() ->  list:

    '''
Funzione: InserisciDatiAzione

Parametri formali:

Valore di ritorno:

    '''

#Parametri formali:

    Stocks = []

    NumeroAzioni = int(input("Quante azioni vuoi inserire? "))

    for x in range(NumeroAzioni):
        
        NumeroPrice = -1
        Ticker = input("\nInserisci il ticker dell'azione: ")
        Prices = []

        while NumeroPrice <= 0 or NumeroPrice > 7:
            NumeroPrice =  int(input("Quanti prezzi vuoi inserire (Max = 7)? "))
        
        for y in range (NumeroPrice):
        
            Price = float(input(f"Inserisci il valore { y + 1 }: "))
            Prices.append(Price)
        
        Stocks.append(Azione(Ticker=Ticker, Prices=Prices))

#Valore di ritorno:

    return Stocks

#Funzione:
def CaloSignificativo(PrezzoPrecedente , PrezzoCorrente) -> float:
    '''
Funzione: CaloSignificativo

Parametri formali:

Valore di ritorno:

    '''

#Parametri formali:

    Delta = (PrezzoPrecedente - PrezzoCorrente) / PrezzoPrecedente * 100

#Valore di ritorno:

    return Delta


#Funzione:
def ContatoreCaloSignificativo(Stocks) -> int:
    '''
Funzione: ContatoreCaloSignificativo

Parametri formali:

Valore di ritorno:

'''

#Parametri formali:

    Contatore = 0

    for Azione in Stocks:
        Prices = Azione.Prices
        for i in range (1 , len(Prices)):
            Calo = CaloSignificativo(Prices[i-1], Prices[i])
            if Calo > 10:
                Contatore += 1
                break

#Valore di ritorno:

    return Contatore


                                                                                                          
# Inizializzazioni Variabili



# Sezione di Input Dati


# Elaborazione

Stocks = InserisciDatiAzione()
NumeroAzioniCalo = ContatoreCaloSignificativo(Stocks)

# Eventuali Sotto Processi di Elaborazione



# Sezione di Output

print(f"\nNumero di azioni con un calo superiore al 10% in una sola giornata: {NumeroAzioniCalo}")