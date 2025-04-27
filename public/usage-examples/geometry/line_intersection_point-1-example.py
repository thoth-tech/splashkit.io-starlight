from splashkit import *

open_window("Line Intersection Point", 800, 600)

line1 = Line
line2 = Line
line1_rotation_degrees = 0
boolean = None
line1_rotation_coordinates = Point2D()
line_intersection_coordinates = Point2D()

while (not quit_requested()):
    process_events()

    line1_rotation_degrees = line1_rotation_degrees + 0.01
    line1_rotation_coordinates = point_at((250 + 100 * cosine(line1_rotation_degrees)), (250 + 100 * sine(line1_rotation_degrees)))
  
    line1 = line_from_point_to_point(point_at(250, 250), line1_rotation_coordinates)
    line2 = line_from_point_to_point(point_at(400, 0), point_at(800, 400))

    # The boolean variable that this function returns to isn't relevant
    # The 'line_intersection_coordinates' variable as noted here holds the Point2D data of where the two lines would intersect instead
    boolean = line_intersection_point(line1, line2, line_intersection_coordinates)

    clear_screen_to_white()
    draw_line_record(color_black(), line1)
    draw_line_record(color_black(), line2)
    fill_circle_record(color_red(), circle_at(line_intersection_coordinates, 5))
    draw_text_no_font_no_size("Position of intersection between the two lines would be at: " + point_to_string(line_intersection_coordinates), color_black(), 60, 500)
    refresh_screen()

close_all_windows()