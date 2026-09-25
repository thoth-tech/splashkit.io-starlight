from splashkit import *

open_window("Set Camera Position Example", 400, 300)

camera_x = 0

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Move the camera position each frame
    set_camera_position(point_at(camera_x, 0))
    camera_x += 1

    # A stationary object in the world - it does not move itself
    fill_rectangle(color_red(), 200, 100, 50, 50)

    refresh_screen_with_target_fps(60)

close_all_windows()