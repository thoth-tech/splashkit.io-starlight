from splashkit import *

open_window("Checkbox Example", 700, 500)

show_grid = False
sound_enabled = True
dark_background = False

panel_area = rectangle_from(40, 90, 280, 150)
positioned_checkbox = rectangle_from(380, 120, 220, 40)

while not quit_requested():
    process_events()

    if dark_background:
        clear_screen(color_dark_slate_gray())
    else:
        clear_screen(color_white())

    text_color = color_white() if dark_background else color_black()

    if show_grid:
        for x in range(0, 700, 50):
            draw_line(color_light_gray(), x, 0, x, 500)

        for y in range(0, 500, 50):
            draw_line(color_light_gray(), 0, y, 700, y)

    draw_text_no_font_no_size(
        "SplashKit Checkbox Example",
        text_color,
        40,
        35
    )

    if start_panel("Options", panel_area):
        show_grid = checkbox(
            "Show Grid",
            show_grid
        )

        sound_enabled = checkbox_labeled(
            "Sound",
            "Enabled",
            sound_enabled
        )

        end_panel("Options")

    dark_background = checkbox_at_position(
        "Dark Background",
        dark_background,
        positioned_checkbox
    )

    draw_text_no_font_no_size(
        "Try clicking each checkbox",
        text_color,
        380,
        190
    )

    draw_interface()
    refresh_screen()