from splashkit import *

# Open the window for the usage example
open_window("Reading the Blue Channel", 800, 400)

# Three shades of blue with the same red/green/alpha, only blue differs
shades = [
    rgba_color(80, 80, 30, 255),
    rgba_color(80, 80, 130, 255),
    rgba_color(80, 80, 230, 255)
]

labels = ["Low Blue", "Medium Blue", "High Blue"]

while not quit_requested():
    process_events()

    # Draw the background and instructions
    clear_screen(color_white())
    draw_text_no_font_no_size("Blue values for these shades", color_black(), 240, 40)

    # Draw each shade and use blue_of to read its blue component
    for i in range(3):
        value = blue_of(shades[i])

        fill_rectangle(shades[i], 80 + i * 240, 140, 160, 80)
        draw_text_no_font_no_size(labels[i], color_black(), 115 + i * 240, 250)
        draw_text_no_font_no_size("Blue: " + str(value), color_black(), 115 + i * 240, 290)

    refresh_screen_with_target_fps(60)

close_all_windows()
