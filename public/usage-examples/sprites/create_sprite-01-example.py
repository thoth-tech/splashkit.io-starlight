from splashkit import *

open_window("Sprite Example", 800, 600)
bmp = load_bitmap("player", "images/player.png")
player = create_sprite(bmp)

while not quit_requested():
    process_events()
    clear_screen(color_white())
    draw_sprite(player)
    refresh_screen()
