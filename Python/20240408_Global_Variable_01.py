var = 10

def fun():
    global var
    print("2 var = ", var)
    var = var + 1
    print("3 var = ", var)

print("1 var = ", var)

fun()

print("4 var = ", var)
