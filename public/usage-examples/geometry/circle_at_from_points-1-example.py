from splashkit import *



open_window("Circle At Example", 800, 600)
my_circle = circle_at_from_points(400, 300, 100)

while not window_close_requested("Circle At Example"):
    process_events()
    clear_screen(Color.White)

    # Draw the circle
    fill_circle(Color.Blue, my_circle)

    refresh_screen() 

