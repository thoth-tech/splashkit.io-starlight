from splashkit import *

open_window("Hot Pink Colour Showcase", 800, 600)

# Store the named colour once so every shape uses the same value.
hot_pink = color_hot_pink()

while not quit_requested():
    process_events()

    clear_screen(color_dark_slate_gray())

    # Repeat the colour across different shapes to showcase the result.
    fill_rectangle(hot_pink, 160, 120, 480, 260)
    fill_circle(hot_pink, 280, 455, 55)
    fill_circle(hot_pink, 400, 455, 55)
    fill_circle(hot_pink, 520, 455, 55)

    draw_text("HOT PINK COLOUR SHOWCASE", color_white(), 270, 65)
    draw_text("Created with color_hot_pink()", color_white(), 290, 535)

    refresh_screen(60)

close_all_windows()
