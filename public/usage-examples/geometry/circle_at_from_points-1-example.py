from splashkit import *

open_window("Flag of Japan", 600, 400)

# Create a circle at (300, 200) with radius 120
my_circle = circle_at_from_points(300, 200, 120)

while (not quit_requested()):
    process_events()
    clear_screen(color_white())

    # Draw the circle
    fill_circle_record(color_dark_red(), my_circle)

    refresh_screen() 

close_all_windows()

