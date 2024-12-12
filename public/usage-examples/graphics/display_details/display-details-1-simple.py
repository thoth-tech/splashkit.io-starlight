from splashkit import *

# Open a window
open_window("Display Details", 800, 600)
# Loop through all displays
# Load a font
font = load_font("Arial", "arial.ttf")
# Loop through all displays and print their details
for i in range(number_of_displays()):
    display = display_details(i) # Get the details of the display
    draw_text("NAME: " + display_name(display), color_black(), font, 24, 100, 100)
    draw_text("NAME: " + str(display_width(display)) + " X " + str(display_height(display)), color_black(), font, 24, 100, 200)
# Refresh the screen to show the drawn text
refresh_screen()
delay(5000)
# Close all windows
close_all_windows()
