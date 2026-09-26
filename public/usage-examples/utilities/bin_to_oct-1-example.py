from splashkit import *

open_window("Bit Groups to Octal", 800, 360)

bits = "101110011"

while not quit_requested():
    process_events()

    clear_screen(color_white())

    octal_code = ""

    for group in range(3):
        # Every group of three bits is exactly one octal digit
        group_bits = bits[group * 3:group * 3 + 3]
        octal_digit = bin_to_oct(group_bits)
        octal_code += octal_digit

        group_x = 80 + group * 240
        fill_rectangle(color_light_blue(), group_x, 120, 160, 150)
        draw_rectangle(color_black(), group_x, 120, 160, 150)
        draw_text_no_font_no_size(group_bits, color_black(), group_x + 68, 150)
        draw_text_no_font_no_size(octal_digit, color_blue(), group_x + 76, 220)

    draw_text_no_font_no_size("Binary: " + bits, color_black(), 40, 40)
    draw_text_no_font_no_size("Octal: " + octal_code, color_black(), 40, 75)

    refresh_screen_with_target_fps(60)

close_all_windows()
