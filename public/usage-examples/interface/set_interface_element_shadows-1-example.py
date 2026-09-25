from splashkit import *


open_window("Interface Element Shadows", 700, 420)

shadow_radius = 3
shadow_offset = point_at(3, 3)
shadow_color = rgba_color(0, 0, 0, 140)
shadow_style = "Small shadow"

while not quit_requested():
    process_events()

    # Change the interface shadow using number keys
    if key_typed(KeyCode.num_1_key):
        shadow_radius = 3
        shadow_offset = point_at(3, 3)
        shadow_style = "Small shadow"

    if key_typed(KeyCode.num_2_key):
        shadow_radius = 15
        shadow_offset = point_at(15, 15)
        shadow_style = "Large shadow"

    # Apply the selected shadow style to interface elements
    set_interface_element_shadows(
        shadow_radius,
        shadow_color,
        shadow_offset
    )

    clear_screen(color_white())

    draw_text_font_as_string(
        "Press 1 for small shadow or 2 for large shadow",
        color_black(),
        "Arial",
        20,
        130,
        80
    )

    draw_text_font_as_string(
        "Current style: " + shadow_style,
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