# Usage Example for: https://splashkit.io/api/resources/#free-bitmap
# Goal: I am creating, animating, and freeing a bitmap with a new color each load.
# Why: I am showing how to manage bitmap lifetime and avoid leaks.
# Controls: I am pressing L to load (random color) | I am pressing F to free | I am pressing ESC to quit.

import math
import random
from splashkit import *
from splashkit import KeyCode

# I am opening the window with explicit size and I am putting the instructions in the title.
open_window("Free Bitmap - L: load  F: free  ESC: quit", 720, 405)

# I am storing the demo bitmap and state.
demo = None          # I am holding the bitmap when loaded.
loaded = False       # I am tracking whether the bitmap is loaded.
load_count = 0       # I am counting how many times I load.
t = 0.0              # I am driving a gentle vertical bob.

# I am mapping the keys I am using.
ESC   = KeyCode.escape_key
KEY_L = KeyCode.l_key
KEY_F = KeyCode.f_key

# I am defining the colours I am using.
WHITE = rgb_color(255, 255, 255)
BLACK = rgb_color(0,   0,   0)
GREY  = rgb_color(128, 128, 128)

# I am choosing a random colour for each load (using Python's RNG).
def random_rgb():
    return rgb_color(random.randint(0, 255),
                     random.randint(0, 255),
                     random.randint(0, 255))

# I am (re)creating a simple coloured bitmap.
def make_demo():
    global demo, loaded, load_count
    demo = create_bitmap("demo_bmp", 96, 96)
    c = random_rgb()
    fill_rectangle_on_bitmap(demo, c, 0, 0, 96, 96)
    draw_rectangle_on_bitmap(demo, BLACK, 0, 0, 96, 96)
    loaded = True
    load_count = load_count + 1

# I am freeing the bitmap if it is present.
def free_demo():
    global demo, loaded
    if loaded and demo is not None:
        free_bitmap(demo)
        demo = None
        loaded = False

# I am running the main loop.
while not quit_requested():
    process_events()

    # I am quitting when ESC is pressed.
    if key_typed(ESC):
        break

    # I am loading (creating or re-creating) on L.
    if key_typed(KEY_L):
        free_demo()
        make_demo()

    # I am freeing on F.
    if key_typed(KEY_F):
        free_demo()

    clear_screen(WHITE)

    if loaded and demo is not None:
        # I am animating with a gentle vertical bob.
        t = t + 0.06
        cx = 720 // 2 - 48
        cy = 405 // 2 - 48 + int(8.0 * math.sin(t))
        draw_bitmap(demo, cx, cy)
    else:
        # I am showing a placeholder box when freed.
        draw_rectangle(GREY, 720 // 2 - 48, 405 // 2 - 48, 96, 96)

    # I am pacing to ~60 FPS (this binding does not take an FPS argument).
    refresh_screen()
    delay(16)

# I am cleaning up before exit.
free_demo()