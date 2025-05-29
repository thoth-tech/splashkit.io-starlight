from splashkit import *

# open a window with a clear description of what's shown
open_window("Line Intersects Lines - Interactive Demo", 800, 600)

# create three static lines that intersectingLine may intersect
line1_start = point_at(100, 150)
line1_end = point_at(700, 150)

line2_start = point_at(100, 300)
line2_end = point_at(700, 300)

line3_start = point_at(100, 450)
line3_end = point_at(700, 450)

# list of tuples, each representing a line with a start and end point
lines_to_check = [
    (line1_start, line1_end),
    (line2_start, line2_end),
    (line3_start, line3_end)
]

while not quit_requested():
    process_events()

    # create a line from origin to mouse position
    intersecting_line_start = point_at(0, 0)
    intersecting_line_end = point_at(mouse_x(), mouse_y())

    clear_screen(color_white)

    # draw the intersecting line in red
    draw_line(color_red, intersecting_line_start, intersecting_line_end)

    # track whether any intersection has occurred
    any_intersection = False

    # draw each line and check for intersection
    for start, end in lines_to_check:
        if lines_intersect(intersecting_line_start, intersecting_line_end, start, end):
            draw_line(color_green, start, end)  # highlight intersecting lines in green
            any_intersection = True
        else:
            draw_line(color_black, start, end)  # non-intersecting lines in black

    # display the result
    if any_intersection:
        draw_text("Intersection Detected!", color_green, 20, 20)
    else:
        draw_text("No Intersection", color_gray, 20, 20)

    draw_text("Move mouse to test intersections", color_black, 20, 570)

    refresh_screen()

# close window when finished
close_all_windows()
