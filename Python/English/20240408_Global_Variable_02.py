var = 10

def fun(var):
    print("2 var = ", var)
    var = var + 1
    print("3 var = ", var)
    return var

print("1 var = ", var)

var = fun(var)

print("4 var = ", var)
