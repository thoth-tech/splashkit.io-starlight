from splashkit import *

open_window("System Font Retriever and Displayer", 800, 600)

# Set the font variable to the system's default font if available
font = get_system_font()

while not quit_requested():
    process_events()
    clear_screen_to_white()
    
    if font is not None:
        draw_text_no_font_no_size("System font detected!", color_black(), 300, 100)

        # Display some sample text to demonstrate the selected font
        draw_text("The quick brown fox jumps over the lazy dog", color_black(), font, 30, 50, 150)
    else:
        draw_text_no_font_no_size("No system font detected!", color_black(), 300, 100)

    refresh_screen()

close_all_windows()