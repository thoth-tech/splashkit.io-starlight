from splashkit import *

open_window("Screen Rectangle", 640, 480)

screen = screen_rectangle()

clear_screen(color_white())

fill_rectangle(
    color_light_blue(),
    screen.x,
    screen.y,
    screen.width,
    screen.height
)

draw_rectangle(
    color_dark_blue(),
    screen.x,
    screen.y,
    screen.width,
    screen.height
)

draw_text_no_font_no_size(
    "screen_rectangle() represents the current window area",
    color_black(),
    30,
    40
)

draw_text_no_font_no_size(
    "Window size: 640 x 480",
    color_black(),
    30,
    75
)

refresh_screen()

delay(4000)

close_all_windows()
