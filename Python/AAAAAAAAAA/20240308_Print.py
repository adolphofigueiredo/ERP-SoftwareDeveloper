print("Ciao", "come", "STAI")
print("Ciao", "come", "STAI", sep="\t")
print("Ciao", "come", "STAI", sep="\t", end="_____")
print("Ciao", "come", "STAI", sep=" -*- ")

campo1 = 2
campo2 = "string"
campo3 = 5.03
print(campo1,campo2,campo3)
print(campo1,campo2,campo3,sep="   ")
print(campo1,campo2,campo3,sep="   |   ")
print(campo1,campo2,campo3,sep="\t")
print(campo1,campo2,campo3,sep="\n")

valore = 10
print(f"Valore: {valore}")
print(F"Valore con 3 cifre {valore:03}")
print(f"Valore con 3 \'posizioni\' {valore:3}")

numero = 10.456
print(f"Numero con 2 cifre decimali {numero: .2f}")
print(f"Numero con 10 cifre decimali {numero: .10f}")
print(f"Numero: {numero:e}")
print(f"Numero: {numero:.3e}")