from splashkit import *

my_window = open_window("Create Sprite", 800, 600)

player_bitmap = load_bitmap("player", "player.png")

player_sprite = create_sprite(player_bitmap)

player_sprite.x = 300
player_sprite.y = 300
            
            
process_events()
clear_screen(color_black())
draw_sprite(player_sprite)
refresh_window(my_window)
close_window(my_window)