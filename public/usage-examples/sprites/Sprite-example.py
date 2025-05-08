from splashkit import *

# Global state
current_sprite = None
loaded_sprite = ""

def load_sprite(sprite_id, filename):
    global current_sprite, loaded_sprite

    if loaded_sprite != sprite_id:
        free_all_sprites()

        if not has_bitmap(sprite_id):
            load_bitmap(sprite_id, filename)

        current_sprite = create_sprite(bitmap_named(sprite_id))
        loaded_sprite = sprite_id

        center_x = 800 / 2 - sprite_width(current_sprite) / 2
        center_y = 600 / 2 - sprite_height(current_sprite) / 2
        sprite_set_position(current_sprite, point_at(center_x, center_y))

def handle_input():
    velocity = vector_to(0, 0)

    if key_down(UP_KEY): velocity.y = -3
    if key_down(DOWN_KEY): velocity.y = 3
    if key_down(LEFT_KEY): velocity.x = -3
    if key_down(RIGHT_KEY): velocity.x = 3

    sprite_set_velocity(current_sprite, velocity)

    if key_typed(NUM_1_KEY):
        load_sprite("player1", "player1.png")
    if key_typed(NUM_2_KEY):
        load_sprite("player2", "player2.png")

# Setup and loop
open_window("Sprite Switcher", 800, 600)
load_sprite("player1", "player1.png")

while not window_close_requested("Sprite Switcher"):
    process_events()
    handle_input()
    update_sprite(current_sprite)
    move_sprite(current_sprite)

    clear_screen(Color.White)
    draw_sprite(current_sprite)
    draw_text("Use arrow keys to move. Press 1 or 2 to switch characters.", Color.Black, 10, 10)
    refresh_screen(60)
