from splashkit import *

open_window("Point On Screen Example", 400, 300)

# Load the font used to display the visibility status text
status_font = load_font("StatusFont", "DejaVuSans.ttf")

# A fixed point in the world we will check each frame
world_point = point_at(500, 100)

camera_x = 0

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Move the camera position each frame
    set_camera_position(point_at(camera_x, 0))
    camera_x += 5

    # Draw a circle at the fixed world point - it does not move itself
    fill_circle_at_point(color_red(), world_point, 20)

    # Convert the world point to screen coordinates, then check visibility
    # The text is drawn to_screen so it stays fixed and does not scroll with the camera
    if point_on_screen(to_screen_point(world_point)):
        draw_text_with_options("Point On Screen: TRUE", color_black(), status_font, 20, 10, 10, option_to_screen())
    else:
        draw_text_with_options("Point On Screen: FALSE", color_black(), status_font, 20, 10, 10, option_to_screen())

    refresh_screen_with_target_fps(60)

close_all_windows()