'''
Author: Adolpho Silverio Figueiredo Neto
Date: 03/06/2024

First Exercise

A table contains the performance of stock quotes for some stocks over the past week.
The structure is defined as follows: name, values - a sequence of 7 floats (one for each day
of the week). The program should display on the screen how many stocks had a drop
greater than 10% in a single day.

Example:

Stellantis 100 98 97 96 110 109 105
ACME 100 95 100 88 81 105 107

The program should provide a result of 1, as ACME had a drop greater than 10%
between the third and fourth days.

'''

from dataclasses import dataclass

@dataclass
class Stock:
    Ticker: str
    Prices: list
    
# Data Structure Definitions

# Functions:

# Function:
def InsertStockData() -> list:
    '''
    Function: InsertStockData
    
    Formal Parameters:
    
    Return Value:
    
    '''

    Stocks = []

    NumStocks = int(input("How many stocks do you want to enter? "))

    for x in range(NumStocks):
        
        NumPrices = -1
        Ticker = input("\nEnter the stock ticker: ")
        Prices = []

        while NumPrices <= 0 or NumPrices > 7:
            NumPrices = int(input("How many prices do you want to enter (Max = 7)? "))
        
        for y in range(NumPrices):
        
            Price = float(input(f"Enter value {y + 1}: "))
            Prices.append(Price)
        
        Stocks.append(Stock(Ticker=Ticker, Prices=Prices))

    return Stocks

# Function:
def SignificantDrop(PreviousPrice, CurrentPrice) -> float:
    '''
    Function: SignificantDrop
    
    Formal Parameters:
    
    Return Value:
    
    '''

    Delta = (PreviousPrice - CurrentPrice) / PreviousPrice * 100

    return Delta

# Function:
def CountSignificantDrops(Stocks) -> int:
    '''
    Function: CountSignificantDrops
    
    Formal Parameters:
    
    Return Value:
    
    '''

    Count = 0

    for Stock in Stocks:
        Prices = Stock.Prices
        for i in range(1, len(Prices)):
            Drop = SignificantDrop(Prices[i - 1], Prices[i])
            if Drop > 10:
                Count += 1
                break

    return Count

# Variable Initializations



# Input Section



# Processing

Stocks = InsertStockData()
NumStocksDrop = CountSignificantDrops(Stocks)

# Output Section

print(f"\nNumber of stocks with a drop greater than 10% in a single day: {NumStocksDrop}")
