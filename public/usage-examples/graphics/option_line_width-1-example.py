from splashkit import *

open_window("Line Width Example", 800, 600)

# Set line width to 10
option_line_width(10)
# Draw first rectangle with line width 10
draw_rectangle(color_black(),100, 100, 200, 150)

# Set line width to 5
option_line_width(5)
# Draw second rectangle with line width 5
draw_rectangle(color_black(),400, 100, 200, 150)

refresh_screen()
delay(3000)
