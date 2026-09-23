from splashkit import *


open_window("Interface Element Contrast", 700, 420)

element_color = rgb_color(70, 160, 220)
contrast = 0.0

while not quit_requested():
    process_events()

    # Change the interface contrast using number keys
    if key_typed(KeyCode.num_1_key):
        contrast = 0.0

    if key_typed(KeyCode.num_2_key):
        contrast = 1.0

    # Apply the selected color and contrast to the interface
    set_interface_element_color(element_color, contrast)

    clear_screen(color_white())

    draw_text_font_as_string(
        "Press 1 for minimum contrast or 2 for maximum contrast",
        color_black(),
        "Arial",
        20,
        90,
        80
    )

    draw_text_font_as_string(
        "Current contrast: " + str(contrast),
        color_black(),
        "Arial",
        20,
        240,
        130
    )

    button_at_position(
        "Interface Button",
        rectangle_from(230, 200, 240, 60)
    )

    draw_interface()
    refresh_screen_with_target_fps(60)

close_all_windows()