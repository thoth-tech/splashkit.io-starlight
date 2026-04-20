from splashkit import *

open_window("Bitmap Height", 800, 600)

image_bitmap = load_bitmap("image_bitmap", "image1.jpg");

clear_screen(color_white())
draw_bitmap(image_bitmap, 200, 155)
draw_text_no_font_no_size(f"The above bitmap is {bitmap_height(image_bitmap):.0f} pixels in height", color_black(), 215, 450)

refresh_screen()

delay(5000)

close_all_windows()