'''
Before importing the pygame library, you need to install it through the command line (cmd).
It is necessary to access it and type: "pip install pygame"
'''
import pygame
pygame.init()
pygame.mixer.music.load('20240319_Import_PyGame_01.wav')
pygame.mixer.music.play()
pygame.event.wait()
