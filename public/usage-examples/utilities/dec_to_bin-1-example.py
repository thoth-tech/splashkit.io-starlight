from splashkit import *

open_window("LED Bit Display", 800, 300)

# The bits come back as text, one character for each LED
display_value = 178
bits = dec_to_bin(display_value)

while not quit_requested():
    process_events()

    clear_screen(color_white())

    draw_text_no_font_no_size("Number: " + str(display_value), color_black(), 40, 40)
    draw_text_no_font_no_size("Binary: " + bits, color_black(), 40, 80)

    # A lit LED is a 1 bit and a dark LED is a 0 bit
    led_x = 80
    for bit in bits:
        if bit == "1":
            fill_circle(color_yellow(), led_x, 190, 32)
        else:
            fill_circle(color_light_gray(), led_x, 190, 32)

        draw_circle(color_black(), led_x, 190, 32)
        led_x += 90

    refresh_screen_with_target_fps(60)

close_all_windows()
