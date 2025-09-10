from splashkit import *

open_window("Line Width Example", 800, 600)

opt = option_line_width(10)
draw_line_with_options(color_black(), 100, 100, 200, 200, opt)

opt = option_line_width(5)  # Reuse the same variable
draw_line_with_options(color_red(), 400, 100, 600, 250, opt)

refresh_screen()

# Keep the window open until the user closes it
while not quit_requested():
    process_events()
