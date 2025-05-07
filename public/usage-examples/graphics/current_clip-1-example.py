from splashkit import *

open_window("Current Clip Example", 400, 400)

#Clip the window to a 200×200 region at (100,100)
set_clip(rectangle_from(100, 100, 200, 200))

#Fill that region with red (with a rectangle)
fill_rectangle(Color.RED, 100, 100, 200, 200)

#Retrieve the clip bounds
clip = current_clip()

#Exit out of the clip
pop_clip()

#Outline the old clip in green as a rectangle
draw_rectangle(Color.GREEN,clip.x, clip.y, clip.width, clip.height)

refresh_screen()
delay(5000)

