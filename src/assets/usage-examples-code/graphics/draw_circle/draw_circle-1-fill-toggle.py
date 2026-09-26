# pyright: reportMissingImports=false, reportUndefinedVariable=false
from splashkit import *
from splashkit import KeyCode
from math import sin

window_width, window_height = 720, 405
open_window("Circle — fill / color / pulse", window_width, window_height)

center_x = window_width // 2
center_y = window_height // 2
base_radius = 80.0

palette = [
    rgb_color(100, 149, 237),
    rgb_color(255, 140, 0),
    rgb_color(46, 204, 113),
    rgb_color(155, 89, 182),
    rgb_color(241, 196, 15),
]
color_index = 0
is_filled = False
is_pulsing = False
time_value = 0.0

font_ok = False
try:
    ui_font = load_font("Demo", "arial.ttf")
    font_ok = True
except Exception:
    ui_font = None

while not quit_requested():
    process_events()
    if key_typed(KeyCode.escape_key): break
    if key_typed(KeyCode.space_key):  is_filled = not is_filled
    if key_typed(KeyCode.c_key):      color_index = (color_index + 1) % len(palette)
    if key_typed(KeyCode.p_key):      is_pulsing = not is_pulsing

    clear_screen(color_white())

    radius = base_radius
    if is_pulsing:
        radius = base_radius + 12.0 * sin(time_value)
        time_value += 0.07

    circle_color = palette[color_index]
    if is_filled:
        fill_circle(circle_color, center_x, center_y, radius)
        draw_circle(color_black(), center_x, center_y, radius)  # subtle outline
    else:
        draw_circle(circle_color, center_x, center_y, radius)

    if font_ok:
        draw_text("SPACE: fill   C: color   P: pulse   ESC: quit", color_navy(), ui_font, 16, 16, 16)
        draw_text("Mode: filled" if is_filled else "Mode: outline", color_black(), ui_font, 16, 16, 40)

    refresh_screen()
    delay(16)

close_all_windows()