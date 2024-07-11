numeroint = int(input('Enter the number: '))

d1 = numeroint // 1000 % 10
d2 = numeroint // 100  % 10
d3 = numeroint // 10   % 10
d4 = numeroint // 1    % 10

print('Thousands place:  {}\n'
      'Hundreds place:   {}\n'
      'Tens place:       {}\n'
      'Units place:      {}'.format(d1, d2, d3, d4))
