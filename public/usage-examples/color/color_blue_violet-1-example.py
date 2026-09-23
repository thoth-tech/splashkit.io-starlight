from splashkit import *

open_window("Color Blue Violet", 500, 500)

clear_screen(color_white())

# Draw 8 circles from largest to smallest to create a set of rings
for i in range(8):
    radius = 200 - i * 25

    if i % 2 == 0:
        # Function used here ↓
        fill_circle(color_blue_violet(), 250, 250, radius)
    else:
        # The white circles cut the rings out of the blue violet ones
        fill_circle(color_white(), 250, 250, radius)

draw_text_no_font_no_size("Rings drawn with color_blue_violet", color_blue_violet(), 155, 470)

refresh_screen()

delay(5000)

close_all_windows()
