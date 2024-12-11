from splashkit import *

# Open a new window with the title "Option Flip X" and dimensions 800x600
window = open_window("Option Flip X", 800, 600)

# Load a bitmap image named "Player" from the file "character.png"
bmp = load_bitmap("Player", "character.png")

# Draw the original bitmap image at position (100, 100) in the window
draw_bitmap(bmp, 100, 100)

# Draw the bitmap image flipped vertically at position (300, 100) in the specified window
draw_bitmap_on_window_with_options(window, bmp, 300, 100, option_flip_xy())

# Refresh the screen to display the drawings
refresh_screen()

# Pause the program for 5000 milliseconds (5 seconds) to keep the window open
delay(5000)

# Close all open windows
close_all_windows()
