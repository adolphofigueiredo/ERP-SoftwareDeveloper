def MCD(x, y):
    while y != 0:
        x, y = y, x % y
        print(f"x = {x}\ny = {y}\n")
    return x

    '''
        È lo stesso che scrivere:
        while y != 0:
            temp = x
            x = y
            y = temp % y

            Abaixo foi feito o uso de uma tupla e assim  foi feita a troca de valores em x e y usando um temporario
            
            x=1
            y=2
            print(x,y)
            temp=x
            x=y
            y= temp
            print(x,y)

            x=1
            y=2

            print(x,y)

            x , y = y,x
            print(x,y)

    '''

MCD(x = 9,y = 24)