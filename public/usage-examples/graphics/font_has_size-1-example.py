from splashkit import *

def availability_text(available):
    if available:
        return "Available"

    return "Not Available"


open_window("Font Size Checker", 900, 650)

arial_font = load_font("arial font", "arial.ttf")

unused_size = 16
checked_size = 32

before_16 = font_has_size(arial_font, unused_size)
before_32 = font_has_size(arial_font, checked_size)

while not quit_requested():
    process_events()
    clear_screen(color_white())

    draw_text(
        "font_has_size checks if a font has already been loaded at a selected size.",
        color_black(),
        arial_font,
        24,
        20,
        20
    )

    draw_text(
        "Before using Arial at size 32:",
        color_blue(),
        arial_font,
        20,
        20,
        90
    )

    draw_text(
        "Size 16: " + availability_text(before_16),
        color_black(),
        arial_font,
        20,
        40,
        130
    )

    draw_text(
        "Size 32: " + availability_text(before_32),
        color_black(),
        arial_font,
        20,
        40,
        165
    )

    draw_text(
        "This line is drawn using Arial at size 32.",
        color_red(),
        arial_font,
        checked_size,
        20,
        250
    )

    after_16 = font_has_size(arial_font, unused_size)
    after_32 = font_has_size(arial_font, checked_size)

    draw_text(
        "After drawing text using Arial at size 32:",
        color_blue(),
        arial_font,
        20,
        20,
        340
    )

    draw_text(
        "Size 16: " + availability_text(after_16),
        color_black(),
        arial_font,
        20,
        40,
        380
    )

    draw_text(
        "Size 32: " + availability_text(after_32),
        color_black(),
        arial_font,
        20,
        40,
        415
    )

    draw_text(
        "The size used for drawing becomes available, while the unused size remains unavailable.",
        color_black(),
        arial_font,
        20,
        20,
        520
    )

    refresh_screen_with_target_fps(60)

close_all_windows()
