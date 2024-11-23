from splashkit import * 

# Create and initialise new window with title and dimensions
wnd = open_window("Distance From Center", 600, 600)
clear_screen_to_white()

# Create circle at the center of window 
fill_circle_on_window(wnd, color_red(), 300, 300, 6)
refresh_screen()

# While window is open 
while not quit_requested():
    process_events() 

    # Point of center 
    center = screen_center()

    # Point of cursor position 
    mouse = mouse_position()

    # Print distance to terminal 
    write_line_double(point_point_distance(center, mouse))
    
# Close all opened windows
close_all_windows()