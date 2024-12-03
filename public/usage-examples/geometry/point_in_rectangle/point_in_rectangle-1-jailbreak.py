from splashkit import *

# Variable declarations
boundary = rectangle_from(150, 150, 300, 100)

open_window("Cursor Jail", 600, 600)

while not quit_requested():

    process_events()
    # Get mouse position and draw boundary to screen
    mouse_point = mouse_position()
    clear_screen(color_green())
    fill_rectangle_record(color_white(), boundary)

    # Check if mouse is in the boundary
    if not point_in_rectangle(mouse_point, boundary):

        # Flash screen red and blue if mouse has escaped boundary
        clear_screen(color_dark_red())
        fill_rectangle_record(color_white(), boundary)
        draw_text_no_font_no_size("JAILBREAK", color_black(), 250.0, 400.0)
        refresh_screen_with_target_fps(2)
        clear_screen(color_royal_blue())
        fill_rectangle_record(color_white(), boundary)
        refresh_screen_with_target_fps(2)

    refresh_screen()

close_all_windows()