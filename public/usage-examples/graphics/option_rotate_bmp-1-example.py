from splashkit import *

# Set the frame rate to 60 frames per second
fps = 60

# Open a window with dimensions 800 x 600
open_window("Usage Example - Option Rotate Bmp", 800, 600)

# Create a bitmap with dimensions 300 x 300
bmp = create_bitmap("box", 300, 300)

# Draw a red box on the bitmap
rect = quad_from(0, 0, 300, 0, 0, 300, 300, 300)
fill_quad_on_bitmap(bmp, color_red(), rect)

# Initialize a float to hold the angle of the rotated bitmap
angle = 0.0

# Loop until the user exits
while not quit_requested():
    # Poll for events caused by user interaction
    process_events()

    # Increment the angle of the box for the current frame.
    # This calculation will rotate the box 180 degrees every second.
    angle += 360 / 2 / fps

    # Keep the angle between 0 and 360 degrees
    if angle >= 360: angle -= 360

    # Create the draw options that will rotate the bitmap
    opts = option_rotate_bmp(angle)

    # Clear the previous frame and set the background to black
    clear_screen(color_black())

    # Draw the rotated bitmap at the center of the screen
    draw_bitmap_with_options(bmp, 250, 150, opts)

    # Refresh the screen to show the current frame.
    # Since the fps is 60, this will happen 60 times per second.
    refresh_screen_with_target_fps(fps)


# Clean up by freeing any memory used by the windows
close_all_windows()
