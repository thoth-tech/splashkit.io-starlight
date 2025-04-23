from splashkit import *

# Create and clear bitmap
triangle_bmp = create_bitmap("triangle", 618, 618)
clear_bitmap(triangle_bmp, Color.White)

# Triangle coordinates
x1, y1 = 100, 200
x2, y2 = 309, 20
x3, y3 = 520, 200

# Draw filled triangle
fill_triangle_on_bitmap(triangle_bmp, Color.Red, x1, y1, x2, y2, x3, y3)

# Display bitmap in window
open_window("Fill Triangle on Bitmap", 618, 618)
draw_bitmap(triangle_bmp, 0, 0)
refresh_screen()

delay(5000)
