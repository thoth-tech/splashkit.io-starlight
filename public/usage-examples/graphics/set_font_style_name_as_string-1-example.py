from splashkit import *

open_window("Font Style", 800, 60)
# Load Font
load_font("Arial", "Arial.TTF")

# Default instructions
instructions = "Press N for Normal, B for Bold, I for Italics, or U for Underlined."

while not quit_requested():
    process_events()

    # Check key presses and update font style
    if key_typed(KeyCode.n_key):
        set_font_style_name_as_string("Arial", FontStyle.normal_font)
    elif key_typed(KeyCode.b_key):
        set_font_style_name_as_string("Arial", FontStyle.bold_font)
    elif key_typed(KeyCode.i_key):
        set_font_style_name_as_string("Arial", FontStyle.italic_font)
    elif key_typed(KeyCode.u_key):
        set_font_style_name_as_string("Arial", FontStyle.underline_font)
        
    # Clear screen and draw updated instructions
    clear_screen_to_white()
    draw_text(instructions, color_black(), font_named("Arial"), 20, 50, 20)

    # Refresh the window with the updated text
    refresh_screen()  

delay(5000)
close_all_windows()