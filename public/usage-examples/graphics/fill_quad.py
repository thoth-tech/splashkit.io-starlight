import pygame

pygame.init()
screen = pygame.display.set_mode((600, 600))
pygame.display.set_caption("Coloured Star")

screen.fill((255, 255, 255))  # White background

quads = [
    ([ (400,200), (300,300), (300,0), (200,200) ], (0, 0, 0)),
    ([ (400,210), (310,300), (600,300), (400,390) ], (0, 255, 0)),
    ([ (200,400), (300,300), (300,600), (400,400) ], (255, 0, 0)),
    ([ (200,390), (290,300), (0,300), (200,210) ], (0, 0, 255)),
]

for points, color in quads:
    pygame.draw.polygon(screen, color, points)

pygame.display.flip()
pygame.time.delay(5000)
pygame.quit()
