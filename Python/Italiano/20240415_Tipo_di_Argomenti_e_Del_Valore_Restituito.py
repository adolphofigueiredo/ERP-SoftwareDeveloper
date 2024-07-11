def area (base: float, alt: float ) -> float:
    return base*alt

print("Area 1 = ", area(3.2,4.5))
print("Area 2 = ", area(5,4))
print("Area 3 = ", area("A",3))        #Esta impressao na termina em erro pois a letra a foi impressa tres vezes, este é o resultado de uma string sendo multiplicada.
#print("Area 4 = ", area("A","B"))     #Aqui termina em erro pois nao é possivel multiplicar uma string por uma string. 
