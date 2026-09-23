# Usage Example for: https://splashkit.io/api/graphics/#draw-triangle-3
# Goal: I am drawing a spinning equilateral triangle and I am toggling between outline and fill with SPACE.
# Why: I am showing how draw_triangle and fill_triangle render the same geometry differently.
# Controls: I am pressing SPACE to toggle fill  •  I am pressing ESC to quit.

import math
from splashkit import *
from splashkit import KeyCode  # my binding is using lower-case enums

# I am mapping the keys I am using.
SPACE = KeyCode.space_key
ESC   = KeyCode.escape_key

# I am opening the window (title stays short as per review).
WIDTH, HEIGHT = 720, 405
win = open_window("Spinning Triangle", WIDTH, HEIGHT)

# I am storing the triangle state.
is_filled = False      # I am remembering whether I am filling or outlining.
angle     = 0.0        # I am advancing the rotation angle each frame.

# I am placing the triangle at the window centre and I am setting its size.
center_x = WIDTH * 0.5
center_y = HEIGHT * 0.5
radius   = 110.0       # I am setting the radius from centre to a vertex.

# I am defining the colours I am using.
WHITE = rgb_color(255, 255, 255)
NAVY  = rgb_color(0,   0, 128)
SKY   = rgb_color(135, 206, 235)
BLACK = rgb_color(0,   0,   0)

# I am running the main loop until I am asking to quit.
while not quit_requested():
    process_events()

    # I am quitting when ESC is pressed.
    if key_typed(ESC):
        break

    # I am toggling between outline and fill when SPACE is pressed.
    if key_typed(SPACE):
        is_filled = not is_filled

    clear_screen(WHITE)

    # I am computing the three triangle points at 120° steps.
    a0 = angle
    a1 = angle + 2.0 * math.pi / 3.0
    a2 = angle + 4.0 * math.pi / 3.0

    x1, y1 = center_x + radius * math.cos(a0), center_y + radius * math.sin(a0)
    x2, y2 = center_x + radius * math.cos(a1), center_y + radius * math.sin(a1)
    x3, y3 = center_x + radius * math.cos(a2), center_y + radius * math.sin(a2)

    # I am drawing the triangle as filled or outlined.
    if is_filled:
        fill_triangle(SKY,  x1, y1, x2, y2, x3, y3)
    else:
        draw_triangle(NAVY, x1, y1, x2, y2, x3, y3)

    refresh_screen()
    delay(16)       # I am pacing to ~60 FPS.
    angle += 0.02   # I am rotating at a comfortable speed.