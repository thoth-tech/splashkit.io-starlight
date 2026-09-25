from splashkit import *

open_window("Opposite Point to Mouse on Circle", 800, 600)

# Circle setup
circle_centre = point_at(400, 300)
radius = 120
demo_circle = circle_at(circle_centre, radius)

while not quit_requested():
    process_events()

    # Mouse as test point
    test_point = mouse_position()

    # Calculate distant point
    distant_point = distant_point_on_circle(test_point, demo_circle)

    clear_screen(color_white())

    # Draw main circle
    draw_circle(color_black(), circle_centre.x, circle_centre.y, radius)

    # Draw lines (FIXED)
    draw_line(color_gray(),
              circle_centre.x, circle_centre.y,
              test_point.x, test_point.y)

    draw_line(color_green(),
              circle_centre.x, circle_centre.y,
              distant_point.x, distant_point.y)

    # Draw points
    fill_circle(color_red(), test_point.x, test_point.y, 6)
    fill_circle(color_green(), distant_point.x, distant_point.y, 8)
    fill_circle(color_blue(), circle_centre.x, circle_centre.y, 5)

    # Labels
    draw_text_no_font_no_size("Move the mouse to change the test point", color_black(), 20, 20)
    draw_text_no_font_no_size("Red = test point", color_red(), 20, 50)
    draw_text_no_font_no_size("Green = distant point on circle", color_green(), 20, 80)
    draw_text_no_font_no_size("Blue = circle centre", color_blue(), 20, 110)

    refresh_screen()

close_all_windows()