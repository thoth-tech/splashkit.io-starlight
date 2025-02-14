from splashkit import *

# Open a window with the title "Current Clip" and dimensions of 800x600 pixels
window = open_window("Current Clip", 800, 600)
font = load_font("Arial", "arial.ttf")

# Retrieve the current clipping area
rectangle = current_clip()

# Draw the clipping area dimensions as text on the screen
draw_text("Current Clip: " + str(rectangle.width) + " X " + str(rectangle.height), color_black(), font, 24, 100, 100)

# Refresh the screen to display the text
refresh_screen()

# Wait for 5 seconds
delay(5000)

# Close all windows
close_all_windows()

