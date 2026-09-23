from splashkit import *

open_window("Sprite Circle Collision", 540, 380)

sprite_bitmap = load_bitmap("player", "skbox.png")
player = create_sprite(sprite_bitmap)
sprite_set_position(player, point_at(70, 90))

collision_circle = circle_at(point_at(120, 140), 70)
clear_circle = circle_at(point_at(460, 290), 40)

clear_screen(color_white())

fill_circle(color_green(), 120, 140, 70)
fill_circle(color_red(), 460, 290, 40)

draw_sprite(player)

green_collision = sprite_circle_collision(player, collision_circle)
red_collision = sprite_circle_collision(player, clear_circle)

if green_collision:
    write_line("Green Circle Collision")

if not red_collision:
    write_line("No Red Circle Collision")

refresh_screen()
delay(4000)

free_sprite(player)
free_bitmap(sprite_bitmap)
close_all_windows()
