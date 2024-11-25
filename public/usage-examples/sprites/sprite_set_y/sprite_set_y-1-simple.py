from splashkit import *


open_window("sprite_set_y", 600, 600)

player_bitmap = load_bitmap("player", "player-run.png")

player_sprite = create_sprite(player_bitmap)

sprite_set_y(player_sprite, 300)

<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
clear_screen(color_black())
draw_sprite(player_sprite)
refresh_screen()
delay(5000)
<<<<<<< Updated upstream
close_window()
=======
close_window()
>>>>>>> Stashed changes
