n1 = int(input('Digite um valor: '))
n2 = int(input('Digite outro valor: '))
s = n1 + n2
sb = n1 - n2
m = n1 * n2
d = n1 / n2
di = n1 // n2
e = n1 ** n2
print('A soma vale {}.'.format(n1+n2), end=' >>> ')
print('A soma vale {}.'.format(s), end=' >>> ')
print('A subtração vale {}.'.format(sb))
print('A multiplicação vale {}.'.format(m), end=' ')
print('A divisão vale {:.4f}.'.format(d), end=' ')
print('A divisão inteira vale {}.'.format(di))
print('A potência vale {}.'.format(e))

print('A soma vale\n{}.'.format(n1+n2))
print('A soma vale\n{}.'.format(s))
print('A subtração vale\n{}.'.format(sb))
print('A multiplicação vale\n{}.'.format(m))
print('A divisão vale\n{:.4f}.'.format(d))
print('A divisão inteira vale\n{}.'.format(di))
print('A potência vale\n{}.'.format(e))
