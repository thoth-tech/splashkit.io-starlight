from splashkit import *

open_window("Set Camera Y Example", 800, 600)

y = 0

while not quit_requested():
    process_events()

    if key_down(KeyCode.up_key):
        y -= 5

    if key_down(KeyCode.down_key):
        y += 5

    set_camera_y(y)

    clear_screen(color_white())

    fill_rectangle(color_red(), 200, 100, 100, 100)
    fill_rectangle(color_green(), 200, 1000, 100, 100)

    draw_text_no_font_no_size_with_options(
        "Camera Y: " + str(camera_y()),
        color_black(),
        20,
        20,
        option_to_screen()
    )

    refresh_screen_with_target_fps(60)

close_all_windows()