from splashkit import *

# Open a window
open_window("Display Details", 800, 600)

# Load a font
font = load_font("Arial", "arial.ttf")

# Loop through all displays 
for i in range(number_of_displays()):
    display = display_details(i) 
    draw_text("NAME: " + display_name(display), color_black(), font, 24, 100, 100) # Write display name to the screen
    draw_text("NAME: " + str(display_width(display)) + " X " + str(display_height(display)), color_black(), font, 24, 100, 200) # Write display height and width to the screen
# Refresh the screen to show the drawn text
refresh_screen()

# Keep the window open for 3 seconds
delay(3000)

# Close all windows
close_all_windows()
