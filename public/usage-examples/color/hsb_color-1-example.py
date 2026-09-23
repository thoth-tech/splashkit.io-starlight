from splashkit import *

open_window("HSB Color", 800, 600)

hue = 0.0
saturation = 1.0
brightness = 1.0

while not quit_requested():
    process_events()

    # Use the keyboard to adjust the HSB values.
    if key_down(KeyCode.left_key):
        hue -= 0.005

    if key_down(KeyCode.right_key):
        hue += 0.005

    if key_down(KeyCode.down_key):
        saturation -= 0.005

    if key_down(KeyCode.up_key):
        saturation += 0.005

    if key_down(KeyCode.s_key):
        brightness -= 0.005

    if key_down(KeyCode.w_key):
        brightness += 0.005

    # Keep each HSB value between 0 and 1.
    hue = max(0.0, min(1.0, hue))
    saturation = max(0.0, min(1.0, saturation))
    brightness = max(0.0, min(1.0, brightness))

    # Create a color from the current HSB values.
    selected_color = hsb_color(
        hue,
        saturation,
        brightness
    )

    # Draw the selected color and its current values.
    clear_screen(color_black())

    fill_rectangle(
        selected_color,
        250,
        120,
        300,
        260
    )

    draw_text_no_font_no_size(
        f"Hue: {hue:.2f}",
        color_white(),
        40,
        430
    )

    draw_text_no_font_no_size(
        f"Saturation: {saturation:.2f}",
        color_white(),
        40,
        460
    )

    draw_text_no_font_no_size(
        f"Brightness: {brightness:.2f}",
        color_white(),
        40,
        490
    )

    draw_text_no_font_no_size(
        "Left/Right: Hue   Up/Down: Saturation   W/S: Brightness",
        color_white(),
        40,
        530
    )

    refresh_screen_with_target_fps(60)

close_all_windows()