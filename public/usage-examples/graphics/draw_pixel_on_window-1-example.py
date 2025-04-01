from splashkit import *

# Sets the refresh rate at 60 frames per second
fps = 60

width = 800
height = 600

# Create a window and make the background black
window = open_window("Usage Example - Draw Pixel On Window", width, height)
clear_window(window, color_black())

# Variables for the angle and radius of the spiral at any given time
angle = 0.0
radius = 0.0

max_radius = width / 2
center = point_at(width / 2, height / 2)

while not window_close_requested(window):
    # Poll for user interaction
    process_events()
    
    # Stop drawing spiral once the width of the window is exceeded
    if radius > max_radius:
        continue
    
    # Increment spiral radius so it will reach window width in 30 seconds
    radius += max_radius / fps / 30
    
    # Increment spiral angle so it will complete a cycle every 5 seconds
    angle += 360.0 / fps / 5
    
    # Calculate the x and y coordinates of the pixel to be drawn
    x = center.x + radius * cosine(angle)
    y = center.y + radius * sine(angle)

    # Draws the next pixel of the spiral on the window
    draw_pixel_on_window(window, color_yellow(), x, y)
    refresh_window_with_target_fps(window, fps)

# Clean up any resources or memory used by the window
close_window(window)