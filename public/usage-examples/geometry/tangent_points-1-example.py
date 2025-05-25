from splashkit import *

open_window("Tangent Points Calculation", 800, 600)

# Create the circle at (400, 300) with radius 100
circle = circle_at(point_at(400, 300), 100)

while not quit_requested():
    process_events()
    cursor_pos = mouse_position()  # Mouse is the external point

    clear_screen()

    # Draw the circle
    draw_circle(color_black(), circle)

    # Draw the external point (mouse)
    fill_circle(color_blue(), cursor_pos.x, cursor_pos.y, 5)

    # Display mouse coordinates
    draw_text(f"Mouse Position (External Point): ({int(cursor_pos.x)}, {int(cursor_pos.y)})",
              color_black(), "Arial", 16, 10, 10)

    # Calculate and draw tangent points if mouse is outside the circle
    tangent_result = tangent_points(cursor_pos, circle)
    if tangent_result:
        tangent1, tangent2 = tangent_result

        fill_circle(color_red(), tangent1.x, tangent1.y, 5)
        fill_circle(color_red(), tangent2.x, tangent2.y, 5)
        draw_line(color_green(), cursor_pos, tangent1)
        draw_line(color_green(), cursor_pos, tangent2)

        # Show tangent point coordinates
        draw_text(f"Tangent 1: ({int(tangent1.x)}, {int(tangent1.y)})", color_black(), "Arial", 16, 10, 35)
        draw_text(f"Tangent 2: ({int(tangent2.x)}, {int(tangent2.y)})", color_black(), "Arial", 16, 10, 60)
    else:
        draw_text("Move the mouse outside the circle to see tangent points.",
                  color_black(), "Arial", 16, 10, 35)

    refresh_screen()

close_all_windows()
