from splashkit import *

open_window("Camera Position Example", 800, 600)

while not quit_requested():
    process_events()

    # Move the camera using the arrow keys
    if key_down(KeyCode.left_key):
        move_camera_by(-5, 0)

    if key_down(KeyCode.right_key):
        move_camera_by(5, 0)

    if key_down(KeyCode.up_key):
        move_camera_by(0, -5)

    if key_down(KeyCode.down_key):
        move_camera_by(0, 5)

    camera = camera_position()

    clear_screen(color_white())

    # Stationary objects in the world
    fill_rectangle(color_red(), 100, 200, 100, 100)
    fill_circle(color_blue(), 600, 300, 50)
    fill_rectangle(color_green(), 1100, 200, 100, 100)

    draw_text_no_font_no_size_with_options(
        "Use arrow keys to move the camera",
        color_black(),
        20,
        20,
        option_to_screen()
    )

    draw_text_no_font_no_size_with_options(
        "Camera Position: " + point_to_string(camera),
        color_black(),
        20,
        50,
        option_to_screen()
    )

    refresh_screen_with_target_fps(60)

close_all_windows()