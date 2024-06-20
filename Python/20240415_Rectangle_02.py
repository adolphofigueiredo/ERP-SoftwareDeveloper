def area(base: float, height: float) -> float:
    return base * height

print("Area 1 = ", area(3.2, 4.5))
print("Area 2 = ", area(5, 4))
print("Area 3 = ", area("A", 3))        #This print ends in an error because the letter 'A' is printed three times, which is the result of a string being multiplied.
#print("Area 4 = ", area("A", "B"))     #This ends in an error because it is not possible to multiply a string by another string.
