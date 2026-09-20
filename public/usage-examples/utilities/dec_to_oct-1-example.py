from splashkit import *

open_window("Octal Receipt Codes", 700, 360)

# Each order number is printed on its receipt as a short octal code
order_numbers = [8, 64, 500, 4095]

while not quit_requested():
    process_events()

    clear_screen(color_white())

    draw_text_no_font_no_size("Order number", color_black(), 60, 40)
    draw_text_no_font_no_size("Receipt code (octal)", color_black(), 300, 40)
    draw_line(color_black(), 40, 70, 660, 70)

    for row in range(len(order_numbers)):
        receipt_code = dec_to_oct(order_numbers[row])
        row_y = 100 + row * 50

        draw_text_no_font_no_size(str(order_numbers[row]), color_black(), 60, row_y)
        draw_text_no_font_no_size(receipt_code, color_blue(), 300, row_y)

    refresh_screen_with_target_fps(60)

close_all_windows()
