from splashkit import *

SCREEN_WIDTH = 800
SCREEN_HEIGHT = 600
WORLD_WIDTH = 1600
WORLD_HEIGHT = 1000

PLAYER_SIZE = 40
MOVEMENT_SPEED = 5

open_window(
    "Move Camera To Example",
    SCREEN_WIDTH,
    SCREEN_HEIGHT
)

player_x = 380.0
player_y = 280.0

while not quit_requested():
    process_events()

    if key_down(KeyCode.left_key) or key_down(KeyCode.a_key):
        player_x -= MOVEMENT_SPEED

    if key_down(KeyCode.right_key) or key_down(KeyCode.d_key):
        player_x += MOVEMENT_SPEED

    if key_down(KeyCode.up_key) or key_down(KeyCode.w_key):
        player_y -= MOVEMENT_SPEED

    if key_down(KeyCode.down_key) or key_down(KeyCode.s_key):
        player_y += MOVEMENT_SPEED

    # Keep the player within the world.
    if player_x < 0:
        player_x = 0

    if player_x > WORLD_WIDTH - PLAYER_SIZE:
        player_x = WORLD_WIDTH - PLAYER_SIZE

    if player_y < 0:
        player_y = 0

    if player_y > WORLD_HEIGHT - PLAYER_SIZE:
        player_y = WORLD_HEIGHT - PLAYER_SIZE

    # Centre the camera on the player.
    camera_x = (
        player_x
        + PLAYER_SIZE / 2
        - SCREEN_WIDTH / 2
    )

    camera_y = (
        player_y
        + PLAYER_SIZE / 2
        - SCREEN_HEIGHT / 2
    )

    # Keep the camera within the world.
    if camera_x < 0:
        camera_x = 0

    if camera_x > WORLD_WIDTH - SCREEN_WIDTH:
        camera_x = WORLD_WIDTH - SCREEN_WIDTH

    if camera_y < 0:
        camera_y = 0

    if camera_y > WORLD_HEIGHT - SCREEN_HEIGHT:
        camera_y = WORLD_HEIGHT - SCREEN_HEIGHT

    # Move the camera to the calculated world position.
    move_camera_to(camera_x, camera_y)

    clear_screen(color_white())

    # Draw a simple grid to show camera movement.
    for x in range(0, WORLD_WIDTH + 1, 200):
        draw_line(
            color_light_gray(),
            x,
            0,
            x,
            WORLD_HEIGHT
        )

    for y in range(0, WORLD_HEIGHT + 1, 200):
        draw_line(
            color_light_gray(),
            0,
            y,
            WORLD_WIDTH,
            y
        )

    # Draw simple landmarks within the world.
    fill_rectangle(color_green(), 100, 100, 180, 120)
    fill_circle(color_red(), 800, 450, 70)
    fill_rectangle(color_orange(), 1300, 750, 180, 120)

    # Draw the world boundary and player.
    draw_rectangle(
        color_black(),
        0,
        0,
        WORLD_WIDTH,
        WORLD_HEIGHT
    )

    fill_rectangle(
        color_blue(),
        player_x,
        player_y,
        PLAYER_SIZE,
        PLAYER_SIZE
    )

    refresh_screen()

close_all_windows()