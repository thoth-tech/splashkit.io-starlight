from splashkit import *

window = open_window("Push Clip", 800, 600)

# Define the clipping area as a rectangle
r = rectangle_from(100, 100, 200, 200)

# Push the clipping area onto the window stack
push_clip(r)

# Draw a blue rectangle within the clipping area (will be clipped)
fill_rectangle(color_blue(), 50, 50, 300, 300)

# Pop the clipping area from the window stack to restore full drawing capability
pop_clip()

# Draw a red rectangle outside the clipping area (will not be clipped)
fill_rectangle(color_red(), 300, 300, 200, 200)

# Refresh the screen to display the drawing
refresh_screen()

# Wait for 5 seconds to observe the result
delay(5000)

# Close the window
close_all_windows()
