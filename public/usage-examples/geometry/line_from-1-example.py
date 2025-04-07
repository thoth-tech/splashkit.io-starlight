import splashkit
from splashkit import *

# Initialize an empty list to store lines drawn by the user
lines = []  

# Variables for storing the start and end points of a line
line_start_x = 0
line_start_y = 0
line_end_x = 0
line_end_y = 0
line_started = False  # Flag to track if the line has started

# Open a window for drawing lines
open_window("Creating Lines With Mouse Input", 800, 600)

# Main loop: runs until the program is quit
while not window_close_requested() and not key_down(KEY_ESCAPE):
    process_events()  # Process user input events like mouse clicks

    # Check if the left mouse button was clicked
    if mouse_clicked(LEFT_BUTTON):
        # If the line hasn't been started, store the start point
        if not line_started:
            line_start_x = mouse_x()
            line_start_y = mouse_y()
            line_started = True
        else:
            # If the line has started, store the end point and create the line
            line_end_x = mouse_x()
            line_end_y = mouse_y()

            # Create a new line from the start to the end point
            temp_line = line_from(line_start_x, line_start_y, line_end_x, line_end_y)
            
            # Add the created line to the lines list
            lines.append(temp_line)
            line_started = False  # Reset the flag to allow starting a new line

    clear_screen()  # Clear the screen to redraw everything

    # If the line has started, draw a temporary red line from the start to the current mouse position
    if line_started:
        draw_line(COLOR_RED, line_start_x, line_start_y, mouse_x(), mouse_y())

    # Loop through the lines list and draw each saved line
    for temp_line in lines:
        draw_line(COLOR_BLUE, temp_line)

    # Display a message at the top of the screen
    draw_text("Click anywhere to start a line", COLOR_BLACK, 50, 50)

    # Refresh the screen to show the updated drawing
    refresh_screen()

# Close the window and end the program
close_window()
