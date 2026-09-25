from splashkit import *

open_window("Mouse Movement Display", 800, 600)

circle_x = 400
circle_y = 300

while not quit_requested():
    process_events()

    movement = mouse_movement()

    circle_x += movement.x
    circle_y += movement.y

    clear_screen(color_white())

    draw_text_no_font_no_size("Move the mouse to see mouse_movement() values.", color_black(), 20, 20)
    draw_text_no_font_no_size("Movement X: " + str(movement.x), color_black(), 20, 60)
    draw_text_no_font_no_size("Movement Y: " + str(movement.y), color_black(), 20, 100)

    fill_circle(color_blue(), circle_x, circle_y, 15)
    draw_circle(color_black(), circle_x, circle_y, 15)

    draw_line(color_red(), circle_x, circle_y, circle_x + movement.x * 5, circle_y + movement.y * 5)

    refresh_screen_with_target_fps(60)

close_all_windows()