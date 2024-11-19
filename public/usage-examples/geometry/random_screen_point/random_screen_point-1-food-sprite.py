from splashkit import *

#Create Window
open_window("draw sprite random", 600, 600)

load_bitmap("food", "food.png")
food_sprite = create_sprite(bitmap_named("food"))

#set random food location
sprite_set_position(food_sprite, random_screen_point())


clear_screen(color_black())

#Draw the sprite
draw_sprite(food_sprite)

refresh_screen()
delay(5000)
close_all_windows()
