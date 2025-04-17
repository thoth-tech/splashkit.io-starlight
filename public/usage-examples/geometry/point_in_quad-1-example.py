from splashkit import *

window = open_window("Point In Quad", 800, 600)

quad = quad_from_points(point_at(250, 180), point_at(500, 210), point_at(300, 380), point_at(480, 480))
cursor_pos = Point2D
text = str
quad_clr = Color

while (not quit_requested()):
    process_events()
    cursor_pos = mouse_position()

    # The text and quad colour is updated depending on whether cursor is inside the quad
    if (
        point_in_quad(cursor_pos, quad)):
        quad_clr = color_green()
        text = "Point in the Circle!"
    else:
        quad_clr = color_red()
        text = "Point not in the Circle!"

    clear_screen_to_white()
    draw_quad(quad_clr, quad)
    draw_text_no_font_no_size(text, quad_clr, 300, 100)
    refresh_screen()

close_window(window)