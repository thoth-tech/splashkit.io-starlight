from splashkit import *

# Open a window for the circle-intersection demo
open_window("Background Change Circles", 600, 600)

# Determine the static circle’s center and radius
center = screen_center()
static_x, static_y = center.x, center.y
static_radius = 80

# Continue running until the user closes the window
while not quit_requested():
    process_events()

    # Track the moving circle at the mouse position
    mouse = mouse_position()
    moving_x, moving_y = mouse.x, mouse.y
    moving_radius = 80

    # Toggle background color when circles intersect
    if circles_intersect_using_values(
            static_x, static_y, static_radius,
            moving_x, moving_y, moving_radius):
        clear_screen(color_red())
    else:
        clear_screen(color_white())

    # Draw the static and moving circles
    fill_circle(color_blue(),  static_x,  static_y,  static_radius)
    fill_circle(color_green(), moving_x, moving_y, moving_radius)

    # Refresh at 30 FPS for smooth animation
    refresh_screen_with_target_fps(30)

# Clean up and close the window
close_all_windows()
