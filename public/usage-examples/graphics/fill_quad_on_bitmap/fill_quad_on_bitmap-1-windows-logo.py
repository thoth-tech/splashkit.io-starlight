from splashkit import *

# Create a window and bitmap for the window
window = open_window("Window", 400, 300)
bitmap = create_bitmap("Bitmap", 400, 300)

# Fill background with white
clear_bitmap(bitmap, rgba_color(51, 118, 212, 255))

# Create color
color = color_white()

# Draw the four Window panels
panels = [
    quad_from(
        85, 50, 
        180, 41,  
        85, 130,    
        180, 130  
    ),
    quad_from(
        193, 40,  
        323, 26,  
        193, 130,   
        323, 130 
    ),
    quad_from(
        85, 143, 
        180, 143,  
        85, 222,   
        180, 233  
    ),
    quad_from(
        193, 143, 
        323, 143, 
        193, 235,  
        323, 250 
    )
]

# Draw each panel
for panel in panels:
    fill_quad_on_bitmap(bitmap, color, panel)

while not window_close_requested(window):
    process_events()
    # Draw the bitmap to the window
    draw_bitmap(bitmap, 0, 0)
    # Refresh the window
    refresh_screen()

free_bitmap(bitmap)