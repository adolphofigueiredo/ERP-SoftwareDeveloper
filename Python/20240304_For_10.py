highest = 0
lowest = 0
for c in range(1, 6):
    weight = float(input('Weight of the {}° person: '.format(c)))
    if c == 1:
        highest = weight
        lowest = weight
    else:
        if weight > highest:
            highest = weight
        if weight < lowest:
            lowest = weight
print('The lowest weight read was {:.2f}kg.'.format(lowest))
print('The highest weight read was {:.2f}kg.'.format(highest))
