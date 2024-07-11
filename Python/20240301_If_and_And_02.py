print('-=-' * 10)
print('{:^30}'.format('Triangle Analyzer'))
print('-=-' * 10)
side1 = float(input('First segment: '))
side2 = float(input('Second segment: '))
side3 = float(input('Third segment: '))
if side1 < side2 + side3 and side2 < side1 + side3 and side3 < side1 + side2:
    print('The segments above can form a triangle.')
    if side1 == side2 == side3:
        print('With all sides equal, this triangle is classified as equilateral.')
    elif side1 == side2 or side1 == side3 or side2 == side3:
        print('With two equal sides, this triangle is classified as isosceles.')
    elif side1 != side2 != side3 != side1:
        print('With all sides different, this triangle is classified as scalene.')
else:
    print('The segments above cannot form a triangle.')
