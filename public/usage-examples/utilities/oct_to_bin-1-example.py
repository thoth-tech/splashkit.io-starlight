from splashkit import *

open_window("File Permission Bits", 640, 400)

# Each octal digit of a Unix permission code is three bits: read, write and execute
permission_code = "754"
bits = oct_to_bin(permission_code)

who_names = ["Owner", "Group", "Others"]
permission_names = ["Read", "Write", "Execute"]

while not quit_requested():
    process_events()

    clear_screen(color_white())

    draw_text_no_font_no_size("Permission code: " + permission_code, color_black(), 40, 30)
    draw_text_no_font_no_size("As bits: " + bits, color_black(), 40, 60)

    for column in range(3):
        draw_text_no_font_no_size(permission_names[column], color_black(), 230 + column * 130, 115)

    for row in range(3):
        draw_text_no_font_no_size(who_names[row], color_black(), 60, 165 + row * 70)

    # 754 has no leading zero digit, so all nine bits come back
    for position in range(9):
        box_x = 200 + (position % 3) * 130
        box_y = 140 + (position // 3) * 70

        if bits[position] == "1":
            fill_rectangle(color_green(), box_x, box_y, 100, 50)
        else:
            fill_rectangle(color_light_gray(), box_x, box_y, 100, 50)

        draw_rectangle(color_black(), box_x, box_y, 100, 50)

    refresh_screen_with_target_fps(60)

close_all_windows()
