from splashkit import *

# Variable Declaration
click = "Mouse clicked at "
mouse_pos = ""

# Open Window
open_window("point to string", 600, 600)
clear_screen(color_ghost_white())

while not quit_requested():

    # check for mouse click
    if mouse_clicked(MouseButton.left_button):
    
        mouse_pos = point_to_string(mouse_position())
        clear_screen(color_ghost_white())
    

    # Print mouse position to screen
    draw_text_no_font_no_size(click + mouse_pos,color_black(),100,300)
    process_events()
    refresh_screen()

close_all_windows()

