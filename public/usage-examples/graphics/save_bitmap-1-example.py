from splashkit import *

open_window("Save Bitmap", 800, 600)

opacity_value = 0
image_bitmap = load_bitmap("image_bitmap", "image1.jpg")

while (not quit_requested()):
    process_events()
    
    if key_typed(KeyCode.return_key):
        save_bitmap(image_bitmap, "saved_bitmap")
        opacity_value = 2500
        
    if opacity_value != 0:
        opacity_value -= 1
    
    clear_screen(color_white())
    draw_bitmap(image_bitmap, 200, 155)
    draw_text_no_font_no_size("Press the 'Enter' key to save the above bitmap to desktop", color_black(), 175, 450)
    draw_text_no_font_no_size("Image saved to desktop!", rgba_color(0, 0, 0, opacity_value), 310, 470)
    refresh_screen()
    
close_all_windows()