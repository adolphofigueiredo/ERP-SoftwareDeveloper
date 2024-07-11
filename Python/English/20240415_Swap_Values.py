def GCD(x, y):
    while y != 0:
        x, y = y, x % y
        print(f"x = {x}\ny = {y}\n")
    return x

    '''
        This is equivalent to writing:
        while y != 0:
            temp = x
            x = y
            y = temp % y

            Below is an example of using a tuple to swap values in x and y without a temporary variable
            
            x = 1
            y = 2
            print(x, y)
            temp = x
            x = y
            y = temp
            print(x, y)

            x = 1
            y = 2

            print(x, y)

            x, y = y, x
            print(x, y)
    '''

GCD(x = 9, y = 24)
