from splashkit import *

# Declare a variable with snake_case
example_message = "this is an example of snake_case"

def main():
    # Open a graphics window with a descriptive title
    window = open_window("Framed and Labeled", 600, 400)

    # Create a rectangle with given position and size
    example_rectangle = rectangle_from(100, 150, 200, 120)

    # Convert the rectangle into a string to display
    rectangle_text = rectangle_to_string(example_rectangle)

    # Load the font used for drawing text on the window
    font = load_font("default_font", "Arial.ttf")

    while not quit_requested():
        process_events()
        clear_screen(color_white())

        # Draw the rectangle in blue
        draw_rectangle(
            color_blue(),
            example_rectangle.x,
            example_rectangle.y,
            example_rectangle.width,
            example_rectangle.height
        )

        # Draw the rectangle's string representation in black
        draw_text(rectangle_text, color_black(), font, 14, 20, 20)

        refresh_screen()

    # Properly close the window using the stored window reference
    close_window(window)

main()
