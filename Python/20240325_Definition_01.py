a   =   23
b   =   -40

def my_abs(num):
    if num < 0 :
        num =- num
    return num

if my_abs(a) >= my_abs(b) :
    print (my_abs(a))
else:
    print (my_abs(b))
