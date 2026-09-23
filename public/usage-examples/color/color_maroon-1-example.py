from splashkit import *

open_window("Color Maroon", 800, 600)

while not quit_requested():
    process_events()
    clear_screen(color_white())

    # Muted supporting colors
    muted_green = rgb_color(90, 110, 80)
    cream = rgb_color(210, 190, 150)

    # Draw the stem
    fill_rectangle(muted_green, 395, 330, 10, 180)

    # Draw the leaves
    fill_circle(muted_green, 365, 420, 30)
    fill_circle(muted_green, 435, 450, 30)

    # Draw the maroon flower petals
    fill_circle(color_maroon(), 400, 220, 55)
    fill_circle(color_maroon(), 330, 270, 55)
    fill_circle(color_maroon(), 470, 270, 55)
    fill_circle(color_maroon(), 355, 345, 55)
    fill_circle(color_maroon(), 445, 345, 55)

    # Draw the muted flower centre
    fill_circle(cream, 400, 290, 55)

    refresh_screen()

close_all_windows()