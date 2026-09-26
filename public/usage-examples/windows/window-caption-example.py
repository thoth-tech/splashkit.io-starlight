from splashkit import *

# Open a new window
my_window = open_window("My SplashKit Window", 800, 600)

# Get the window caption
caption = window_caption(my_window)

# Keep the program running until the user closes the window
while not quit_requested():
    process_events()

    # Draw content on the screen
    clear_screen(color_white())

    draw_text("Window caption:", color_black(), 20, 260, option_to_screen())
    draw_text(caption, color_blue(), 20, 300, option_to_screen())

    refresh_screen_with_target_fps(60)

# Close all open windows
close_all_windows()