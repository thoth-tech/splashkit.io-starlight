from splashkit import *

window = open_window("Vector Field with line_from", 800, 600)
clear_screen(color_white())

direction = vector_to(20.0, 10.0)
step_x = 80
step_y = 60

for x in range(0, screen_width(), step_x):
    for y in range(0, screen_height(), step_y):
        origin = point_at(float(x), float(y))
        end = point_at(origin.x + direction.x, origin.y + direction.y)
        draw_line(color_green(), origin.x, origin.y, end.x, end.y)

refresh_screen()

while not window_close_requested(window):
    process_events()