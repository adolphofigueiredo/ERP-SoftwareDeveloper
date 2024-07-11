'''
Author: Adolpho Silverio Figueiredo Neto
Date: 03/06/2024

First Exercise

A table contains the stock prices of some stocks over the last week. 
The structure is defined as follows: name, values: a sequence of 7 floats (one for each day 
of the week). The program should display on the screen how many stocks had a drop 
greater than 10% in a single day.

Example:

Stellantis 100 98 97 96 110 109 105
ACME 100 95 100 88 81 105 107

The program should output 1, as ACME had a drop of more than 10% between the third and fourth day.
'''

from dataclasses import dataclass

@dataclass
class Stock:
    Ticker: str
    Prices: list
    

# Data Structures Definition

# Functions:

# Function:
def InsertStockData() -> list:
    '''
Function: InsertStockData

Formal parameters:

Return value:
    '''

# Formal parameters:

    Stocks = []

    NumberStocks = int(input("How many stocks do you want to enter? "))

    for x in range(NumberStocks):
        
        NumberPrices = -1
        Ticker = input("\nEnter the stock ticker: ")
        Prices = []

        while NumberPrices <= 0 or NumberPrices > 7:
            NumberPrices =  int(input("How many prices do you want to enter (Max = 7)? "))
        
        for y in range(NumberPrices):
        
            Price = float(input(f"Enter value { y + 1 }: "))
            Prices.append(Price)
        
        Stocks.append(Stock(Ticker=Ticker, Prices=Prices))

# Return value:

    return Stocks

# Function:
def SignificantDrop(PreviousPrice , CurrentPrice) -> float:
    '''
Function: SignificantDrop

Formal parameters:

Return value:
    '''

# Formal parameters:

    Delta = (PreviousPrice - CurrentPrice) / PreviousPrice * 100

# Return value:

    return Delta


# Function:
def SignificantDropCounter(Stocks) -> int:
    '''
Function: SignificantDropCounter

Formal parameters:

Return value:

'''

# Formal parameters:

    Counter = 0

    for Stock in Stocks:
        Prices = Stock.Prices
        for i in range(1 , len(Prices)):
            Drop = SignificantDrop(Prices[i-1], Prices[i])
            if Drop > 10:
                Counter += 1
                break

# Return value:

    return Counter


                                                                                                          
# Variable Initializations



# Input Data Section


# Processing

Stocks = InsertStockData()
NumberStocksWithDrop = SignificantDropCounter(Stocks)

# Possible Sub-Processing


# Output Section

print(f"\nNumber of stocks with a drop greater than 10% in a single day: {NumberStocksWithDrop}")
