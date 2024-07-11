from math import sin, cos, radians

angle = float(input('Enter the angle: '))
sine = sin(radians(angle))
cosine = cos(radians(angle))

print('For the angle of {}° we have a sine of {} and a cosine of {}.'.format(angle, sine, cosine))
