from splashkit import *

# Open a window with the title "Pop Clip" and dimensions 800x600
window = open_window("Pop Clip", 800, 600)

# Define the clipping area as a rectangle starting at (100, 100) with width 600 and height 400
r = rectangle_from(100, 100, 600, 400)

# Push a clipping area for the window
push_clip_for_window(window, r)

# Draw a blue rectangle inside the clipping area (this will be clipped by the clipping area)
fill_rectangle(color_blue(), 50, 50, 700, 500)

# Restore the full window area after the clipping
pop_clip_for_window(window)

# Draw a red rectangle outside the clipping area (this will not be clipped)
fill_rectangle(color_red(), 100, 100, 200, 200)

# Refresh the screen to display the changes
refresh_screen()

# Wait for 5 seconds to observe the drawing
delay(5000)

# Close all open windows to end the program
close_all_windows()
