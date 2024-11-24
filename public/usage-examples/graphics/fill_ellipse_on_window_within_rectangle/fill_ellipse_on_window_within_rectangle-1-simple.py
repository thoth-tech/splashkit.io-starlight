from splashkit import *

my_window = open_window("Draw Snowman On Window", 800, 600)

# Define rectangles for each ellipse
body = rectangle_from(300, 400, 200, 200)
head = rectangle_from(320, 240, 160, 160)
left_eye = rectangle_from(350, 300, 10, 10)
right_eye = rectangle_from(400, 300, 10, 10)

# Draw snowman to window and refresh
clear_screen(color_light_blue())
fill_ellipse_on_window_within_rectangle(my_window, color_white(), body)
fill_ellipse_on_window_within_rectangle(my_window, color_white(), head)
fill_ellipse_on_window_within_rectangle(my_window, color_black(), left_eye)
fill_ellipse_on_window_within_rectangle(my_window, color_black(), right_eye)
fill_triangle_on_window(my_window, color_orange(),
                        325, 330, 375, 320, 375, 340)
refresh_window(my_window)

delay(6000)
close_window(my_window)
