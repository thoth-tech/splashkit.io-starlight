from splashkit import *

# Open a new window
open_window("Simple Welcome Screen", 800, 600)

# Keep the program running until the user closes the window
while not quit_requested():
    process_events()

    # Draw content on the screen
    clear_screen(Color.SKY_BLUE)
    fill_rectangle(Color.WHITE, 220, 230, 360, 120)
    draw_text("Welcome to SplashKit!", Color.BLACK, 290, 270)
    draw_text("This window was opened using open_window.", Color.BLACK, 245, 305)

    refresh_screen_with_target_fps(60)

# Close all open windows
close_all_windows()