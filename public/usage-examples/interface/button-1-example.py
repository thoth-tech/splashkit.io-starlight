from splashkit import *

# Open the window
open_window("Button Toggle", 600, 400)

bg_color = color_white()
btn_rect = rectangle_from(200, 180, 200, 40)

# Main loop
while not quit_requested():
    process_events()

    # Toggle background color if button_at_position is clicked
    if button_at_position("Click Me!", btn_rect):
        bg_color = color_light_blue() if bg_color == color_white() else color_white()

    clear_screen(bg_color)
    button_at_position("Click Me!", btn_rect)
    draw_interface()
    refresh_screen()

close_all_windows()
