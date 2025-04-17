from splashkit import *

open_window("Font Style", 800, 60)
loaded_font = load_font("Arial", "Arial.TTF")

# Initialise Default message
message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined."

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
        
    # Clear screen and draw updated message
    clear_screen_to_white()
    draw_text(message, color_black(), loaded_font, 20, 50, 20)

    # Refresh the window with the updated text
    refresh_screen()  

delay(5000)
close_all_windows()