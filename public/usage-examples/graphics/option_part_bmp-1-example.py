from splashkit import *

open_window("Option Part Bmp", 800, 600)

image_bitmap = load_bitmap("image_bitmap", "image1.jpg")

clear_screen(color_white())
# Function used here ↓
draw_bitmap_with_options(image_bitmap, 200, 155, option_part_bmp(0, 0, 200, 249))
draw_text_no_font_no_size("A portion of this bitmap has been drawn", color_black(), 215, 450)
draw_text_no_font_no_size("In this case, exactly half of it width-wise", color_black(), 214, 465)
refresh_screen()

delay(5000)

close_all_windows()