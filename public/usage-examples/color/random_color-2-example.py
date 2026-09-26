from splashkit import *

open_window("Random Color Example", 800, 600)

box_color = color_blue()

while not quit_requested():
    process_events()

    if mouse_clicked(LEFT_BUTTON):
        box_color = random_color()

    clear_screen(color_white())

    fill_rectangle(box_color, 250, 200, 300, 180)

    draw_text(
        "Click anywhere to change colour",
        color_black(),
        220,
        420
    )

    refresh_screen()