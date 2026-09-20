from splashkit import *

open_window("Balloon Height", 800, 450)

# The balloon stays at this world position, wherever the camera is looking
balloon_x = 600
balloon_y = 225

while not quit_requested():
    process_events()

    # The arrow keys slide the camera up and down the world
    if key_down(KeyCode.up_key):
        move_camera_by(0, -4)

    if key_down(KeyCode.down_key):
        move_camera_by(0, 4)

    clear_screen_to_white()

    # Shapes are drawn in world coordinates, so they slide across the window with the camera
    draw_line(color_gray(), 400, 420, 800, 420)
    draw_line(color_gray(), balloon_x, balloon_y + 40, balloon_x, 420)
    fill_circle(color_red(), balloon_x, balloon_y, 40)

    # Ask the camera where the balloon's world position appears on the screen
    balloon_screen_y = to_screen_y(balloon_y)

    # A marker at that screen position, drawn with option_to_screen() so the camera does not move it
    draw_line_with_options(color_blue(), 380, balloon_screen_y, 800, balloon_screen_y, option_to_screen())

    draw_text_with_options_font_as_string(f"Balloon world y: {int(balloon_y)}", color_black(), "arial", 26, 30, 25, option_to_screen())
    draw_text_with_options_font_as_string(f"Balloon screen y: {int(balloon_screen_y)}", color_black(), "arial", 26, 30, 65, option_to_screen())
    draw_text_with_options_font_as_string("Up and down arrows move the camera", color_gray(), "arial", 20, 30, 410, option_to_screen())

    refresh_screen_with_target_fps(60)

close_all_windows()
