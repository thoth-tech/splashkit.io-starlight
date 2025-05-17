from splashkit import *

open_window("Font Style Changer", 800, 120)

# Load font
arial = load_font("Arial", "Arial.TTF")

# Default message
instructions = "Press N for Normal, B for Bold, I for Italics, or U for Underlined."

while not quit_requested():
    process_events()

    # Check key presses and update font style
    if key_typed(KeyCode.n_key):
        set_font_style(arial, FontStyle.normal_font)
    elif key_typed(KeyCode.b_key):
        set_font_style(arial, FontStyle.bold_font)
    elif key_typed(KeyCode.i_key):
        set_font_style(arial, FontStyle.italic_font)
    elif key_typed(KeyCode.u_key):
        set_font_style(arial, FontStyle.underline_font)
    

    # Clear screen and draw updated message
    clear_screen_to_white()
    draw_text(instructions, color_black(), arial, 20, 50, 20)
    refresh_screen()  

delay(5000)
close_all_windows()