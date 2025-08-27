from splashkit import *

open_window("Option Flip Y", 800, 600)

image_bitmap = load_bitmap("image_bitmap", "image1.jpg")

clear_screen(color_white())
# Function used here ↓
draw_bitmap_with_options(image_bitmap, 200, 155, option_flip_y())
draw_text_no_font_no_size("This bitmap has been flipped along it's Y axis", color_black(), 215, 450)
refresh_screen()

delay(5000)

close_all_windows()