from splashkit import *

# Open a window with the title "Set Clip" and dimensions of 800x600 pixels
window = open_window("Set Clip", 800, 600)

# Define the clipping area with a rectangle (x, y, width, height)
r = rectangle_from(100, 100, 600, 400)

# Set the clipping area to restrict drawing within the specified rectangle
set_clip(r)

# Draw a large blue rectangle; it will be clipped to the set area
fill_rectangle(color_blue(), 50, 50, 700, 500)

# Refresh the screen to display the drawing
refresh_screen()

# Delay for 5 seconds to observe the effect of the clipping
delay(5000)

# Close all windows
close_all_windows()
