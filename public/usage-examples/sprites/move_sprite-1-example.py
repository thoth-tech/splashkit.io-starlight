from splashkit import *

# Open the main game window
open_window("2D Player movement", 800, 600)

# Load the player bitmap from file
player_bitmap = load_bitmap("player", "player_sprite.png")

# Create a sprite for the player
player_sprite = create_sprite(player_bitmap)

# Position the sprite in the center of the window
sprite_set_x(player_sprite, 400)
sprite_set_y(player_sprite, 300)

# Main game loop
while not quit_requested():
    process_events()

    # Move the sprite based on key input
    movement_vector = vector_to(0, 0)

    if key_down(KeyCode.w_key):
        movement_vector.y -= 5
    if key_down(KeyCode.s_key):
        movement_vector.y += 5
    if key_down(KeyCode.a_key):
        movement_vector.x -= 5
    if key_down(KeyCode.d_key):
        movement_vector.x += 5

    move_sprite_by_vector(player_sprite, movement_vector)

    clear_screen(color_white())
    draw_sprite(player_sprite)
    refresh_screen_with_target_fps(60)
