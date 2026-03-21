from splashkit import *

def draw_key_status(label, key, x, y):
    # Check whether the selected key is currently pressed
    pressed = key_down(key)
    indicator = COLOR_GREEN if pressed else COLOR_GRAY
    state = "Pressed" if pressed else "Released"

    # Draw the key status indicator and label
    fill_circle(indicator, x, y, 25)
    draw_text(label + ": " + state, COLOR_BLACK, x + 40, y - 10)

# Open the window for the usage example
window = open_window("Keyboard State Display", 800, 400)

while not window_close_requested(window):
    process_events()

    # Draw the background and instructions
    clear_screen(COLOR_WHITE)
    draw_text("Press the arrow keys or space bar to see their current state.", COLOR_BLACK, 120, 40)

    # Draw the live status of each selected key
    draw_key_status("Left", KeyCode.left_key, 120, 130)
    draw_key_status("Right", KeyCode.right_key, 120, 190)
    draw_key_status("Up", KeyCode.up_key, 120, 250)
    draw_key_status("Down", KeyCode.down_key, 120, 310)
    draw_key_status("Space", KeyCode.space_key, 500, 220)

    refresh_screen(60)

close_window(window)