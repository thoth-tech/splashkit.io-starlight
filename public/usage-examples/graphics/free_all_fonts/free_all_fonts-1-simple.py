from splashkit import *

# Open a window with the title "Free All Front" and dimensions 800x600
open_window("Free All Front", 800, 600)

# Load the "Arial" font from the file "arial.ttf"
font1 = load_font("Arial", "arial.ttf")

# Draw text using the "Arial" font with black color at position (100, 100)
draw_text("Old Theme", color_black(), font1, 24, 100, 100)

# Refresh the screen to display the text
refresh_screen()

# Pause for 2000 milliseconds (2 seconds) to display the old theme
delay(2000)

# Free all loaded fonts to reset the theme
free_all_fonts()

# Clear the screen and fill it with white color to prepare for the new theme
clear_screen(color_white())

# Load the "Verdana" font from the file "verdana.ttf"
font2 = load_font("Verdana", "verdana.ttf")

# Draw text using the "Verdana" font with blue color at position (100, 100)
draw_text("New Theme", color_blue(), font2, 24, 100, 100)

# Refresh the screen to display the updated text
refresh_screen()

# Pause for 3000 milliseconds (3 seconds) to display the new theme
delay(3000)

# Close all open windows
close_all_windows()
