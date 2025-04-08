from splashkit import *

# Open a window
open_window("Pop Clip", 400, 400)

# Set clip to the right half of the window
set_clip(200, 200, 200, 200)

# Draw a red square inside the clipped region
fill_rectangle(Color.RED, 200, 200, 100, 100)

# Remove the clip so we can draw anywhere again
pop_clip()

# Draw a green square outside the previous clip
fill_rectangle(Color.GREEN, 100, 150, 100, 100)

# Show everything on screen
refresh_screen()

# Pause to view the result
delay(5000)




