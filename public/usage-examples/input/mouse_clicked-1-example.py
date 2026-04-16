from splashkit import *

open_window("Click to Place Markers", 800, 600)

clicks = []

while not quit_requested():
    process_events()

    # Add a marker where the left mouse button was clicked
    if mouse_clicked(MouseButton.left_button):
        clicks.append(mouse_position())

    clear_screen(color_white())

    for pt in clicks:
        fill_circle(color_red(), pt.x, pt.y, 8)

    refresh_screen()

close_all_windows()