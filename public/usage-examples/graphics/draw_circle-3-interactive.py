from splashkit import *

window = open_window("Interactive Circle", 800, 600)

x = 400
y = 300

while not quit_requested():
    process_events()
    clear_screen_to_white()

    if key_down(KeyCode.left_key):
        x -= 5
    if key_down(KeyCode.right_key):
        x += 5
    if key_down(KeyCode.up_key):
        y -= 5
    if key_down(KeyCode.down_key):
        y += 5

    draw_circle(color_blue(), x, y, 50)

    refresh_screen_with_target_fps(60)