from splashkit import *

# Create Window
open_window("random bitmap point", 600, 600)
bmp = create_bitmap("random quads",600,600)

#  create quad using random points on bitmap
q = quad_from_points(
    random_bitmap_point(bmp),
    random_bitmap_point(bmp),
    random_bitmap_point(bmp),
    random_bitmap_point(bmp))
draw_quad_on_bitmap(bmp, color_black(), q)

clear_screen(color_white_smoke())

# Draw the bitmap
draw_bitmap(bmp, 0,0)

refresh_screen()
delay(5000)
close_all_windows()