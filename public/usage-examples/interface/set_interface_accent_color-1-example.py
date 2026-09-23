from splashkit import *


open_window("Interface Accent Contrast", 700, 420)

accent_color = rgb_color(230, 80, 120)
contrast = 0.0

while not quit_requested():
    process_events()

    # Change the interface accent contrast using number keys
    if key_typed(KeyCode.num_1_key):
        contrast = 0.0

    if key_typed(KeyCode.num_2_key):
        contrast = 1.0

    # Apply the selected accent color and contrast to the interface
    set_interface_accent_color(accent_color, contrast)

    clear_screen(color_white())

    draw_text_font_as_string(
        "Press 1 for minimum accent or 2 for maximum accent",
        color_black(),
        "Arial",
        20,
        90,
        70
    )

    draw_text_font_as_string(
        "Hover over the button to see the accent effect",
        color_black(),
        "Arial",
        20,
        120,
        110
    )

    draw_text_font_as_string(
        "Current contrast: " + str(contrast),
        color_black(),
        "Arial",
        20,
        240,
        150
    )

    button_at_position(
        "Hover Over Me",
        rectangle_from(230, 220, 240, 60)
    )

    draw_interface()
    refresh_screen_with_target_fps(60)

close_all_windows()