from splashkit import *

open_window("Point of Attraction", 800, 600)

# Declaring line and vriable points
cursor_pos = Point2D
closest_point = Point2D
line = line_from(150, 150, 500, 500)

while not quit_requested():
    process_events()

    cursor_pos = mouse_position()
    closest_point = closest_point_on_line(cursor_pos, line)

    # Draw the line and display results
    clear_screen(color_white())
    draw_line_record(color_black(), line)
    fill_circle(color_red(), cursor_pos.x, cursor_pos.y, 5)
    fill_circle(color_blue(), closest_point.x, closest_point.y, 5)
    draw_line_point_to_point(color_green(), cursor_pos, closest_point)
    draw_text_no_font_no_size("Cursor Position: " + point_to_string(cursor_pos), color_black(), 20, 40)
    draw_text_no_font_no_size("Closest Point on Line: " + point_to_string(closest_point), color_black(), 20, 80)
    refresh_screen()

close_all_windows()