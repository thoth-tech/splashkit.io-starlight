from splashkit import *

open_window("Circle At Example", 800, 600)

# Create a circle at (400, 300) with radius 100
my_circle = circle_at_from_points(400, 300, 100)

while not window_close_requested("Circle At Example"):
    process_events()
    clear_screen(Color.White)

    # Draw the circle
    fill_circle(Color.Blue, my_circle)

    refresh_screen() 

close_all_windows()

