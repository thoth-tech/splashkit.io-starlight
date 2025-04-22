import pygame
from dataclasses import dataclass

@dataclass
class Circle:
    x: int
    y: int
    radius: int
    color: tuple

    def draw(self, surface):
        pygame.draw.circle(surface, self.color, (self.x, self.y), self.radius)

def main():
    pygame.init()
    screen = pygame.display.set_mode((800, 600))
    pygame.display.set_caption("Draw Circles")

    screen.fill((255, 255, 255))
    center = (400, 300)

    circles = [
        Circle(*center, 50, (255, 0, 0)),
        Circle(*center, 100, (0, 0, 255)),
        Circle(*center, 150, (255, 165, 0)),
        Circle(*center, 200, (0, 255, 0))
    ]

    for circle in circles:
        circle.draw(screen)

    pygame.display.flip()
    pygame.time.delay(4000)
    pygame.quit()

if __name__ == "__main__":
    main()
