from splashkit import *

open_window("Take Screenshot", 800, 600)

rotation = 0
opacity_value = 0
rand_color_counter = 0
rand_color = random_color()
image_bitmap = load_bitmap("image_bitmap", "image1.jpg")

while (not quit_requested()):
    rotation += 0.01
    rand_color_counter += 1

    if opacity_value != 0:
        opacity_value -= 1
    
    if rand_color_counter >= 3000:
        rand_color = random_color()
        rand_color_counter = 0
        
    process_events()
    
    if key_typed(KeyCode.return_key):
        # Function used here ↓
        take_screenshot("saved_screenshot")
        opacity_value = 2500
    
    clear_screen(color_white())
    fill_rectangle_record(rand_color, rectangle_from(450, 200, 150, 150))
    draw_bitmap_with_options(image_bitmap, 100, 100, option_rotate_bmp(rotation))
    draw_text_no_font_no_size("Press the 'Enter' key to take a screenshot of the game window", color_black(), 175, 450)
    draw_text_no_font_no_size("Image saved to desktop!", rgba_color(0, 0, 0, opacity_value), 310, 470)
    refresh_screen()
    
close_all_windows()