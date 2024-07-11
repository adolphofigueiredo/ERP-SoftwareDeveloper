phrase = str(input('Enter a phrase: ')).strip().upper()
words = phrase.split()
together = ''.join(words)
reversed_phrase = together[::-1]  # Using slicing to reverse the string
print('The reverse of {} is {}.'.format(together, reversed_phrase))
if reversed_phrase == together:
    print('We have a palindrome.')
else:
    print('It is not a palindrome.')
