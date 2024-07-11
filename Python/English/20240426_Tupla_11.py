words = ('learn', 'program', 'language', 'python', 'course',
         'free', 'study', 'practice', 'work', 'market',
         'programmer', 'future', 'corona', 'pandemic', 'old')

for word in words:
    print(f'\nIn the word {word.upper()} we have: ', end='')
    for letter in word:
        if letter.lower() in 'aeiou':
            print(f'{letter}', end=' ')
