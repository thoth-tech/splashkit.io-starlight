from splashkit import *

open_window("Camera X Example", 800, 600)

while not quit_requested():
    process_events()

    if key_down(KeyCode.left_key):
        move_camera_by(-5, 0)

    if key_down(KeyCode.right_key):
        move_camera_by(5, 0)

    clear_screen(color_white())

    fill_rectangle(color_red(), 100, 200, 100, 100)
    fill_rectangle(color_green(), 1000, 200, 100, 100)

    draw_text_no_font_no_size_with_options(
        "Camera X: " + str(camera_x()),
        color_black(),
        20,
        20,
        option_to_screen()
    )

    refresh_screen_with_target_fps(60)

close_all_windows()