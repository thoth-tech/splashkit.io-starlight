from splashkit import *

# Open a window for the border‐color demo
open_window("Border Interface Color", 400, 200)

# Set all interface borders (e.g. buttons) to green
set_interface_border_color(color_red())

# Define a button area
btn_rect = rectangle_from(150, 80, 100, 40)

# Main loop: draw the button with our custom border color
while not quit_requested():
    process_events()
    clear_screen(color_white())

    # Render the button using the interface border color
    button_at_position("Click Me", btn_rect)
    draw_interface()
    refresh_screen_with_target_fps(60)

close_all_windows()
