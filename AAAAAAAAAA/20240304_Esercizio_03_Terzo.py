'''

Autore: Adolpho Silverio Figueiredo Neto
Data: 04/03/2024

Terzo Esercizio
Si hanno in input N saldi di conti correnti bancari. Si vuole in output la media armonica dei
soli conti correnti che hanno un saldo negativo.
Media armonica H di n elementi x1
, x2
, …, xn si calcola con la seguente formula:
esempio:
Input: N = 4 saldi: 1240.5 -200.0 21.0 -2.3
Output: media = 2*1/(1/(-200)+ 1/(-2,3)) = -4,548

'''

# Sezione di input Dati

scelta = "s"
soma = 0
counter = 0

# Elaborazione

while scelta == "s" or scelta == "S":
    saldo = int(input("\nInserisci il saldo del conto corrente bancario (€): "))
    if saldo < 0:
        counter += 1
        soma = soma + ( 1 / saldo )
        scelta = input("\nVuoi aggiungere un altro saldo del conto corrente bancario?\n\n(s) - Si\n(n) - No\n\n")
    else:
        scelta = input("\nVuoi aggiungere un altro saldo del conto corrente bancario?\n\n(s) - Si\n(n) - No\n\n")

media = counter / soma

# Sezione di output

print("La media armonica è {}.".format(media))