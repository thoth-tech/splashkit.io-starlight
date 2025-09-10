from splashkit import *

open_window("Closest Point On Line", 800, 600)

# Create line for which our point will be attached to
diagonal_line = line_from(200, 150, 600, 450)

while not window_close_requested(current_window()):
    
    process_events()
    clear_screen(color_white())
    draw_line_record(color_black(), diagonal_line)
    
    # Use our mouse position for calculating the closest point on line
    mouse_pos = point_at(mouse_x(), mouse_y())    
    closest = closest_point_on_line(mouse_pos, diagonal_line)

    # Visualize the mouse position and the closest point on the line
    fill_circle(color_red(), mouse_pos.x, mouse_pos.y, 5)
    fill_circle(color_green(), closest.x, closest.y, 5)

    refresh_screen()
