from splashkit import *

open_window("Image Flipping Simulator", 800, 600)

opacity_value = 255
displayed_text = "This bitmap is not flipped along it's X and Y axes"
flipped = False
image_bitmap = load_bitmap("image_bitmap", "image1.jpg")

while (not quit_requested()):
    process_events()
    
    if button_at_position("Click to invert XY axis", rectangle_from(320, 450, 160, 30)) and flipped == False:
        opacity_value = 0
        displayed_text = "This bitmap has been flipped along it's X and Y axes"
        flipped = True
    elif button_at_position("Click to invert XY axis", rectangle_from(320, 450, 160, 30)) and flipped == True:
        opacity_value = 0
        displayed_text = "This bitmap is not flipped along it's X and Y axes"
        flipped = False

    if opacity_value != 255:
        opacity_value += 1
    
    clear_screen(color_white())
    
    if flipped == False:
        draw_bitmap(image_bitmap, 200, 155)
    else:
        draw_bitmap_with_options(image_bitmap, 200, 155, option_flip_xy())
    
    draw_text_no_font_no_size(displayed_text, rgba_color(0, 0, 0, opacity_value), 200, 100)
    draw_interface()
    refresh_screen()
    
close_all_windows()