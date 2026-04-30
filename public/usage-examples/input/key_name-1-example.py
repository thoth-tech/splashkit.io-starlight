from splashkit import *

open_window("Key Name", 800, 600)

# Store the last key typed from this example's set of demo keys
last_key = KeyCode.unknown_key

while (not quit_requested()):
    process_events()

    # Check which demo key was typed and save its key code
    if (key_typed(KeyCode.a_key)): last_key = KeyCode.a_key
    if (key_typed(KeyCode.num_1_key)): last_key = KeyCode.num_1_key
    if (key_typed(KeyCode.space_key)): last_key = KeyCode.space_key
    if (key_typed(KeyCode.left_key)): last_key = KeyCode.left_key
    if (key_typed(KeyCode.return_key)): last_key = KeyCode.return_key

    # Draw the instructions and the readable name of the last key
    clear_screen(color_white())
    draw_text_no_font_no_size("Press A, 1, Space, Left, or Enter", color_black(), 150, 220)
    draw_text_no_font_no_size("Last key: " + key_name(last_key), color_blue(), 280, 300)
    refresh_screen()

close_all_windows()
