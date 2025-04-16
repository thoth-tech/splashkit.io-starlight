from splashkit import *

open_window("Circle Intersects Line", 800, 600)

# Define points for the line
start_point = Point2D()
start_point.x = 100
start_point.y = 100
end_point = Point2D()
end_point.x = 700
end_point.y = 500

#Define a circle
circle = circle_at_from_points(400, 300, 100)

# Draw the line
line = line_from_point_to_point(start_point, end_point)
draw_line_record(color_blue(), line)

# Draw the circle
draw_circle_record(color_red(), circle)

# Check for intersection
intersect = line_intersects_circle(line, circle)

# Display result
draw_text_no_font_no_size("Line and Circle intersect: " + ("Yes" if intersect else "No"), color_black(), 400, 100)

refresh_screen()
delay(5000)

close_all_windows()