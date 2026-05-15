from splashkit import *

open_window("Font Has Size", 900, 650)

arial_font = load_font("arial font", "arial.ttf")
roboto_font = load_font("roboto font", "Roboto-Regular.ttf")

size1 = 16
size2 = 32
size3 = 64

arial_has_16 = font_has_size(arial_font, size1)
arial_has_32 = font_has_size(arial_font, size2)
arial_has_64 = font_has_size(arial_font, size3)

roboto_has_16 = font_has_size(roboto_font, size1)
roboto_has_32 = font_has_size(roboto_font, size2)
roboto_has_64 = font_has_size(roboto_font, size3)

arial_result_16 = "Not Available"
arial_result_32 = "Not Available"
arial_result_64 = "Not Available"

roboto_result_16 = "Not Available"
roboto_result_32 = "Not Available"
roboto_result_64 = "Not Available"

if arial_has_16:
    arial_result_16 = "Available"

if arial_has_32:
    arial_result_32 = "Available"

if arial_has_64:
    arial_result_64 = "Available"

if roboto_has_16:
    roboto_result_16 = "Available"

if roboto_has_32:
    roboto_result_32 = "Available"

if roboto_has_64:
    roboto_result_64 = "Available"

while not quit_requested():
    process_events()
    clear_screen(color_white())

    draw_text(
        "FontHasSize can be used to compare supported font sizes.",
        color_black(),
        arial_font,
        24,
        20,
        20
    )

    draw_text("Font: Arial", color_blue(), arial_font, 22, 20, 80)
    draw_text("Size 16: " + arial_result_16, color_black(), arial_font, 20, 40, 120)
    draw_text("Size 32: " + arial_result_32, color_black(), arial_font, 20, 40, 155)
    draw_text("Size 64: " + arial_result_64, color_black(), arial_font, 20, 40, 190)

    draw_text("Font: Roboto", color_red(), arial_font, 22, 20, 280)
    draw_text("Size 16: " + roboto_result_16, color_black(), arial_font, 20, 40, 320)
    draw_text("Size 32: " + roboto_result_32, color_black(), arial_font, 20, 40, 355)
    draw_text("Size 64: " + roboto_result_64, color_black(), arial_font, 20, 40, 390)

    draw_text(
        "Different fonts may support different sizes.",
        color_black(),
        arial_font,
        20,
        20,
        500
    )

    refresh_screen_with_target_fps(60)

close_all_windows()
