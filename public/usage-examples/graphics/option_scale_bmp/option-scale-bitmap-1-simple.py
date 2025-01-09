from splashkit import *

# Open a new window with the title "Bitmap Scaling" and dimensions 800x600
open_window("Bitmap Scaling", 800, 600)

# Load the bitmap from the file "landscape.png" and give it the name "Landscape"
bmp = load_bitmap("Landscape", "landscape.png")

# Set the scaling factors for the bitmap
scaleX = 0.5  # Scale the width to 50% of the original size
scaleY = 0.5  # Scale the height to 50% of the original size

# Draw the scaled bitmap onto the window at coordinates (100, 100)
draw_bitmap_with_options(bmp, 100, 100, option_scale_bmp(scaleX, scaleY))

# Refresh the screen to display the changes
refresh_screen()

# Pause the program for 3000 milliseconds (3 seconds)
delay(3000)

# Free the memory used by the bitmap
free_bitmap(bmp)

# Close all open windows
close_all_windows()
