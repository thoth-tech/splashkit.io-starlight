from splashkit import *

open_window("Inset Rectangle Example", 400, 300)

# The fixed outer rectangle
outer_rect = rectangle_from(50, 50, 300, 200)

inset_amount = 0

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Increase or decrease the inset amount with the arrow keys
    if key_down(KeyCode.up_key) and inset_amount < 95:
        inset_amount += 1
    if key_down(KeyCode.down_key) and inset_amount > 0:
        inset_amount -= 1

    # Draw the outer rectangle
    draw_rectangle_record(color_black(), outer_rect)

    # Get and draw the inset rectangle
    inner_rect = inset_rectangle(outer_rect, inset_amount)
    fill_rectangle_record(color_red(), inner_rect)

    # Display the current inset amount, fixed to the screen
    draw_text_no_font_no_size_with_options("Inset amount: " + to_string_from_int(int(inset_amount)), color_black(), 10, 10, option_to_screen())

    refresh_screen_with_target_fps(60)

close_all_windows()