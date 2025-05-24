from splashkit import *

# Declare a variable with snake_case
example_message = "this is an example of snake_case"

def main():
    open_window("Spotlight on Center", 600, 400)

    example_rectangle = rectangle_from(100, 100, 200, 150)
    center_point = rectangle_center(example_rectangle)

    while not quit_requested():
        process_events()
        clear_screen(color_white())

        # Draw rectangle with numeric arguments
        draw_rectangle(
            color_blue(),
            example_rectangle.x,
            example_rectangle.y,
            example_rectangle.width,
            example_rectangle.height
        )

        # Draw the center point
        fill_circle(color_red(), center_point.x, center_point.y, 5)

        # Draw label near the center
        draw_text("Center", color_black(), "Arial", 12, center_point.x + 8, center_point.y - 6)

        refresh_screen()

    close_window("Spotlight on Center")

main()
