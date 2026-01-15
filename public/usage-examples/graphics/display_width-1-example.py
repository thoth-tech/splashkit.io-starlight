from splashkit import *

# Get display width
width = display_width(display_details(0))

# Open window with same width of display
open_window("Display Width Exmaple", width, 100)
clear_screen(color_black())

# Write on window the display width
draw_text_no_font_no_size(f"Display Width: {width}",color_white(),width/2,50)
refresh_screen()
while not quit_requested():
     process_events()