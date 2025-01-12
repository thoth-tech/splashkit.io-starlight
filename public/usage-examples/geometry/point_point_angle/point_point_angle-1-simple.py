from splashkit import *

open_window("Point Point Angle", 800, 600)
clear_screen(color_white())

# Draw the circle at the origin point
fill_circle(color_red(), 400, 300, 2)

# Define the origin point
origin_point = point_at(400, 300)

refresh_screen()

while not quit_requested():
    # Get the current mouse position
    mouse = mouse_position()

    # Calculate the angle between the origin point and the mouse position
    angle = point_point_angle(origin_point, mouse)

    # Print angle
    write_line(str(angle))
    
    delay(100)

close_all_windows()




