from splashkit import *

spinning_line = Line
fixed_line = Line
spinning_line_rotation_point = Point2D()
spinning_line_rotation_degrees = 0
line_intersection_coordinates = Point2D()

open_window("Line Intersection Point", 800, 600)

while (not quit_requested()):
    process_events()
    
    # For the spinning line, only one point spins as the other is fixed. The code below increments a variable by 0.01 every frame
    spinning_line_rotation_degrees = spinning_line_rotation_degrees + 0.01
    
    # This code takes the constantly increasing variable and uses trignometry functions to generate a Point2D variable which perpetually moves in a circle
    spinning_line_rotation_point = point_at((250 + 100 * cosine(spinning_line_rotation_degrees)), (250 + 100 * sine(spinning_line_rotation_degrees)))
  
    # The two line's coordinates are set, for a given frame. The fixed line stays static
    spinning_line = line_from_point_to_point(point_at(250, 250), spinning_line_rotation_point)
    fixed_line = line_from_point_to_point(point_at(400, 0), point_at(800, 400))

    # The 'line_intersection_coordinates' variable holds the Point2D data of where the two lines intersect/ would intersect
    line_intersection_point(spinning_line, fixed_line, line_intersection_coordinates)

    clear_screen(color_white())
    draw_line_record(color_black(), spinning_line)
    draw_line_record(color_black(), fixed_line)
    fill_circle_record(color_red(), circle_at(line_intersection_coordinates, 5))
    draw_text_no_font_no_size(f"Position of intersection between the two lines would be at: {line_intersection_coordinates.x:.0f}, {line_intersection_coordinates.y:.0f}", color_black(), 60, 500)
    
    refresh_screen()

close_all_windows()