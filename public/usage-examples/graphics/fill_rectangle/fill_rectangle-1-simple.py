from splashkit import *

#Create a window with title Fill rectangle, width 800, height 600.
open_window("Fill Rectangle", 800, 600)

clear_screen(color_white())
refresh_screen()

#draw three rectangles with color green, yellow, and red with different position as (100,200), (300,200), (500,200) with same size.
fill_rectangle(color_green(), 100, 200, 200, 100)
fill_rectangle(color_yellow(), 300, 200, 200, 100)
fill_rectangle(color_red(), 500, 200, 200, 100)


refresh_screen()
delay(4000)
close_all_windows()

