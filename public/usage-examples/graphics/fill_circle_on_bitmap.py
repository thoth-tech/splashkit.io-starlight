from splashkit import *

window = open_window("Python Circle Drawer", 400, 400)
surface = create_bitmap("surface", 400, 400)
clear_bitmap(surface, color_black())

main_color = rgba_color(180, 0, 0, 255)
fill_circle_on_bitmap(surface, main_color, 200, 200, 150)
draw_circle_on_bitmap(surface, color_red(), 200, 200, 150)

for _ in range(15):
    x = rnd(100, 300)
    y = rnd(100, 300)
    radius = rnd(10, 30)
    draw_circle_on_bitmap(surface, color_red(), x, y, radius)

while not window_close_requested(window):
    process_events()
    draw_bitmap(surface, 0, 0)
    refresh_screen()

free_bitmap(surface)
close_all_windows()
