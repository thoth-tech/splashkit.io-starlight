from splashkit import *

win = open_window("Window Mover", 300, 300)

while not quit_requested():
    # get user inputs
    process_events()

    clear_screen(color_white())

    # Get position of the window
    current_x = window_x(win)
    current_y = window_y(win)

    # Move window buttons
    if button_at_position("NW", rectangle_from(50, 50, 40, 40)):
        move_window_to(win, current_x - 10, current_y - 10)

    if button_at_position("N", rectangle_from(130, 50, 40, 40)):
        move_window_to(win, current_x, current_y - 10)

    if button_at_position("NE", rectangle_from(210, 50, 40, 40)):
        move_window_to(win, current_x + 10, current_y - 10)

    if button_at_position("W", rectangle_from(50, 130, 40, 40)):
        move_window_to(win, current_x - 10, current_y)

    if button_at_position("E", rectangle_from(210, 130, 40, 40)):
        move_window_to(win, current_x + 10, current_y)

    if button_at_position("SW", rectangle_from(50, 210, 40, 40)):
        move_window_to(win, current_x - 10, current_y + 10)

    if button_at_position("S", rectangle_from(130, 210, 40, 40)):
        move_window_to(win, current_x, current_y + 10)

    if button_at_position("SE", rectangle_from(210, 210, 40, 40)):
        move_window_to(win, current_x + 10, current_y + 10)

    draw_interface()
    refresh_screen()

# close all open windows
close_all_windows()