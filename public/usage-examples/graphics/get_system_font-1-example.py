from splashkit import *

open_window("Get System Font", 800, 600)

# The get system font function writes a font to this variable. If it is unable to find one, it won't write anything and the variable will remain blank
font = get_system_font()

while (not quit_requested()):
    process_events()
    clear_screen_to_white()
    if font is not None:
        draw_text_no_font_no_size("System font detected!", color_black(), 300, 100)
        
        # This line uses draw_text to give an example using this font
        draw_text("The quick brown fox jumps over the lazy dog", color_black(), font, 30, 50, 150)
    else:
        draw_text_no_font_no_size("No system font detected!", color_black(), 300, 100)

    refresh_screen()

close_all_windows()