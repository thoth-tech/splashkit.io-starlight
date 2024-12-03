from splashkit import *

open_window("Point Point Angle", 800, 600)
clear_screen(color_white())

# Create a red circle at the origin point
fill_circle(color_red(), 400, 300, 2)

# Origin point
origin_point = point_at(400, 300)
refresh_screen()

while not quit_requested():
    # Get mouse position
    mouse = mouse_position()

    # Calculate angle between origin and mouse
    angle = point_point_angle(origin_point, mouse)

    # Print angle
    write_line(str(angle))
    delay(100)

close_all_windows()




