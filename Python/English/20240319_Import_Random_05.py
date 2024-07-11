import random
import time

print('-=-' * 20)
print('{:^60}'.format('I am thinking...'))
print('-=-' * 20)

print('I am your computer...')
time.sleep(1)
print('I thought of a number! Want to try to guess it?')

computer_number = random.randint(0, 10)
player_guess = int(input('Choose a number from 0 to 10: '))
guesses = 1

while player_guess != computer_number:
    guesses += 1
    if player_guess < computer_number:
        player_guess = int(input('Hahahahah! You missed! The number is higher, try again... '))
    elif player_guess > computer_number:
        player_guess = int(input('Hahahahah! You missed! The number is lower, try again... '))

if guesses > 3:
    print('Congratulations! It took you {} guesses, but you finally got it right!!'.format(guesses))
elif guesses <= 3:
    print('Congratulations! You only needed {} guesses to get it right!!'.format(guesses))
