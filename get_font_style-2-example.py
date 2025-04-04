from splashkit import *

# Load font
open_window("Font Style", 1100, 120)
my_font = load_font("Arial", "Arial.TTF")

# Default message
message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined."

while not quit_requested():
    process_events()

    # Check key presses and update font style
    if key_typed(KeyCode.n_key):
        set_font_style(my_font, FontStyle.normal_font)
        message = f"Font style set to {get_font_style(my_font)}. Press B for Bold, I for Italics, or U for Underlined."
    elif key_typed(KeyCode.b_key):
        set_font_style(my_font, FontStyle.bold_font)
        message = f"Font style set to {get_font_style(my_font)}. Press N for Normal, I for Italics, or U for Underlined."
    elif key_typed(KeyCode.i_key):
        set_font_style(my_font, FontStyle.italic_font)
        message = f"Font style set to {get_font_style(my_font)}. Press N for Normal, B for Bold, or U for Underlined."
    elif key_typed(KeyCode.u_key):
        set_font_style(my_font, FontStyle.underline_font)
        message = f"Font style set to {get_font_style(my_font)}. Press N for Normal, B for Bold, or I for Italics."

    # Clear screen and draw updated message
    clear_screen_to_white()
    draw_text(message, color_black(), my_font, 20, 50, 20)
    # Refresh the window with the updated text
    refresh_screen()  

delay(5000)
close_all_windows()