from splashkit import *

# Create a bitmap to draw on
planet = create_bitmap("planet", 400, 400)

# Fill background with dark color
clear_bitmap(planet, color_black())
    
# Create color
red = color_red()

# Draw the main planet circle
fill_circle_on_bitmap(planet, rgba_color(180, 0, 0, 255), 200, 200, 150)
draw_circle_on_bitmap(planet, color_red(), 200, 200, 150)

# Add some surface details with smaller circles
for i in range(15):
    x = rnd_range(100, 300)  # Random between 100 and 300
    y = rnd_range(100, 300)  # Random between 100 and 300
    size = rnd_range(10, 30)  # Random between 10 and 30
    draw_circle_on_bitmap(planet, red, x, y, size)

# Save and free the bitmap
save_bitmap(planet, "draw_circle_on_bitmap-1-red-planet")
free_bitmap(planet)