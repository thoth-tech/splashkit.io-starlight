# Usage Example: draw_circle
# Shows the absolute minimum to demonstrate the function.
# Expected: opens a window and draws a blue circle, then exits.
# Docs: https://splashkit.io/api/graphics/draw_circle

from splashkit import *

open_window("Blue Circle", 200, 200)
draw_circle(COLOR_BLUE, 100, 100, 50)
refresh_screen(60)
delay(1500)
