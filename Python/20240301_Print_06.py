a = 3
b = 5
colors = {
    'reset': '\033[m',
    'blue': '\033[34m',
    'yellow': '\033[33m',
    'black_and_white': '\033[7;30m'
}

print('The values are {} and {}.'.format(a, b))
print('The values are \033[32;46m{}\033[m and \033[31;46m{}\033[m.'.format(a, b))
print('The values are {}{}{} and {}{}{}.'.format('\033[4;34m', a, '\033[m', '\033[1;32m', b, '\033[m'))
print('The values are {}{}{} and {}{}{}.'.format(colors['black_and_white'], a, colors['reset'], colors['yellow'], b, colors['reset']))
