from splashkit import *

window = open_window("Option Flip Y", 600, 600)

bmp = load_bitmap("Landscape", "landscape.png")

# Draw the original bitmap image at position (100, 300)
draw_bitmap(bmp, 100, 300)

# Draw the bitmap image flipped horizontally at position (400, 300)
draw_bitmap_on_window_with_options(window, bmp, 400, 300, option_flip_y())

refresh_screen()

delay(5000)

close_all_windows()
