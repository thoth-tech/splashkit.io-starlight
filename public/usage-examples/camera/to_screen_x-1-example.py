from splashkit import *

open_window("Landmark Tracker", 800, 450)

# The tower stays at this world position, wherever the camera is looking
tower_x = 400

while not quit_requested():
    process_events()

    # The arrow keys slide the camera along the world
    if key_down(KeyCode.left_key):
        move_camera_by(-4, 0)

    if key_down(KeyCode.right_key):
        move_camera_by(4, 0)

    clear_screen_to_white()

    # Shapes are drawn in world coordinates, so they slide across the window with the camera
    draw_line(color_gray(), -2000, 350, 4000, 350)
    fill_rectangle(color_dark_red(), tower_x - 20, 230, 40, 120)

    # Ask the camera where the tower's world position appears on the screen
    tower_screen_x = to_screen_x(tower_x)

    # A marker at that screen position, drawn with option_to_screen() so the camera does not move it
    draw_line_with_options(color_blue(), tower_screen_x, 100, tower_screen_x, 395, option_to_screen())

    draw_text_with_options_font_as_string(f"Tower world x: {int(tower_x)}", color_black(), "arial", 26, 30, 25, option_to_screen())
    draw_text_with_options_font_as_string(f"Tower screen x: {int(tower_screen_x)}", color_black(), "arial", 26, 30, 65, option_to_screen())
    draw_text_with_options_font_as_string("Left and right arrows move the camera", color_gray(), "arial", 20, 30, 410, option_to_screen())

    refresh_screen_with_target_fps(60)

close_all_windows()
