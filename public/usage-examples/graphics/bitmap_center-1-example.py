from splashkit import *

open_window("Bitmap Center", 800, 600)

image_bitmap = load_bitmap("image_bitmap", "image1.jpg");

clear_screen(color_white())
draw_bitmap(image_bitmap, 0, 0)
fill_circle_record(color_red(), circle_at(bitmap_center(image_bitmap), 5))
refresh_screen()

delay(5000)

close_all_windows()