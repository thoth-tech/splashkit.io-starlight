from splashkit import *

# Declare a variable with snake_case
example_message = "this is an example of snake_case"

def main():
    # Open a window to display the graphics
    window = open_window("Spotlight on Center", 600, 400)

    # Create a rectangle using top-left coordinates and dimensions
    example_rectangle = rectangle_from(100, 100, 200, 150)

    # Compute the center point of the rectangle
    center_point = rectangle_center(example_rectangle)

    # Load font from file (ensure "Arial.ttf" exists in the same folder)
    font = load_font("default_font", "Arial.ttf")

    while not quit_requested():
        process_events()
        clear_screen(color_white())

        # Draw the rectangle using individual properties
        draw_rectangle(
            color_blue(),
            example_rectangle.x,
            example_rectangle.y,
            example_rectangle.width,
            example_rectangle.height
        )

        # Draw a red circle at the center of the rectangle
        fill_circle(color_red(), center_point.x, center_point.y, 5)

        # Label the center point using the loaded font
        draw_text("Center", color_black(), font, 12, center_point.x + 8, center_point.y - 6)

        refresh_screen()

    # Close the window when finished
    close_window(window)

main()
