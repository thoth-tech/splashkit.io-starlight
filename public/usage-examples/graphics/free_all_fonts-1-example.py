from splashkit import *

# Open a window
window = open_window("Free All Fonts Example", 900, 600)

# Load fonts from resource bundle
load_resource_bundle("bundles", "Font.txt")

# Draw using FontA and FontB
clear_screen(color_white())
draw_text("This is Font A (Montserrat Black)", color_black(), "FontA", 32, 100, 100)
draw_text("This is Font B (Montserrat Thin)", color_black(), "FontB", 32, 100, 150)
refresh_screen_with_target_fps(60)
delay(2000)

# Free all fonts
free_all_fonts()

# Load FontC directly
load_font("FontC", "OpenSans_Condensed-Bold.ttf")

clear_screen(color_white())
draw_text("Fonts A and B were freed.", color_red(), "FontC", 32, 100, 250)
draw_text("Now using Font C (OpenSans Condensed Bold)", color_red(), "FontC", 32, 100, 300)
refresh_screen_with_target_fps(60)
delay(2000)

# Close the window
close_window(window)
