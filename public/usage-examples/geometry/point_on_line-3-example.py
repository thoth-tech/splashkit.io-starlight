from splashkit import *

def point_on_line_example():
    # Open a window with a descriptive name
    open_window("Point On Line Example", 800, 600)

    # Define a horizontal line from point (100, 300) to (700, 300)
    horizontal_line = line_from(100, 300, 700, 300)

    # Random hidden point on the line
    hidden_x = int(100 + rnd() * 600)
    hidden_point = point_at(hidden_x, 300)

    point_found = False

    # Run until the user closes the window
    while not quit_requested():
        # Update mouse and keyboard input
        process_events()

        # Clear the screen before drawing
        clear_screen(color_white())

        # Draw the black line
        draw_line_record(color_black(), horizontal_line)

        # Get current mouse position
        mouse_pos = mouse_position()

        # Check how close the mouse is to the hidden point
        if not point_found and point_point_distance(mouse_pos, hidden_point) <= 8:
            # User found the hidden point
            point_found = True

        if point_found:
            # Show the found point and success message
            draw_circle(color_blue(), hidden_point.x, hidden_point.y, 5)
            draw_text_no_font_no_size("You found the hidden point!", color_green(), 250, 450)
            draw_text_no_font_no_size("Close the window to exit.", color_black(), 280, 500)
        else:
            # Instruct user to find the hidden point
            draw_text_no_font_no_size("Move your mouse over the line to find the hidden point!", color_black(), 150, 450)

        # Show the new frame
        refresh_screen()

if __name__ == "__main__":
    point_on_line_example()
