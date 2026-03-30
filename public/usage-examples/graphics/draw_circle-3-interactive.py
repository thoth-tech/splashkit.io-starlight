from splashkit import *

window = open_window("Interactive Circle", 800, 600)

x = 400
y = 300

while not window_close_requested(window):
    process_events()
    clear_screen_to_white()

    if key_down(left_key()):
        x -= 5
    if key_down(right_key()):
        x += 5
    if key_down(up_key()):
        y -= 5
    if key_down(down_key()):
        y += 5

    draw_circle(color_blue(), x, y, 50)

    refresh_screen_with_target_fps(60)