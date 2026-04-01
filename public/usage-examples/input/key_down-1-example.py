from splashkit import *

def draw_key_status(label, key, x, y):
    pressed = key_down(key)
    indicator = color_green() if pressed else color_gray()
    state = "Pressed" if pressed else "Released"

    fill_circle(indicator, x, y, 25)
    draw_text(label + ": " + state, color_black(), None, 16, x + 40, y - 10)

window = open_window("Keyboard State Display", 800, 400)

while not window_close_requested(window):
    process_events()

    clear_screen(color_white())

    draw_text(
        "Press the arrow keys or space bar to see their current state.",
        color_black(),
        None,
        18,
        120,
        40
    )

    draw_key_status("Left", KeyCode.left_key, 120, 130)
    draw_key_status("Right", KeyCode.right_key, 120, 190)
    draw_key_status("Up", KeyCode.up_key, 120, 250)
    draw_key_status("Down", KeyCode.down_key, 120, 310)
    draw_key_status("Space", KeyCode.space_key, 500, 220)

    refresh_screen_with_target_fps(60)

close_window(window)
