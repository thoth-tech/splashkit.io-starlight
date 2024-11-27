from splashkit import *
import random

# Create a Window and bitmap for the map
window = open_window("Rectangle on Bitmap", 400, 400)
bricks = create_bitmap("bricks", 400, 400)

# Fill background with dark color
clear_bitmap(bricks, color_gray())

# Draw brick pattern
for y in range(0, 400, 50):  # Each brick row
    for x in range(0, 400, 50):
        
        if (y // 50) % 2 == 0:
            x_offset = 0
        else:
            x_offset = 25
            
        draw_rectangle(bricks, x + x_offset, y, 50, 25)

# Add random colored rectangles on the bitmap
for i in range(15):
    x = rnd(50, 350)
    y = rnd(50, 350)
    width = rnd(20, 50)
    height = rnd(20, 50)
    
    random_color = rgb_color(
        random.randint(0, 255), random.randint(0, 255), random.randint(0, 255)
    )
    
    draw_rectangle_on_bitmap(bricks, random_color, x, y, width, height)

# Game loop
while not window_close_requested(window):
    process_events()
    # Draw the bitmap to the window
    draw_bitmap(bricks, 0, 0)
    # Refresh the window
    refresh_screen()

# Free the bitmap memory
free_bitmap(bricks)
