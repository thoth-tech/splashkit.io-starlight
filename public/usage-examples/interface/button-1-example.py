from splashkit import *

open_window("Background Color Toggle Button", 600, 400)

# Define the background color and button rectangle
bg_color = color_white()
btn_rect = rectangle_from(200, 180, 200, 40)

# Continue running until the user closes the window
while (not quit_requested()):
    process_events()

    # If the button is clicked, toggle the background color
    if button_at_position("Click Me!", btn_rect):
        if bg_color == color_white():
            bg_color = color_light_blue()
        else:
            bg_color = color_white()
            
    # Clear screen and draw interface
    clear_screen(bg_color)
    button_at_position("Click Me!", btn_rect)
    draw_interface()
    refresh_screen()

close_all_windows()