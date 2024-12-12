from splashkit import *


open_window("Display Name", 800, 600)

# Load a font
font = load_font("Arial", "arial.ttf")
# Loop through all displays
for i in range(number_of_displays()):
    display = display_details(i)
    draw_text("NAME: " + display_name(display), color_black(), font, 24, 100, 100)

# Refresh the screen to show the drawn text
refresh_screen()
delay(5000)

# Close all windows
close_all_windows()
