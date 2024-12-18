from splashkit import *


window = open_window("Reset Clip", 800, 600)

# Define the clipping area
r = rectangle_from(100, 100, 600, 400)

# Set the clipping area
set_clip(r)
    

# Draw a blue rectangle inside the clipping area
fill_rectangle(color_blue(), 50, 50, 700, 500)
refresh_screen() # Refresh screen to apply the drawing
delay(1000)

# Draw a red rectangle outside the clipping area (it will not be clipped)
set_clip(r)

# Draw a red rectangle outside the clipping area
fill_rectangle(color_red(), 100, 100, 200, 200)
refresh_screen() #Refresh screen to show the changes
delay(1000)  

# Remove the clipping area to allow full window drawing
reset_clip()

# Clear screen and set a new background color (green)
clear_screen(color_green())

# Refresh screen to apply the changes
refresh_screen()
delay(5000)

# Close all windows
close_all_windows()
