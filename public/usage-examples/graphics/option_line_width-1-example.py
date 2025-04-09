from splashkit import *

open_window("Line Width Example", 800, 600)

# Set line width to 10 and draw the first line
option_line_width(10)
draw_line(color_black(), 100, 100, 200, 200)  # Draw a line instead of a rectangle

# Set line width to 5 and draw the second line
option_line_width(5)
draw_line(color_red(), 400, 100, 600, 250)  # Draw a line instead of a rectangle

refresh_screen()

# Keep the window open until the user closes it
while not quit_requested():
    process_events()
