from splashkit import *

open_window("Interactive Font Style Changer", 800, 120)

# Load font
arial = load_font("Arial", "Arial.TTF")

# Default message
info_text = "Press N for Normal, B for Bold, I for Italics, or U for Underlined."
font_text = ""

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
    
    font_text = "Font style set to "
    style = get_font_style(arial)
    
    if style == FontStyle.normal_font:
        font_text += "Normal"
    elif style == FontStyle.bold_font:
        font_text += "Bold"
    elif style == FontStyle.italic_font:
        font_text += "Italic"
    elif style == FontStyle.underline_font:
        font_text += "Underlined"
    else:
        font_text += "Unknown"
    
    # Clear screen and draw updated message
    clear_screen_to_white()
    draw_text(info_text, color_black(), arial, 20, 50, 20)
    draw_text(font_text, color_black(), arial, 20, 50, 80)
    # Refresh the window with the updated text
    refresh_screen()  

delay(5000)
close_all_windows()