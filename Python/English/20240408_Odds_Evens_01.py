def isEven(test):
    if test % 2 == 0:
        result = True
    else:
        result = False
    return result

result = False

test = int(input("Enter the number: "))

result = isEven(test)

print(result)
