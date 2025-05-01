from splashkit import *

# Globals
current_sprite = None
loaded_sprite = ""

def load_sprite(sprite_id, filename):
    global current_sprite, loaded_sprite

    if loaded_sprite != sprite_id:
        free_all_sprites()

        if not has_bitmap(sprite_id):
            load_bitmap(sprite_id, filename)

        current_sprite = create_sprite(bitmap_named(sprite_id))
        sprite_set_position(current_sprite, point_at(400, 300))
        loaded_sprite = sprite_id

def handle_input():
    velocity = vector_to(0, 0)

    if key_down(UP_KEY):
        velocity.y = -3
    if key_down(DOWN_KEY):
        velocity.y = 3
    if key_down(LEFT_KEY):
        velocity.x = -3
    if key_down(RIGHT_KEY):
        velocity.x = 3

    sprite_set_velocity(current_sprite, velocity)

    if key_typed(NUM_1_KEY):
        load_sprite("player1", "player1.png")
    if key_typed(NUM_2_KEY):
        load_sprite("player2", "player2.png")

# Setup
open_window("Sprite Switcher", 800, 600)
load_sprite("player1", "player1.png")

# Game loop
while not window_close_requested("Sprite Switcher"):
    process_events()
    handle_input()

    update_sprite(current_sprite)
    move_sprite(current_sprite)

    clear_screen(Color.White)
    draw_sprite(current_sprite)
    draw_text("Use arrow keys to move. Press 1 or 2 to switch.", Color.Black, 10, 10)
    refresh_screen(60)
