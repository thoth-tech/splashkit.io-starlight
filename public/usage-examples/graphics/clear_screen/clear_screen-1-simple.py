from splashkit import *

# Open new window with title and dimensions
open_window("Blue Background", 800, 600)

# Use Clear Screen to change the background color to blue 
clear_screen(color_blue())
refresh_screen()
delay(4000)

# Close loaded windows 
close_all_windows()
