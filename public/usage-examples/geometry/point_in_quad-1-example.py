from splashkit import *

open_window("Point In Quad", 800, 600)

quad_color = Color
text = str
quad = quad_from_points(point_at(250, 180), point_at(500, 210), point_at(300, 380), point_at(480, 480))

while (not quit_requested()):
    process_events()
    cursor_pos = mouse_position()

    # The text and quad colour is updated depending on whether cursor is inside the quad
    if (
        point_in_quad(cursor_pos, quad)):
        quad_color = color_green()
        text = "Cursor in the quad!"
    else:
        quad_color = color_red()
        text = "Cursor not in the quad!"

    clear_screen(color_white())
    draw_quad(quad_color, quad)
    draw_text_no_font_no_size(text, quad_color, 300, 100)
    refresh_screen()

close_all_windows()