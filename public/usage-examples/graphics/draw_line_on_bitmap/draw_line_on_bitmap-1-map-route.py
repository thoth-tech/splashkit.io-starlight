from splashkit import *

# Create a bitmap for the map
bitmap = create_bitmap("map", 400, 300)

# Fill background with light beige for map background
clear_bitmap(bitmap, color_white())

draw_line_on_bitmap(bitmap, color_green(), 
                   100, 80,    # Starting point (x1, y1)
                   300, 220)   # End point (x2, y2)

# Add points at start and end
fill_circle_on_bitmap(bitmap, color_red(), 100, 80, 5)    # Start point
fill_circle_on_bitmap(bitmap, color_red(), 300, 220, 5)   # End point

# Save and free the bitmap
save_bitmap(bitmap, "map_route")
free_bitmap(bitmap)