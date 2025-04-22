import pygame
import sys

# Initialize Pygame
pygame.init()
screen = pygame.display.set_mode((800, 600))
pygame.display.set_caption("Dart-Shaped Quad")

# Colors
WHITE = (255, 255, 255)
BLUE = (0, 0, 255)
SKY_BLUE = (135, 206, 235)

# Dart-shaped quad (concave)
dart = [
    (400, 100),  # Top
    (500, 300),  # Right
    (400, 500),  # Bottom (reflex)
    (300, 300)   # Left
]

# Fill background
screen.fill(WHITE)

# Draw filled dart using two triangles
pygame.draw.polygon(screen, SKY_BLUE, [dart[0], dart[1], dart[2]])
pygame.draw.polygon(screen, SKY_BLUE, [dart[2], dart[3], dart[0]])

# Outline
pygame.draw.lines(screen, BLUE, True, dart, 2)

# Save the output as bitmap
pygame.image.save(screen, "draw_quad_on_bitmap.png")

pygame.display.flip()
pygame.time.wait(3000)
pygame.quit()
sys.exit()
