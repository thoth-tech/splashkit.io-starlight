from splashkit import *
import random

# Open a window titled "Falling Snow" with a size of 800x600
window = open_window("Falling Snow", 800, 600)

# Loop until the user requests to quit
while not quit_requested():
    for _ in range(100):  # Draw 100 random pixels

        draw_pixel_on_window(window, color_gray(), rnd_int(800), rnd_int(600))
        refresh_screen() # Refresh the screen to show the pixels
        delay(50) # Delay to control the frame rate

# Close all windows
close_all_windows()