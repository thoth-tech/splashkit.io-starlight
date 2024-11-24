from splashkit import *

my_window = open_window("Draw Snowman On Window", 800, 600)

# Draw snowman to window and refresh
clear_screen(color_light_blue())
fill_ellipse_on_window(my_window, color_white(), 300, 400, 200, 200)
fill_ellipse_on_window(my_window, color_white(), 320, 240, 160, 160)
fill_ellipse_on_window(my_window, color_black(), 350, 300, 10, 10)
fill_ellipse_on_window(my_window, color_black(), 400, 300, 10, 10)
fill_triangle_on_window(my_window, color_orange(),
                        325, 330, 375, 320, 375, 340)
refresh_window(my_window)

delay(6000)
close_window(my_window)
