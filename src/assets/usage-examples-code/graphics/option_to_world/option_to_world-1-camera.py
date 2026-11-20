# Usage Example for: https://splashkit.io/api/graphics/#option-to-world
# Goal: I am demonstrating world vs screen coordinates by panning a camera.
# Why: I am showing how world-anchored things move under the camera while a screen HUD does not.
# Controls: I am using Arrow keys to pan camera | I am pressing C to reset | I am pressing SPACE to toggle HUD | I am pressing ESC to quit.

from splashkit import *
from splashkit import KeyCode  # my binding uses lower-case enums

# I am mapping the keys I am using.
LEFT, RIGHT, UP, DOWN = KeyCode.left_key, KeyCode.right_key, KeyCode.up_key, KeyCode.down_key
SPACE, ESC, C = KeyCode.space_key, KeyCode.escape_key, KeyCode.c_key

# I am opening the window (title ASCII, size inlined).
open_window("Option To World - camera", 800, 480)

# I am storing the camera offset in world space.
cam_x = 0.0
cam_y = 0.0
CAM_SPEED = 8.0

show_hud = True  # I am showing a screen-fixed HUD.

# I am defining colours I am using.
WHITE = rgb_color(255, 255, 255)
LIGHT = rgb_color(200, 200, 200)
NAVY  = rgb_color(10, 24, 48)
BLACK = rgb_color(0, 0, 0)
CORN  = rgb_color(100, 149, 237)
ORNG  = rgb_color(255, 140, 0)

# I am running the main loop until I am asking to quit.
while not quit_requested():
    process_events()

    # I am quitting when ESC is pressed.
    if key_typed(ESC):
        break

    # I am panning the camera with Arrow keys.
    if key_down(LEFT):
        cam_x = cam_x - CAM_SPEED
    if key_down(RIGHT):
        cam_x = cam_x + CAM_SPEED
    if key_down(UP):
        cam_y = cam_y - CAM_SPEED
    if key_down(DOWN):
        cam_y = cam_y + CAM_SPEED

    # I am toggling the HUD with SPACE.
    if key_typed(SPACE):
        show_hud = not show_hud

    # I am resetting the camera with C.
    if key_typed(C):
        cam_x = 0.0
        cam_y = 0.0

    clear_screen(WHITE)

    # I am drawing a light grid in world space.
    for gx in range(-1600, 1601, 80):
        draw_line(LIGHT, gx - cam_x, -2000.0 - cam_y, gx - cam_x, 2000.0 - cam_y)
    for gy in range(-1600, 1601, 80):
        draw_line(LIGHT, -2000.0 - cam_x, gy - cam_y, 2000.0 - cam_x, gy - cam_y)

    # I am drawing two world-anchored shapes.
    draw_circle(CORN, int(200.0 - cam_x), int(120.0 - cam_y), 28.0)
    draw_rectangle(ORNG, int(400.0 - cam_x), int(200.0 - cam_y), 80, 52)

    # I am drawing a screen-fixed HUD (wider so text is not clipped).
    if show_hud:
        fill_rectangle(NAVY, 10, 480 - 60, 420, 48)
        draw_text("SCREEN HUD (fixed) - toggle with SPACE", rgb_color(255, 255, 255), "arial", 14, 16, 480 - 44)

    # I am drawing the on-screen instructions.
    draw_text(
        "Camera: x={} y={}  |  Arrows: pan  |  C: reset  |  SPACE: HUD  |  ESC: quit".format(int(cam_x), int(cam_y)),
        BLACK, "arial", 14, 10, 10
    )

    refresh_screen()
    delay(16)  # I am pacing to ~60 FPS.