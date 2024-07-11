from dataclasses import dataclass

@dataclass
class Data:
    gg: int
    mm: int
    aa: int



def fun(dt1: Data, gg: int )-> Data:
    print(2,dt1.gg)
    dt1.gg = gg
    dt1.aa = 1982
    print(3,dt1.gg)
    print(4,dt1)
    dt1.gg = 25 
    print(5,dt1)
    valRitorno=Data(1,2,2000)

    return valRitorno

dt1= Data(1,2,2050)

print(1,dt1)

data = fun(dt1, 14)

print(6,data.gg)

print(7,data)
