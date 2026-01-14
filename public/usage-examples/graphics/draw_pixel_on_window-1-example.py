from splashkit import *

# Declare constants
FPS = 60     # Set frame rate to 60 frames per second

WINDOW_WIDTH = 800
WINDOW_HEIGHT = 600

WINDOW_X_POS = (display_width(display_details(0)) - 2 * WINDOW_WIDTH) // 2
WINDOW_Y_POS = (display_height(display_details(0)) - WINDOW_HEIGHT) // 2

MAX_RADIUS = WINDOW_HEIGHT * 3.0 / 8

# Declare variables
angle = 0.0
radius = 0.0

# Open two windows with black backgrounds and position them side by side at center screen
window_left = open_window("Left Window - Pink Spiral", WINDOW_WIDTH, WINDOW_HEIGHT)
window_right = open_window("Right Window - Blue Spiral", WINDOW_WIDTH, WINDOW_HEIGHT)

clear_window(window_left, color_black())
clear_window(window_right, color_black())

move_window_to(window_left, WINDOW_X_POS, WINDOW_Y_POS)
move_window_to(window_right, WINDOW_X_POS + WINDOW_WIDTH, WINDOW_Y_POS)

while not window_close_requested(window_left) and not window_close_requested(window_right):
    process_events()

    # Stop drawing when max radius is exceeded
    if radius > MAX_RADIUS:
        continue

    # Increment the radius and angle of the next pixel, and calculate the x-y coordinates
    radius += MAX_RADIUS / FPS / 60
    angle += 360.0 / FPS / 15

    x = WINDOW_WIDTH / 2 + radius * cosine(angle)
    y = WINDOW_HEIGHT / 2 + radius * sine(angle)

    # Draw the pixel on each window and refresh
    draw_pixel_on_window(window_left, color_hot_pink(), x, y)
    draw_pixel_on_window(window_right, color_cyan(), x, y)
    refresh_screen_with_target_fps(FPS)

# Clean up
close_all_windows()