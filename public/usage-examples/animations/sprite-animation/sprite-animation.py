from splashkit import *

open_window("Sprite Animation Example", 800, 600)

player_bitmap = load_bitmap("player", "player.png")
player = create_sprite(player_bitmap)

sprite_set_x(player, 0)
sprite_set_y(player, 300)

while not quit_requested():
    process_events()

    # Move sprite across screen
    sprite_set_x(player, sprite_x(player) + 2)

    clear_screen(ColorWhite)

    draw_sprite(player)

    refresh_screen(60)