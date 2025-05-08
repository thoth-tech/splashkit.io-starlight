from splashkit import *

window = open_window("Option Flip X", 600, 600)


bmp = load_bitmap("Player", "character.png")

# Draw the original bitmap image at position (100, 300) in the window
draw_bitmap(bmp, 100, 300)

# Draw the bitmap image flipped horizontally at position (500, 300) 
draw_bitmap_on_window_with_options(window, bmp, 500, 300, option_flip_xy())

refresh_screen()

delay(5000)

close_all_windows()
