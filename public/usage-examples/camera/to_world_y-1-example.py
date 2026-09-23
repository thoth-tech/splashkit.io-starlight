from splashkit import *

open_window("Depth Gauge", 800, 450)

# The crosshair stays in the middle of the window, at this screen position
crosshair_y = 225

while not quit_requested():
    process_events()

    # The arrow keys slide the camera up and down the world
    if key_down(KeyCode.up_key):
        move_camera_by(0, -4)

    if key_down(KeyCode.down_key):
        move_camera_by(0, 4)

    clear_screen_to_white()

    # The gauge is part of the world, so it slides with the camera
    for tick in range(-1000, 3001, 100):
        draw_line(color_gray(), 480, tick, 680, tick)
        draw_text_font_as_string(str(tick), color_black(), "arial", 18, 690, tick - 10)

    # The crosshair is drawn with option_to_screen() so the camera does not move it
    draw_line_with_options(color_red(), 0, crosshair_y, 800, crosshair_y, option_to_screen())

    # Turn the crosshair's screen position back into a position in the world
    crosshair_world_y = to_world_y(crosshair_y)

    draw_text_with_options_font_as_string(f"World y under the crosshair: {int(crosshair_world_y)}", color_black(), "arial", 26, 30, 25, option_to_screen())
    draw_text_with_options_font_as_string("Up and down arrows move the camera", color_gray(), "arial", 20, 30, 410, option_to_screen())

    refresh_screen_with_target_fps(60)

close_all_windows()
