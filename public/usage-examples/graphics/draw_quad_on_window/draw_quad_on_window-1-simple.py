from splashkit import *

# Initialise quads with x1, y1,..., x4, y4
q1 = quad_from(400, 200, 300, 300, 300, 0, 200, 200)
q2 = quad_from(400, 210, 310, 300, 600, 300, 400, 390)
q3 = quad_from(200, 400, 300, 300, 300, 600, 400, 400)
q4 = quad_from(200, 390, 290, 300, 0, 300, 200, 210)

# Create windows
window_1 = open_window("Diamonds On Window 1", 600, 600)
window_2 = open_window("Diamonds On Window 2", 600, 600)
clear_screen(color_white())

# Draw quads on windows
draw_quad_on_window(window_1, color_black(), q1)
draw_quad_on_window(window_1, color_green(), q2)
draw_quad_on_window(window_2, color_red(), q3)
draw_quad_on_window(window_2, color_blue(), q4)

refresh_screen()
delay(5000)
close_all_windows()
