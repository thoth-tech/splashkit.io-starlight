from splashkit import *

open_window("Key Released", 800, 600)

release_count = 0
status = "Waiting..."

while not quit_requested():
    process_events()

    if key_down(KeyCode.space_key):
        status = "Holding Space..."

    # key_released returns true only once per release event
    if key_released(KeyCode.space_key):
        release_count += 1
        status = "Space released!"

    clear_screen(color_white())
    draw_text_font_as_string("Press and hold [SPACE], then release it", color_black(), "Arial", 18, 200, 220)
    draw_text_font_as_string("Status: " + status, color_dark_gray(), "Arial", 18, 200, 270)
    draw_text_font_as_string("Times released: " + str(release_count), color_blue(), "Arial", 24, 200, 320)
    refresh_screen(60)

close_all_windows()
