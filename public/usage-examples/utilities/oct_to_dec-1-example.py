from splashkit import *

open_window("Octal Value Bars", 800, 360)

octal_values = ["7", "17", "377", "777"]

while not quit_requested():
    process_events()

    clear_screen(color_white())

    draw_text_no_font_no_size("Each bar is as long as the decimal value of its octal number.", color_black(), 40, 30)

    for row in range(len(octal_values)):
        # The result is a number, so it is turned back into text to draw it
        decimal_value = oct_to_dec(octal_values[row])
        row_y = 90 + row * 60

        draw_text_no_font_no_size("Octal " + octal_values[row], color_black(), 40, row_y + 8)
        fill_rectangle(color_blue(), 200, row_y, decimal_value, 30)
        draw_text_no_font_no_size(str(decimal_value), color_black(), 210 + decimal_value, row_y + 8)

    refresh_screen_with_target_fps(60)

close_all_windows()
