from splashkit import *

open_window("Font Style", 800, 120)

# Load font
loaded_font = load_font("Arial", "Arial.TTF")

# Default message
message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined."
message1 = ""

while not quit_requested():
    process_events()

    # Check key presses and update font style
    if key_typed(KeyCode.n_key):
        set_font_style(loaded_font, FontStyle.normal_font)
    elif key_typed(KeyCode.b_key):
        set_font_style(loaded_font, FontStyle.bold_font)
    elif key_typed(KeyCode.i_key):
        set_font_style(loaded_font, FontStyle.italic_font)
    elif key_typed(KeyCode.u_key):
        set_font_style(loaded_font, FontStyle.underline_font)
    
    message1 = f"Font style set to {get_font_style_name_as_string("Arial")}"
        
    # Clear screen and draw updated message
    clear_screen_to_white()
    draw_text(message, color_black(), loaded_font, 20, 50, 20)
    draw_text(message1, color_black(), loaded_font, 20, 50, 80)
    # Refresh the window with the updated text
    refresh_screen()  

delay(5000)
close_all_windows()