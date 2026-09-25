from splashkit import *


open_window("Green Channel Shades", 700, 450)

low_green = rgb_color(80, 30, 120)
medium_green = rgb_color(80, 130, 120)
high_green = rgb_color(80, 230, 120)

clear_screen(color_white())

fill_rectangle(low_green, 80, 70, 180, 80)
draw_text_font_as_string(
    "Green value: " + str(green_of(low_green)),
    color_black(),
    "Arial",
    20,
    300,
    100
)

fill_rectangle(medium_green, 80, 180, 180, 80)
draw_text_font_as_string(
    "Green value: " + str(green_of(medium_green)),
    color_black(),
    "Arial",
    20,
    300,
    210
)

fill_rectangle(high_green, 80, 290, 180, 80)
draw_text_font_as_string(
    "Green value: " + str(green_of(high_green)),
    color_black(),
    "Arial",
    20,
    300,
    320
)

refresh_screen()
delay(5000)

close_all_windows()