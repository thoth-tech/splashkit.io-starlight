from splashkit import *

# Prompt for x and y value 
write("Enter x point: ")
x = convert_to_integer(read_line())
write("Enter y point: ")
y = convert_to_integer(read_line())

wnd = open_window("Closest point", 600, 600)
clear_screen_to_white()

# Set circle point to center of screen and draw to screen
circle_pnt = Point2D()
circle_pnt.x = 300
circle_pnt.y = 300
circle = circle_at(circle_pnt, 100)
draw_circle_record(color_black(), circle)

refresh_screen()

# Initialize the input points as a 2D point
point = Point2D()
point.x = x
point.y = y

# Get closest point to the point on circle 
close_point = closest_point_on_circle(point, circle)

# Draw circle to indicate point
fill_circle_on_window(wnd, color_red(), close_point.x, close_point.y, 5)

refresh_screen()

delay(5000)

close_all_windows()