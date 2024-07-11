import random
import time

print('-=-' * 20)
print('{:^60}'.format('I am thinking...'))
print('-=-' * 20)
time.sleep(5)
print('I thought! Want to try to guess?')

random_number = random.randint(0, 5)
user_number = int(input('Choose a number from 0 to 5: '))

if user_number == random_number:
    print('Congratulations! You guessed the chosen number!')
else:
    print('Hahaha! You missed! Try again...\nThe chosen number was {}.'.format(random_number))
