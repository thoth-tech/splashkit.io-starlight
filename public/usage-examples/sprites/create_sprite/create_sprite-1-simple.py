from splashkit import *

open_window("Create Sprite", 800, 600)


player = load_bitmap("player_bitmap", "player.png");


player_sprite = create_sprite(player);

sprite_set_x(player_sprite, 300);
sprite_set_y(player_sprite, 300);

clear_screen(color_black())
draw_sprite(player_sprite);
refresh_screen();
delay(5000);
close_all_windows();