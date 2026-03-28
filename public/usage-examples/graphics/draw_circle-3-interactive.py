# Move a circle using arrow keys

from splashkit import *

open_window("Interactive Circle", 800, 600)

x = 400
y = 300

while not window_close_requested("Interactive Circle"):
    process_events()
    clear_screen(Color.WHITE)

    if key_down(KeyCode.LEFT_KEY):
        x -= 5
    if key_down(KeyCode.RIGHT_KEY):
        x += 5
    if key_down(KeyCode.UP_KEY):
        y -= 5
    if key_down(KeyCode.DOWN_KEY):
        y += 5

    draw_circle(Color.BLUE, x, y, 50)

    refresh_screen(60)