from splashkit import *

# Create a bitmap for the mountain scene
bitmap = create_bitmap("mountain", 400, 300)

# Fill background with light color
clear_bitmap(bitmap, color_white())

# Draw right peak (smallest)
draw_triangle_on_bitmap(bitmap, color_gray(), 
                       175, 250,   # Left base
                       275, 175,   # Peak
                       375, 250)   # Right base

# Draw left peak (medium)
draw_triangle_on_bitmap(bitmap, color_gray(),
                       25, 250,    # Left base
                       125, 125,   # Peak
                       225, 250)   # Right base

# Draw center peak (tallest)
draw_triangle_on_bitmap(bitmap, color_gray(),
                       100, 250,   # Left base
                       200, 100,    # Peak
                       300, 250)   # Right base

# Save and free the bitmap
save_bitmap(bitmap, "mountain_peaks")
free_bitmap(bitmap)