from splashkit import *

open_window("Option Scale Bmp", 800, 600)

image_bitmap = load_bitmap("image_bitmap", "image1.jpg")

clear_screen(color_white())
# Function used here ↓
draw_bitmap_with_options(image_bitmap, 200, 130, option_scale_bmp(1.5, 1.5))
draw_text_no_font_no_size("This bitmap has been made 50 percent larger than normal", color_black(), 180, 470)
refresh_screen()

delay(5000)

close_all_windows()