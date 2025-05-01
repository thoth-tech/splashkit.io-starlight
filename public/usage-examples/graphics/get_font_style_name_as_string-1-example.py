from splashkit import *

open_window("Font Style", 800, 120)

# Load font
# Unlike C++/C#, Python SplashKit requires using the loaded font object directly.
# Using the font name string like "Arial" will result in invalid font errors.
# To fix this, we load the font and keep a reference to the font object (e.g., `loaded_font`)
loaded_font = load_font("Arial", "Arial.TTF")

# Default message
InitialText = "Press N for Normal, B for Bold, I for Italics, or U for Underlined."
FontText = ""


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
    
    FontText = "Font style set to "
    style = get_font_style(loaded_font)
    if style == FontStyle.normal_font:
        FontText += "Normal"
    elif style == FontStyle.bold_font:
        FontText += "Bold"
    elif style == FontStyle.italic_font:
        FontText += "Italic"
    elif style == FontStyle.underline_font:
        FontText += "Underlined"
    else:
        FontText += "Unknown"
    
    # Clear screen and draw updated message
    clear_screen_to_white()
    draw_text(InitialText, color_black(), loaded_font, 20, 50, 20)
    draw_text(FontText, color_black(), loaded_font, 20, 50, 80)
    # Refresh the window with the updated text
    refresh_screen()  

delay(5000)
close_all_windows()