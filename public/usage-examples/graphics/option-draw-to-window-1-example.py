from splashkit import *

def option_draw_to_window(dest):
    return option_draw_to(dest)

# Open two windows
main_win = open_window("Main", 400, 300)
side_win = open_window("Side", 400, 300)

while not quit_requested():
    process_events()
    
    # Draw something to the main window
    clear_screen(color_white(), main_win)
    draw_text("Main Window", color_black(), 20, 20, option_draw_to_window(main_win))

    # Draw something to the side window
    clear_screen(color_light_gray(), side_win)
    draw_text("Side Window", color_red(), 20, 20, option_draw_to_window(side_win))

    refresh_screen(main_win)
    refresh_screen(side_win)

close_all_windows()
