from splashkit import *

open_window("Point In Circle", 800, 600)
clear_screen(color_white())

# Create a circle A
A = circle_at(point_at(400, 300), 100)

while not quit_requested():
   
    process_events()

    # Set mouse point to the position of mouse
    MousePoint = mouse_position()

    # When mouse inside the circle show text "point in the circle!" and the color of the circle change to red
    if point_in_circle(MousePoint, A):
        clear_screen(color_white())
        draw_circle(color_red(), 400, 300, 100)
        text = "Point in the Circle!"
        draw_text(text, color_red(),0, 10, 100, 100)
        refresh_screen()
        
    # When mouse do not inside the circle show text "point not in the circle!" and the color of the circle change to green
    else:
        clear_screen(color_white())
        draw_circle(color_green(), 400, 300, 100)
        text = "Point not in the Circle!"
        draw_text(text, color_red(), 0, 10, 100, 100)
        refresh_screen()
        
refresh_screen()
delay(4000)
close_all_windows()