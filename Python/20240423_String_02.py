string = "String"
character = string[1]
print(character)
print(string[0])
print(len(string))
print("+", string[-1], string[-len(string)])
i = 1
print(string[i+1])
for i in range(len(string)):
    print(i, ": ", string[i])
