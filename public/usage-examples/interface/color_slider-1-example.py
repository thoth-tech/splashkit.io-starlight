from splashkit import *

# open window
open_window("color slider demo", 800, 400)

# start color + panel for sliders
current = COLOR_SKY_BLUE
panel = rectangle_from(40, 40, 300, 140)

while not quit_requested():
    process_events()
    clear_screen(COLOR_WHITE)

    # update color using the sliders
    current = color_slider(current, panel)  # if your binding uses color_slider_at_position, swap the name

    # preview rectangle
    fill_rectangle(current, 400, 40, 320, 140)

    draw_interface()
    refresh_screen()

close_all_windows()
