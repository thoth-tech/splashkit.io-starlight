from splashkit import *

def draw_edge(edge, color):
    # Draw a line using the edge's start and end points
    # This avoids any confusion with overloaded functions
    draw_line(color,
              edge.start_point.x, edge.start_point.y,
              edge.end_point.x, edge.end_point.y)

def main():
    # Open a graphical window with the title and size
    window = open_window("Lines From Rectangle Example", 800, 600)

    # Define normal colors for the rectangle edges
    normal_colors = [
        color_red(),         # Top
        color_lime_green(),  # Right
        color_blue(),        # Bottom
        color_orange()       # Left
    ]

    # Define hover colors (all white)
    hover_colors = [
        color_white(),
        color_white(),
        color_white(),
        color_white()
    ]

    # Create a rectangle centered in the window (300x200)
    rect_x = (800 - 300) / 2
    rect_y = (600 - 200) / 2
    my_rect = rectangle_from(rect_x, rect_y, 300, 200)

    # Main program loop — runs until the window is closed
    while not window_close_requested(window):
        # Handle user input (mouse, keyboard, etc.)
        process_events()

        # Set the background color for the screen
        clear_screen(color_dark_slate_gray())

        # Draw the rectangle background in black
        fill_rectangle(color_black(),
                       my_rect.x, my_rect.y,
                       my_rect.width, my_rect.height)

        # Get the four edges of the rectangle
        edges = lines_from_rectangle(my_rect)

        # Get the current mouse position
        mouse = mouse_position()

        # Loop through and draw each edge
        for i in range(4):
            # If the mouse is hovering over this edge
            if point_on_line(mouse, edges[i]):
                draw_edge(edges[i], hover_colors[i])  # Highlight in white
            else:
                draw_edge(edges[i], normal_colors[i]) # Draw in normal color

        # Update the screen to show all drawings
        refresh_screen_with_target_fps(60)

    # Close the window after exiting the loop
    close_window(window)

# Run the main function to start the program
main()