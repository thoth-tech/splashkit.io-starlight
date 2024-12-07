from splashkit import *

open_window("Lines Intersect", 800, 600)

# Define points for the lines
start_point_1 = Point2D()
start_point_1.x = 100
start_point_1.y = 150
end_point_1 = Point2D()
end_point_1.x = 500
end_point_1.y = 550

start_point_2 = Point2D()
start_point_2.x = 100
start_point_2.y = 550
end_point_2 = Point2D()
end_point_2.x = 500
end_point_2.y = 150

start_point_3 = Point2D()
start_point_3.x = 550
start_point_3.y = 150
end_point_3 = Point2D()
end_point_3.x = 550
end_point_3.y = 500

# Draw the lines
demo_line_1 = line_from_point_to_point(start_point_1, end_point_1)
draw_line_record(color_red(), demo_line_1)
draw_text_no_font_no_size(
    "A", color_black(), start_point_1.x - 20, start_point_1.y - 10)

demo_line_2 = line_from_point_to_point(start_point_2, end_point_2)
draw_line_record(color_blue(), demo_line_2)
draw_text_no_font_no_size(
    "B", color_black(), start_point_2.x - 20, start_point_2.y - 10)

demo_line_3 = line_from_point_to_point(start_point_3, end_point_3)
draw_line_record(color_green(), demo_line_3)
draw_text_no_font_no_size(
    "C", color_black(), start_point_3.x - 20, start_point_3.y - 10)

# Check intersections
intersect_1_2 = lines_intersect(demo_line_1, demo_line_2)
intersect_1_3 = lines_intersect(demo_line_1, demo_line_3)

# Display intersection results
draw_text_no_font_no_size(
    "A and B intersect: " + ("Yes" if intersect_1_2 else "No"), color_black(), 150, 130)
draw_text_no_font_no_size(
    "A and C intersect: " + ("Yes" if intersect_1_3 else "No"), color_black(), 150, 150)

refresh_screen()
delay(5000)
close_all_windows()
