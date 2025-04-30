from splashkit import *

# Clear the screen with white color
clear_screen(Color.White)

# Define the circle's center and radius
center = Point2D(400, 300)
radius = 100
heading = 90

# Define the point of reference (can be used for calculations)
from_point = Point2D(100, 100)

# Calculate the distant point on the circle based on the given heading
far_point = distant_point_on_circle_heading(center, radius, from_point, heading)

# Draw the circle and the far point
draw_circle(Color.Blue, center, radius)
draw_pixel(Color.Red, far_point)

# Refresh screen to display everything at 60 FPS
refresh_screen(60)

# Delay for 5000 milliseconds to keep the window open
delay(5000)
