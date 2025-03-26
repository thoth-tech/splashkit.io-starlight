from splashkit import *

# Set frame rate to 60 frames per second
fps = 60

# Create a window with dimensions 800 x 600
window = open_window("Usage Example - Option Scale Bitmap", 800, 600)

# Create a bitmap called 'ring' with dimensions 600 x 600
bmp = create_bitmap("ring", 600, 600)

# Paint the bitmap background black
clear_bitmap(bmp, color_black())

# Draw a ring on the bitmap
fill_circle_on_bitmap(bmp, color_white(), 300, 300, 300)
fill_circle_on_bitmap(bmp, color_black(), 300, 300, 200)

# Initialize the time to 0
time = 0.0

# Loop until the user closes the window
while not window_close_requested(window):
    # Poll for user interactions
    process_events()

    # Increment the time by the duration of a frame
    time += 1.0 / fps

    # Calculate the scale factor by squaring the time
    scale_factor = time * time

    # If the bitmap is over 2.5 times its initial size, then reset the time
    if scale_factor > 2.5: time = 0.0

    # Create the draw options that will scale the bitmap
    opts = option_scale_bmp(scale_factor, scale_factor)

    # Draw the scaled bitmap onto the window and refresh
    clear_window(window, color_black())
    draw_bitmap_on_window_with_options(window, bmp, 100, 0, opts)
    refresh_window_with_target_fps(window, fps)

# Clean up any memory or resources being used by the window
close_window(window)