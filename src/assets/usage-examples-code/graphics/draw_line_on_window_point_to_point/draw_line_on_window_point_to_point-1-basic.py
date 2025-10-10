# I am drawing lines on the window by clicking a start point and an end point.
# I am left-clicking once for start; I am left-clicking again for end; I am pressing C to clear; I am pressing ESC to quit.

from splashkit import *
from splashkit import MouseButton, KeyCode

# I am showing the controls in the title to avoid per-OS font issues.
open_window("Draw Line - point to point | Click start/end  C clear  ESC quit", 720, 405)

# I am keeping finished segments so I can redraw them every frame.
segments: list[tuple[float, float, float, float]] = []

# I am remembering whether I have a start point for the current segment.
has_start = False
sx, sy = 0.0, 0.0  # I am storing the start point after the first click.

while not quit_requested():
    process_events()  # I am polling input every frame.

    # I am handling quit and clear.
    if key_typed(KeyCode.escape_key):
        break
    if key_typed(KeyCode.c_key):
        segments.clear()   # I am clearing finished segments.
        has_start = False  # I am cancelling the partial segment.

    # I am turning two clicks into one segment.
    if mouse_clicked(MouseButton.left_button):
        mx = mouse_x()
        my = mouse_y()

        if not has_start:
            # I am recording the start point on the first click.
            has_start = True
            sx, sy = mx, my
        else:
            # I am recording the end point on the second click.
            segments.append((sx, sy, mx, my))
            has_start = False

    # I am rendering the frame.
    clear_screen(rgb_color(255, 255, 255))

    # I am drawing all finished segments in navy.
    for x1, y1, x2, y2 in segments:
        draw_line(rgb_color(0, 0, 128), x1, y1, x2, y2)

    # I am previewing the current segment in orange from start to mouse.
    if has_start:
        mx = mouse_x()
        my = mouse_y()
        draw_line(rgb_color(255, 69, 0), sx, sy, mx, my)
        fill_circle(rgb_color(255, 69, 0), sx, sy, 3)  # I am marking the start point.

    refresh_screen()  # I am matching ~60 FPS with the delay below.
    delay(16)