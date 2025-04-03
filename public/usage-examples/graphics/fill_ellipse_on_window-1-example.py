from splashkit import *

# Open a new window
window = open_window("Ellipse Painter", 800, 600)
clear_screen_to_white()

# While user doesn't request to quit window
while not window_close_requested(window):
    process_events()
    draw_text_no_font_no_size("Press on the C key to clear screen", color_black(), 5, 10)
    
    # If mouse clicked or held down get mouse position
    if mouse_clicked(MouseButton.left_button) or mouse_down(MouseButton.left_button):

        pos = mouse_position()

        # Fill ellipse in the position with random color
        fill_ellipse_on_window(window, random_color(), pos.x, pos.y, 100, 50)
    
    # Clear screen if C key is pressed 
    if key_typed(KeyCode.c_key):
        clear_screen_to_white()
    
    refresh_screen_with_target_fps(60)

# Close all windows
close_all_windows()

