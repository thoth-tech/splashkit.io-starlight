from splashkit import *

# Variable Declaration
click_message = "Mouse clicked at "
mouse_position_text = ""

# Open Window
open_window("Mouse Clicked Location", 600, 600)
clear_screen(color_ghost_white())

while not quit_requested():

    # check for mouse click
    if mouse_clicked(MouseButton.left_button):
        mouse_position_text = point_to_string(mouse_position())
        clear_screen(color_ghost_white())
    
    # Print mouse position to screen
    draw_text_no_font_no_size(click_message + mouse_position_text, color_black(), 100, 300)
    process_events()
    refresh_screen()

close_all_windows()