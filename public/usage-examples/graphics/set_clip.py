from splashkit import *

open_window("House Drawing with Clipping", 800, 600)

# Define the clipping rectangle
clip_rect = rectangle_from(250, 200, 300, 300)
set_clip(clip_rect)

# Optional: Clear only inside clipping area
clear_screen(Color.dark_orange)

# House body
fill_rectangle(Color.beige, 300, 250, 200, 200)

# Roof
draw_line(Color.brown, 300, 250, 400, 150)
draw_line(Color.brown, 400, 150, 500, 250)
draw_line(Color.brown, 300, 250, 500, 250)

# Door
fill_rectangle(Color.dark_red, 375, 370, 50, 80)

# Windows
fill_rectangle(Color.light_blue, 320, 270, 40, 40)
fill_rectangle(Color.light_blue, 440, 270, 40, 40)

# Draw clipping boundary
draw_rectangle(Color.black, clip_rect)

refresh_screen()
delay(5000)
