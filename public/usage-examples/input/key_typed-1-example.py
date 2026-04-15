from splashkit import *

open_window("Typed Key Counter", 800, 600)

a_count = 0
space_count = 0
enter_count = 0
last_typed_key = "None"

while not quit_requested():
    process_events()

    # Count each key once when it is first pressed.
    if key_typed(KeyCode.a_key):
        a_count += 1
        last_typed_key = "A"

    if key_typed(KeyCode.space_key):
        space_count += 1
        last_typed_key = "Space"

    if key_typed(KeyCode.return_key):
        enter_count += 1
        last_typed_key = "Enter"

    clear_screen(color_white())

    draw_text_no_font_no_size("Press A, Space, or Enter.", color_black(), 20, 20)
    draw_text_no_font_no_size("Hold a key down and the count only changes once.", color_black(), 20, 50)
    draw_text_no_font_no_size("Last typed key: " + last_typed_key, color_black(), 20, 100)
    draw_text_no_font_no_size("A count: " + str(a_count), color_black(), 20, 150)
    draw_text_no_font_no_size("Space count: " + str(space_count), color_black(), 20, 190)
    draw_text_no_font_no_size("Enter count: " + str(enter_count), color_black(), 20, 230)

    refresh_screen_with_target_fps(60)