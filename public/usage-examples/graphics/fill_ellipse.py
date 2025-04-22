from splashkit import *

open_window("Fill Ellipse Example", 800, 600)

clear_screen(Color.White)

fill_ellipse(Color.Blue, 200, 200, 400, 200)
draw_rectangle(Color.Red, 200, 200, 400, 200)

refresh_screen()

delay(4000)
close_all_windows()
