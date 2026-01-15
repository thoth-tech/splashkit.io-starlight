from splashkit import *

# Open new windows
white_window = open_window("Ellipse Painter on White", 500, 500)
blue_window = open_window("Ellipse Painter on Blue", 500, 500)

# Set windows' postions
move_window_to(white_window, 100, 100)
move_window_to(blue_window, 620, 100)

# Clear windows to white and blue
clear_window(white_window, color_white())
clear_window(blue_window, color_aqua())

# While user doesn't request to quit windows
while not window_close_requested(white_window) and not window_close_requested(blue_window):
    process_events()
    draw_text_on_window_no_font_no_size(white_window, "Press L to paint. Press on the C key to clear screen", color_black(), 5, 10)
    draw_text_on_window_no_font_no_size(blue_window, "Press P to paint. Press on the D key to clear screen", color_black(), 5, 10)
    
    # Get random points on the windows
    white_pos = random_window_point(white_window)
    blue_pos = random_window_point(blue_window)
    
    # If L key is pressed draw ellipse on white_window in random point
    if key_typed(KeyCode.l_key):
        fill_ellipse_on_window(white_window, random_color(), white_pos.x, white_pos.y, 100, 50)
        
    # If P key is pressed draw ellipse on blue_window in random point
    if key_typed(KeyCode.p_key):
        fill_ellipse_on_window(blue_window, random_color(), blue_pos.x, blue_pos.y, 100, 50)
    
    # Clear white_window if C key is pressed 
    if key_typed(KeyCode.c_key):
        clear_window(white_window, color_white())
        
    # Clear blue_window if D key is pressed 
    if key_typed(KeyCode.d_key):
       clear_window(blue_window, color_aqua())
    
    refresh_window_with_target_fps(white_window, 60)
    refresh_window_with_target_fps(blue_window, 60)

# Close all windows
close_all_windows()

