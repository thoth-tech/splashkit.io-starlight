from splashkit import *

image_bitmap = load_bitmap("image_bitmap", "image1.jpg")

program_window = open_window("Bitmap Width", bitmap_width(image_bitmap) + 200, bitmap_height(image_bitmap) + 200)

clear_screen(color_white())
draw_bitmap(image_bitmap, (window_width(program_window) - bitmap_width(image_bitmap)) / 2, (window_height(program_window) - bitmap_height(image_bitmap)) / 2)
draw_text_no_font_no_size(f"The above bitmap is {bitmap_width(image_bitmap):.0f} pixels in width", color_black(), (window_width(program_window) - bitmap_width(image_bitmap)) / 2, window_height(program_window) - 70);

refresh_screen()

delay(5000)

close_all_windows()