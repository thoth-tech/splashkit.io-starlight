from splashkit import *

# Open the window for the usage example
open_window("Purple Shade Brightness", 800, 400)

shades = [
    rgba_color(70, 30, 100, 255),
    rgba_color(140, 70, 180, 255),
    rgba_color(210, 170, 240, 255)
]

names = ["Dark Purple", "Medium Purple", "Light Purple"]

while not quit_requested():
    process_events()

    # Draw the background and instructions
    clear_screen(color_white())
    draw_text_no_font_no_size("Brightness values of purple shades", color_black(), 210, 40)

    # Draw each shade and its brightness value
    for i in range(3):
        value = brightness_of(shades[i])
        fill_circle(shades[i], 150 + i * 240, 180, 55)
        draw_text_no_font_no_size(names[i], color_black(), 105 + i * 240, 260)
        draw_text_no_font_no_size("Brightness: " + str(value), color_black(), 75 + i * 240, 300)

    refresh_screen_with_target_fps(60)

close_all_windows()
