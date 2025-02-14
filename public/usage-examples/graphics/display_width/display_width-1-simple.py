from splashkit import *

# Open a window
open_window("Display Width", 800, 600)

# Load a font
font = load_font("Arial", "arial.ttf")

# Loop through all displays
for i in range(number_of_displays()):
    display = display_details(i) 
    draw_text("Width: " + str(display_width(display)), color_black(), font, 24, 100, 100) # Write display width to the screen

# Refresh the screen to show the drawn text
refresh_screen()

# Keep the window open for 3 seconds
delay(3000)

# Close all windows
close_all_windows()
