from splashkit import *

# Open a 300x300 window
window = open_window("Vector Offset Lines", 300, 300)
# Use the center of the window as the start point for lines
start = point_at(150, 150)
# Create vectors for up and right
vec_up = Vector2D()
vec_up.y = -100
vec_right = Vector2D()
vec_right.x = 100

while not window_close_requested(window):
    process_events()
    clear_screen_to_white()
    # Draw a red line with the up vector as offset
    draw_line_record(color_red(), line_from_start_with_offset(start, vec_up))
    # Draw a blue line with the right vector as offset
    draw_line_record(color_blue(), line_from_start_with_offset(start, vec_right))
    refresh_screen()
    
close_all_windows()