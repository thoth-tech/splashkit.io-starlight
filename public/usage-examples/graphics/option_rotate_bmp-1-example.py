from splashkit import *

# Set the frame rate to 60 frames per second
fps = 60

# Open a window with dimensions 800 x 600
window = open_window("Usage Example - Option Rotate Bmp", 800, 600)

# Create a bitmap with dimensions 300 x 300
bmp = create_bitmap("box", 300, 300)

# Draw a red box on the bitmap
rect = quad_from(0, 0, 300, 0, 0, 300, 300, 300)
fill_quad_on_bitmap(bmp, color_red(), rect)

# Initialize a double to hold the angle of the rotated bitmap
angle = 0.0

# Loop until the user exits
while not window_close_requested(window):
    # Poll for events caused by user interaction
    process_events()

    # Rotate the box 180 degrees every second
    angle += 360 / 2 / fps

    # Create the draw options that will rotate the bitmap
    opts = option_rotate_bmp(angle)

    # Clear the previous frame and set the background to black
    clear_window(window, color_black())

    # Draw the rotated bitmap at the center of the screen
    draw_bitmap_on_window_with_options(window, bmp, 250, 150, opts)
    refresh_window_with_target_fps(window, fps)

# Clean up by freeing any memory used by the window
close_window(window)
