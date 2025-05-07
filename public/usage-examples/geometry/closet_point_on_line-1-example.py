from splashkit import *

open_window("Magnetic Point", 600, 600)

ptA = point_at(100, 100)
ptB = point_at(500, 400)
line = line_from_point_to_point(ptA, ptB)

while not quit_requested():
    process_events()
    clear_screen(color_white())

    mouse_pt = mouse_position()
    closest_pt = closest_point_on_line(mouse_pt, line)

    draw_line_record(color_black(), line)
    fill_circle(color_blue(), mouse_pt.x, mouse_pt.y, 5)
    fill_circle(color_red(), closest_pt.x, closest_pt.y, 5)
    draw_line_point_to_point(color_gray(), mouse_pt, closest_pt)

    draw_text_no_font_no_size("Mouse: " + point_to_string(mouse_pt), color_black(), 20, 520)
    draw_text_no_font_no_size("Closest: " + point_to_string(closest_pt), color_red(), 20, 540)

    refresh_screen()
 
close_all_windows()
