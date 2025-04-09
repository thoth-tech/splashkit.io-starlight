from splashkit import *

# Open a new window with the title "Option Flip X" 
window = open_window("Option Flip X", 600, 600)

# Load a bitmap image named "Player" from the file "character.png"
bmp = load_bitmap("Player", "character.png")

# Draw the original bitmap image at position (100, 300) in the window
draw_bitmap(bmp, 100, 300)

# Draw the bitmap image flipped horizontally at position (500, 300) 
draw_bitmap_on_window_with_options(window, bmp, 500, 300, option_flip_xy())

# Refresh the screen to display the drawings
refresh_screen()

# Wait for 5 seconds before closing the window
delay(5000)

# Close all open windows
close_all_windows()
