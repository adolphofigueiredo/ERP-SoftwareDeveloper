print("Hello", "how", "ARE YOU")
print("Hello", "how", "ARE YOU", sep="\t")
print("Hello", "how", "ARE YOU", sep="\t", end="_____")
print("Hello", "how", "ARE YOU", sep=" -*- ")

field1 = 2
field2 = "string"
field3 = 5.03
print(field1, field2, field3)
print(field1, field2, field3, sep="   ")
print(field1, field2, field3, sep="   |   ")
print(field1, field2, field3, sep="\t")
print(field1, field2, field3, sep="\n")

value = 10
print(f"Value: {value}")
print(F"Value with 3 digits {value:03}")
print(f"Value with 3 'positions' {value:3}")

number = 10.456
print(f"Number with 2 decimal places {number:.2f}")
print(f"Number with 10 decimal places {number:.10f}")
print(f"Number: {number:e}")
print(f"Number: {number:.3e}")
