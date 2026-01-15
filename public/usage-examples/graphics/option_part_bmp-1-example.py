from splashkit import *

open_window("Halved Image Generator", 800, 600)

image_bitmap = load_bitmap("image_bitmap", "image1.jpg")

clear_screen(color_white())
# A bitmap is drawn with the 'option_part_bmp' function included in its drawing options
draw_bitmap_with_options(image_bitmap, 200, 155, option_part_bmp(0, 0, bitmap_width(image_bitmap) / 2, bitmap_height(image_bitmap)))
draw_text_no_font_no_size("A portion of this bitmap has been drawn", color_black(), 215, 450)
draw_text_no_font_no_size("In this example, half of the bitmap (width-wise)", color_black(), 214, 465)
refresh_screen()

delay(5000)

close_all_windows()