from splashkit import *

# Initialise quads with x1, y1, ..., x4, y4
q1 = quad_from(400, 200, 300, 300, 300, 0, 200, 200)
q2 = quad_from(400, 210, 310, 300, 600, 300, 400, 390)
q3 = quad_from(200, 400, 300, 300, 300, 600, 400, 400)
q4 = quad_from(200, 390, 290, 300, 0, 300, 200, 210)

# Create Window
open_window("Ninja Star", 600, 600)
clear_screen(color_white())

# Draw the quads
draw_quad(color_black(), q1)
draw_quad(color_green(), q2)
draw_quad(color_red(), q3)
draw_quad(color_blue(), q4)

# Refresh the screen
refresh_screen()

# Wait for 5 seconds before closing
delay(5000)

# Close the window
close_all_windows()