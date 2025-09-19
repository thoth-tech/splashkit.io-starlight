from splashkit import *

open_window("Option Rotate Bmp", 800, 600)

image_bitmap = load_bitmap("image_bitmap", "image1.jpg")
bitmap_rotation = 10

clear_screen(color_white())
draw_bitmap_with_options(image_bitmap, 200, 130, option_rotate_bmp(bitmap_rotation))
draw_text_no_font_no_size("This bitmap has been rotated by " + str(bitmap_rotation) + " degrees", color_black(), 215, 450)
refresh_screen()

delay(5000)

close_all_windows()