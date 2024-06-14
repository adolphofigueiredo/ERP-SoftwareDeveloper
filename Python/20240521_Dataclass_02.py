from dataclasses import dataclass

@dataclass
class Date:
    dd: int
    mm: int
    yy: int

def func(dt1: Date, dd: int) -> Date:
    print(2, dt1.dd)
    dt1.dd = dd
    dt1.yy = 1982
    print(3, dt1.dd)
    print(4, dt1)
    dt1.dd = 25
    print(5, dt1)
    returnValue = Date(1, 2, 2000)

    return returnValue

dt1 = Date(1, 2, 2050)

print(1, dt1)

date = func(dt1, 14)

print(6, date.dd)

print(7, date)
