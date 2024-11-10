from splashkit import *

# Create a bitmap for our caterpillar
bitmap = create_bitmap("caterpillar", 400, 200)

# Fill background with light color
clear_bitmap(bitmap, color_white())

# Create rainbow colors
colors = [
    color_red(),
    color_orange(),
    color_yellow(),
    color_green(),
    color_blue(),
    color_violet()
]

# Draw circles for caterpillar segments with alternating y positions
x = 50
for i, color in enumerate(colors):
    y = 100 + (20 if i % 2 == 0 else -20)  # Alternate up and down
    fill_circle_on_bitmap(bitmap, color, x, y, 40)
    x += 60

# Draw eyes (adjusted to match first segment position)
fill_circle_on_bitmap(bitmap, color_black(), 60, 100, 8)
fill_circle_on_bitmap(bitmap, color_black(), 60, 130, 8)

# Save and free the bitmap
save_bitmap(bitmap, "rainbow_caterpillar")
free_bitmap(bitmap)