a = input('Digite o valor que deve ser pesquisado = ')
print('O tipo primitivo deste valor é',type(a))
print('O valor {} só tem espaços? '.format(a),a.isspace())
print('O valor {} é número? '.format(a),a.isnumeric())
print('O valor {} é letra? '.format(a),a.isalpha())
print('O valor {} é alfanumérico? '.format(a),a.isalnum())
print('O valor {} é maiúsculo? '.format(a),a.isupper())
print('O valor {} é minúsculo? '.format(a),a.islower())
print('O valor {} é capitalizado? '.format(a),a.istitle())