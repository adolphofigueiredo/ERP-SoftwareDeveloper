phrase = str(input('Enter the phrase: ')).lower().strip()  # Prompting user to enter a phrase, converting it to lowercase and stripping any extra whitespace
count_a = phrase.count('a')  # Counting occurrences of 'a' in the phrase
first_occurrence = phrase.find('a') + 1  # Finding the position of the first occurrence of 'a' (adding 1 for human-friendly index)
last_occurrence = phrase.rfind('a') + 1  # Finding the position of the last occurrence of 'a' (adding 1 for human-friendly index)

print('The letter "A" appears {} times.\nThe first occurrence is at position {}.\nThe last occurrence is at position {}.'.format(count_a, first_occurrence, last_occurrence))
