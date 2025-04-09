from splashkit import *

# Creating two lines
lineA = line_from(100, 100, 300, 300)
lineB = line_from(300, 100, 100, 300)

# Creating a list of lines to compare with
lines = [lineB]

# Checking if lineA intersects with any line in the list
intersects = line_intersects_lines(lineA, lines)

# Opening a window
open_window("Line Intersection Demo", 800, 600)
clear_screen(color_white())

# Drawing the lines
draw_line(color_red(), lineA)
draw_line(color_blue(), lineB)

# Showing message based on result
if intersects:
    draw_text("Lines Intersect", color_green(), 320, 550)
else:
    draw_text("No Intersection", color_red(), 320, 550)

refresh_screen()
delay(4000)
close_all_windows()
