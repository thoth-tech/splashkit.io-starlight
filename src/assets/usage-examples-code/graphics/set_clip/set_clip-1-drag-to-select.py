# Usage Example for: https://splashkit.io/api/graphics/#set-clip-3
# Goal: To let the user drag a rectangle and I am calling set_clip(...) to limit drawing to that region.
# Why: I am showing how clipping is restricting later drawing; I am pressing R to reset to the full window.
# Controls: I am dragging with Left Mouse | I am pressing R to reset | I am pressing ESC to quit.
# Note: I am drawing a moving background so clipping is obvious; the red rubber-band is never clipped.

from splashkit import *
from splashkit import KeyCode, MouseButton  # my binding uses lower-case enums

# I am mapping the controls to my binding's enum names
R   = KeyCode.r_key
ESC = KeyCode.escape_key
LB  = MouseButton.left_button

# I am wrapping text/refresh to survive small API shape differences
def txt(s, c, x, y):
    for fn_name in ("draw_text", "draw_text_on_window"):
        f = globals().get(fn_name)
        if not callable(f): 
            continue
        try:
            f(s, c, x, y); return
        except Exception:
            pass
        try:
            f(c, s, x, y); return
        except Exception:
            pass
        if "option_defaults" in globals():
            try:
                f(s, c, x, y, option_defaults()); return
            except Exception:
                pass
            try:
                f(c, s, x, y, option_defaults()); return
            except Exception:
                pass

def tick(fps=60):
    try:
        refresh_screen(fps)
    except TypeError:
        refresh_screen()

# I am using rgb_color so this works even if COLOR_* constants differ
WHITE  = rgb_color(255, 255, 255)
STRIPE = rgb_color(220, 240, 255)
GRID   = rgb_color(176, 196, 222)
NAVY   = rgb_color(0, 0, 128)
RED    = rgb_color(255, 0, 0)

open_window("set_clip, drag to select, R to reset", 800, 500)

dragging = False         # I am checking whether I am dragging
sx = sy = 0.0            # I am remembering where the drag is starting
frame = 0                # I am ticking a simple animation

while not quit_requested():
    process_events()
    if key_typed(ESC):
        break            # I am quitting on ESC
    if key_typed(R):
        reset_clip()     # I am resetting the clip on R

    # I am beginning a drag when LMB is going down
    if (not dragging) and mouse_down(LB):
        dragging = True
        sx, sy = mouse_x(), mouse_y()

    # I am finishing the drag on release and I am setting the clip to that rectangle
    if dragging and (not mouse_down(LB)):
        ex, ey = mouse_x(), mouse_y()
        x, y = min(sx, ex), min(sy, ey)
        w, h = abs(ex - sx), abs(ey - sy)
        if w > 0 and h > 0:
            set_clip(rectangle_from(x, y, w, h))
        dragging = False

    clear_screen(WHITE)

    # I am drawing a moving background to make the clipping effect obvious (half-speed)
    offset = (frame // 2) % 60
    for x in range(-60 + offset, 800, 60):
        fill_rectangle(STRIPE, x, 0, 30, 500)
    for y in range(0, 500, 40):
        draw_line(GRID, 0, y, 800, y)

    # I am drawing a red rubber-band during the drag (this is not clipped)
    if dragging:
        ex, ey = mouse_x(), mouse_y()
        x, y = min(sx, ex), min(sy, ey)
        w, h = abs(ex - sx), abs(ey - sy)
        draw_rectangle(RED, x, y, w, h)

    # I am showing the instructions in ASCII-only text
    txt("Drag to set clip | Press R to reset | ESC to quit", NAVY, 16, 16)

    tick(60)
    frame += 1

close_all_windows()