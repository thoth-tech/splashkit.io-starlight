from splashkit import *

open_window("Circular Toggle Button", 800, 600)

# Declaring the variables
circle_color = Color
text_color = Color
bg_color = color_white()
text = str
cursor_pos = Point2D
circle = circle_at_from_points(400, 300, 80)

while (not quit_requested()):
    process_events()

    cursor_pos = mouse_position()

    # Check for mouse position in relation to circle
    if (point_in_circle(cursor_pos, circle)):
        circle_color = color_green()
        text_color = color_green()
        text = "Point is in the circle"
        circle.radius = 90
        if (mouse_clicked(MouseButton.left_button)):
            bg_color = random_color()
    else:
        circle_color = color_bright_green()
        text_color = color_red()
        text = "Point is not in the circle"
        circle.radius = 80

    # Display the button and results
    clear_screen(bg_color)
    draw_text_no_font_no_size("Click the button to change colour of the Screen", color_black(), 200, 100)
    draw_text_no_font_no_size(text, text_color, 300, 150)
    fill_circle_record(circle_color, circle)
    draw_text_no_font_no_size("Button", color_black(), 375, 300)
    refresh_screen()

close_all_windows()