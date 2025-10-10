# I am scaling a bitmap at draw time with option_scale_bmp.
# I am pressing A to make smaller; I am pressing D to make bigger; I am pressing R to reset;
# I am pressing SPACE to toggle outline; I am pressing ESC to quit.

from splashkit import *
from splashkit import KeyCode

# I am opening the window with a short title; I am drawing instructions inside the window.
open_window("Option Scale Bmp - live", 800, 480)

def make_sticker_bitmap() -> bitmap:
    # I am creating a small procedural bitmap so no external file is needed.
    sticker_width, sticker_height = 128, 128
    bmp = create_bitmap("sticker", sticker_width, sticker_height)
    clear_bitmap(bmp, rgba_color(255, 255, 255, 0))  # I am making the background transparent.

    # I am drawing a light grid to show scale changes.
    for y in range(0, sticker_height, 16):
        draw_line_on_bitmap(bmp, rgb_color(220, 220, 220), 0, y, sticker_width, y)
    for x in range(0, sticker_width, 16):
        draw_line_on_bitmap(bmp, rgb_color(220, 220, 220), x, 0, x, sticker_height)

    # I am drawing a circle and a border so the sticker is easy to see.
    fill_circle_on_bitmap(bmp, rgb_color(33, 150, 243), sticker_width // 2, sticker_height // 2, 36)
    draw_circle_on_bitmap(bmp, rgb_color(0, 0, 0), sticker_width // 2, sticker_height // 2, 36)
    draw_rectangle_on_bitmap(bmp, rgb_color(0, 0, 0), 1, 1, sticker_width - 2, sticker_height - 2)
    return bmp

# I am building the sticker once and I am reusing it each frame.
sticker_bitmap = make_sticker_bitmap()

# I am tracking the current scale and the valid range.
current_scale = 1.0
scale_step = 0.1
min_scale = 0.2
max_scale = 3.0

# I am toggling an outline so the scaled bounds are obvious.
show_outline = True

# I am centering my drawing around the window middle.
center_x = 800 / 2.0
center_y = 480 / 2.0

while not quit_requested():
    process_events()

    # I am handling the controls.
    if key_typed(KeyCode.escape_key):
        break
    if key_typed(KeyCode.a_key):
        current_scale = current_scale - scale_step
        if current_scale < min_scale:
            current_scale = min_scale
    if key_typed(KeyCode.d_key):
        current_scale = current_scale + scale_step
        if current_scale > max_scale:
            current_scale = max_scale
    if key_typed(KeyCode.r_key):
        current_scale = 1.0
    if key_typed(KeyCode.space_key):
        show_outline = not show_outline

    # I am clearing the frame to white.
    clear_screen(rgb_color(255, 255, 255))

    # I am drawing the sticker centered with the current scale applied.
    draw_x = center_x - bitmap_width(sticker_bitmap) / 2.0
    draw_y = center_y - bitmap_height(sticker_bitmap) / 2.0
    draw_bitmap(sticker_bitmap, draw_x, draw_y, option_scale_bmp(current_scale, current_scale))

    # I am drawing an outline that matches the scaled size.
    if show_outline:
        outline_width  = bitmap_width(sticker_bitmap)  * current_scale
        outline_height = bitmap_height(sticker_bitmap) * current_scale
        draw_rectangle(rgb_color(0, 0, 128),
                       center_x - outline_width / 2.0,
                       center_y - outline_height / 2.0,
                       outline_width,
                       outline_height)

    # I am drawing the UI hints and the current scale.
    draw_text("A: smaller   D: bigger   R: reset   SPACE: outline   ESC: quit",
              rgb_color(0, 0, 128), 16, 16)
    draw_text(f"Scale: {current_scale:0.1f} x", rgb_color(0, 0, 0), 16, 40)

    refresh_screen()
    delay(16)

# I am freeing the bitmap before I quit.
free_bitmap(sticker_bitmap)