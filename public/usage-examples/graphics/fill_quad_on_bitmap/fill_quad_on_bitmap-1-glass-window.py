from splashkit import *

# Create a bitmap for the window
bitmap = create_bitmap("window", 400, 300)

# Fill background with white
clear_bitmap(bitmap, color_white())

# Create color
color =  rgba_color(100, 150, 255, 128)

# Size and spacing for squares
size = 80
gap = 10
start_x = 110
start_y = 60

# Draw the four Window panels
panels = [
    quad_from(
        start_x, start_y,
        start_x + size, start_y,
        start_x, start_y + size,
        start_x + size, start_y + size
    ),
    quad_from(
        start_x + size + gap, start_y,
        start_x + size*2 + gap, start_y,
        start_x + size + gap, start_y + size,
        start_x + size*2 + gap, start_y + size
    ),
    quad_from(
        start_x, start_y + size + gap,
        start_x + size, start_y + size + gap,
        start_x, start_y + size*2 + gap,
        start_x + size, start_y + size*2 + gap
    ),
    quad_from(
        start_x + size + gap, start_y + size + gap,
        start_x + size*2 + gap, start_y + size + gap,
        start_x + size + gap, start_y + size*2 + gap,
        start_x + size*2 + gap, start_y + size*2 + gap
    )
]

# Draw each panel
for panel in panels:
    fill_quad_on_bitmap(bitmap, color, panel)

# Save and free the bitmap
save_bitmap(bitmap, "glass_window")
free_bitmap(bitmap)