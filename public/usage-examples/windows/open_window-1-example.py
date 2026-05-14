from splashkit import *

open_window("Simple Welcome Screen", 800, 600)

while not quit_requested():
    process_events()

    clear_screen(Color.SKY_BLUE)
    fill_rectangle(Color.WHITE, 220, 230, 360, 120)
    draw_text("Welcome to SplashKit!", Color.BLACK, 290, 270)
    draw_text("This window was opened using open_window.", Color.BLACK, 245, 305)

    refresh_screen(60)

close_all_windows()