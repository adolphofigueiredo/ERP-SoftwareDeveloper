'''
Author: Adolpho Silverio Figueiredo Neto
Date: 28/05/2024

Second Exercise
A grocery store has a database (table) where products available in stock are stored.
For each product in stock, the following data is available:
● description,
● quantity available in stock,
● expiration date.
The program should store in another table all products that need to be deleted from the database because
they have expired (a product is expired when the expiration year is before 2024).

'''
from dataclasses import dataclass

# Data Structure Definitions

@dataclass
class Date:
    day: int
    month: int
    year: int

@dataclass
class Product:
    Description: str
    Quantity: int
    Unit: str
    Expiry: Date

# Initialize Variables

Warehouse = list()
ExpiredProducts = list()

# Input Section

Warehouse.append(Product("Filetto di Manzo", 15, "kg", Date(20, 6, 2029)))
Warehouse.append(Product("Salmone Fresco", 10, "kg", Date(5, 6, 2027)))
Warehouse.append(Product("Formaggio Parmigiano", 8, "kg", Date(15, 9, 2028)))
Warehouse.append(Product("Patata Inglese", 50, "kg", Date(10, 7, 2021)))
Warehouse.append(Product("Olio", 30, "liters", Date(1, 1, 2023)))
Warehouse.append(Product("Lattuga Riccia", 25, "units", Date(3, 6, 2022)))
Warehouse.append(Product("Pomodoro Italiano", 40, "kg", Date(7, 6, 2022)))
Warehouse.append(Product("Riso Arborio", 20, "kg", Date(30, 12, 2024)))
Warehouse.append(Product("Vino Bianco Secco", 60, "bottles", Date(1, 12, 2026)))
Warehouse.append(Product("Gamberi Medi", 25, "kg", Date(15, 6, 2022)))
Warehouse.append(Product("Farina di Grano", 100, "kg", Date(1, 11, 2023)))
Warehouse.append(Product("Zucchero di Canna", 15, "kg", Date(20, 8, 2023)))
Warehouse.append(Product("Fagioli Neri", 30, "kg", Date(25, 10, 2022)))
Warehouse.append(Product("Pepe Nero", 5, "kg", Date(2, 4, 2025)))
Warehouse.append(Product("Salsa di Soia", 40, "liters", Date(15, 3, 2025)))
Warehouse.append(Product("Burro Senza Sale", 20, "kg", Date(1, 7, 2024)))
Warehouse.append(Product("Pollo Disossato", 50, "kg", Date(15, 7, 2024)))
Warehouse.append(Product("Carota", 30, "kg", Date(12, 6, 2025)))
Warehouse.append(Product("Miele Biologico", 25, "kg", Date(1, 1, 2023)))
Warehouse.append(Product("Latte Intero", 100, "liters", Date(5, 6, 2024)))
Warehouse.append(Product("Farina di Mais", 40, "kg", Date(20, 9, 2022)))
Warehouse.append(Product("Panna Fresca", 30, "liters", Date(15, 7, 2025)))
Warehouse.append(Product("Pasta Penne", 60, "kg", Date(30, 12, 2024)))
Warehouse.append(Product("Aglio", 10, "kg", Date(1, 8, 2022)))
Warehouse.append(Product("Broccoli", 20, "kg", Date(8, 6, 2022)))

# Processing

for Product in Warehouse:
    if Product.Expiry.year < 2024:
        ExpiredProducts.append(Product)

# Output Section

print("-----------------------------------------------------------")
print("---------------------- Products ---------------------------")
print("-----------------------------------------------------------")

for Product in Warehouse:
    print(f"{Product.Description:20}", end="\t")
    print(f"{Product.Quantity:5}", end="\t")
    print(f"{Product.Unit:8}", end="\t")
    print(f"{Product.Expiry.day}", "/", f"{Product.Expiry.month}", "/", f"{Product.Expiry.year}", sep="")

print("-----------------------------------------------------------")
print("------------------- Expired Products ----------------------")
print("-----------------------------------------------------------")

for Product in ExpiredProducts:
    print(f"{Product.Description:20}", end="\t")
    print(f"{Product.Quantity:5}", end="\t")
    print(f"{Product.Unit:8}", end="\t")
    print(f"{Product.Expiry.day:>}","/", f"{Product.Expiry.month:>}","/", f"{Product.Expiry.year:>", sep="")

print("-----------------------------------------------------------")
print("-----------------------------------------------------------")
